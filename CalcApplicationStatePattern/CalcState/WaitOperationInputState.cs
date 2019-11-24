using CalcApplication;

namespace CalcState
{
    #region 符号入力待ち状態クラス
    /// <summary>
    /// 符号入力待ち状態クラス
    /// </summary>
    public class WaitOperationInputState : StateInterFace
    {
        #region コンストラクタ
        /// <summary>
        /// <see cref="CalcStateManage"/>クラスの新しいインスタンスを初期化する。
        /// </summary>
        /// <param name="form">メイン画面のフォーム</param>
        internal WaitOperationInputState(MainForm mainForm)
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
        public StateInterFace InputNumberEvent(string num)
        {
            form.AppendResultArea(num);
            return this;
        }

        /// <summary>
        /// 計算符号が入力された。
        /// </summary>
        /// <param name="operation">入力された計算符号</param>
        public StateInterFace InputCalcOperationEvent(string operation)
        {
            form.AppendFormulaDisplayAreaFromResultArea();
            form.AppendFormulaDisplayArea(operation);
            form.SetCalcOperationFromText(operation);
            form.UpdateCalcResult();
            return new WaitNumInputAfterOperationState(form);
        }

        /// <summary>
        /// ＝ボタンが入力された
        /// </summary>
        public StateInterFace InputCalculateEvent()
        {
            return new InitialState(form);
        }

        /// <summary>
        /// Cボタンが入力された
        /// </summary>
        public StateInterFace InputCButtonEvent()
        {
            form.ResetAll();
            return new InitialState(form);
        }

        /// <summary>
        /// CEボタンが入力された
        /// </summary>
        public StateInterFace InputCEButtonEvent()
        {
            form.ResetAll();
            return new InitialState(form);
        }

        /// <summary>
        /// ←ボタンが入力された
        /// </summary>
        public StateInterFace InputBackSpaceEvent()
        {
            if (form.getLengthResultArea() <= 1) {
                form.ResetAll();
                return new InitialState(form);
            }
            form.DeleteLastChar();
            return this;
        }

        /// <summary>
        /// 正負切り替えボタンが入力された
        /// </summary>
        public StateInterFace InputSignToggleEvent()
        {
            form.TogglePositiveAndNegative();
            return this;
        }

        /// <summary>
        /// 小数点"."ボタンが入力された
        /// </summary>
        public StateInterFace InputDecimalPointEvent()
        {
            if (!form.IsContainDecimalPoint()) {
                form.AppendResultArea(".");
            }
            return this;
        }
        #endregion  // 公開メソッド
    }
    #endregion  // 符号入力待ち状態クラス
}
