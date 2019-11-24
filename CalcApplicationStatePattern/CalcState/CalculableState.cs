using CalcApplication;

namespace CalcState
{
    #region 計算可能状態クラス
    /// <summary>
    /// 計算可能状態クラス
    /// </summary>
    public class CalculableState : StateIF
    {
        #region コンストラクタ
        /// <summary>
        /// <see cref="CalcStateManage"/>クラスの新しいインスタンスを初期化する。
        /// </summary>
        /// <param name="form">メイン画面のフォーム</param>
        internal CalculableState(MainForm mainForm)
        {
            form = mainForm;
        }
        #endregion  // コンストラクタ

        #region フィールド
        /// <summary>
        /// メインフォームクラスインスタンス
        /// </summary>
        MainForm form = null;
        #endregion  // フィールド

        #region 公開メソッド
        /// <summary>
        /// 数字が入力された。
        /// </summary>
        /// <param name="num">入力された数字</param>
        public StateIF InputNumberEvent(string num)
        {
            form.AppendResultArea(num);
            return this;
        }

        /// <summary>
        /// 計算符号が入力された。
        /// </summary>
        /// <param name="operation">入力された計算符号</param>
        public StateIF InputCalcOperationEvent(string operation)
        {
            form.AppendFormulaDisplayAreaFromResultArea();
            form.Calculate();
            form.AppendFormulaDisplayArea(operation);
            form.SetCalcOperationFromText(operation);
            return new WaitNumInputAfterOperationState(form);
        }

        /// <summary>
        /// ＝ボタンが入力された
        /// </summary>
        public StateIF InputCalculateEvent()
        {
            form.ClearFormulaArea();
            form.Calculate();
            return new InitialState(form);
        }

        /// <summary>
        /// Cボタンが入力された
        /// </summary>
        public StateIF InputCButtonEvent()
        {
            form.ResetAll();
            return new InitialState(form);
        }

        /// <summary>
        /// CEボタンが入力された
        /// </summary>
        public StateIF InputCEButtonEvent()
        {
            form.ClearResultArea();
            return new WaitNumInputAfterOperationState(form);
        }

        /// <summary>
        /// ←ボタンが入力された
        /// </summary>
        public StateIF InputBackSpaceEvent()
        {
            if (form.getLengthResultArea() <= 1) {
                form.ClearResultArea();
                return new WaitNumInputAfterOperationState(form);
            }
            form.DeleteLastChar();
            return this;
        }

        /// <summary>
        /// 正負切り替えボタンが入力された
        /// </summary>
        public StateIF InputSignToggleEvent()
        {
            form.TogglePositiveAndNegative();
            return this;
        }

        /// <summary>
        /// 小数点"."ボタンが入力された
        /// </summary>
        public StateIF InputDecimalPointEvent()
        {
            if (!form.IsContainDecimalPoint()) {
                form.AppendResultArea(".");
            }
            return this;
        }
        #endregion  // 公開メソッド
    }
    #endregion  // 計算可能状態クラス
}
