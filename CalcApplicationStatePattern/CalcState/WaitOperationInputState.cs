using CalcApplication;
using Defines;

namespace CalcState
{
    #region 符号入力待ち状態クラス

    /// <summary>
    /// 符号入力待ち状態クラス
    /// </summary>
    public class WaitOperationInputState : StateIF
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

        #endregion コンストラクタ

        #region フィールド

        /// <summary>
        /// メインフォームクラスインスタンス
        /// </summary>
        private MainForm form = null;

        #endregion フィールド

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
            form.AppendFormulaDisplayArea(operation);
            form.SetCalcOperationFromText(operation);
            form.UpdateCalcResult();
            return new WaitNumInputAfterOperationState(form);
        }

        /// <summary>
        /// ＝ボタンが入力された
        /// </summary>
        public StateIF InputCalculateEvent()
        {
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
            form.ResetAll();
            return new InitialState(form);
        }

        /// <summary>
        /// ←ボタンが入力された
        /// </summary>
        public StateIF InputBackSpaceEvent()
        {
            if ((form.getLengthResultArea() - 1) <= 1)
            {
                form.ResetAll();
                return new InitialState(form);
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
            if (!form.IsContainDecimalPoint())
            {
                form.AppendResultArea(ConstDefines.DecimalPoint);
            }
            return this;
        }

        #endregion 公開メソッド
    }

    #endregion 符号入力待ち状態クラス
}