using CalcApplication;

namespace CalcState
{
    #region 計算機状態管理クラス
    internal class CalcStateManage
    {
        #region コンストラクタ
        /// <summary>
        /// <see cref="CalcStateManage"/>クラスの新しいインスタンスを初期化する。
        /// </summary>
        /// <param name="form"></param>
        internal CalcStateManage(MainForm form)
        {
            // 状態の初期値を設定しておく
            if (state == null)
            {
                state = new InitialState(form);
            }
        }
        #endregion  // コンストラクタ

        #region フィールド
        /// <summary>
        /// 状態
        /// </summary>
        private StateInterFace state = null;
        #endregion  // フィールド

        #region 公開メソッド

        /// <summary>
        /// 数字が入力された。
        /// </summary>
        /// <param name="num">入力された数字</param>
        internal void InputNumber(string num)
        {
            this.state = this.state.InputNumberEvent(num);
        }

        /// <summary>
        /// 計算符号が入力された。
        /// </summary>
        internal void InputCalcOperation(string operation)
        {
            this.state = this.state.InputCalcOperationEvent(operation);
        }

        /// <summary>
        /// ＝ボタンが入力された
        /// </summary>
        internal void InputCalculate()
        {
            this.state = this.state.InputCalculateEvent();
        }

        /// <summary>
        /// Cボタンが入力された
        /// </summary>
        internal void InputCButton()
        {
            this.state = this.state.InputCButtonEvent();
        }

        /// <summary>
        /// CEボタンが入力された
        /// </summary>
        internal void InputCEButton()
        {
            this.state = this.state.InputCEButtonEvent();
        }

        /// <summary>
        /// ←ボタンが入力された
        /// </summary>
        internal void InputBackSpace()
        {
            this.state = this.state.InputBackSpaceEvent();
        }

        /// <summary>
        /// 正負切り替えボタンが入力された
        /// </summary>
        internal void InputSignToggle()
        {
            this.state = this.state.InputSignToggleEvent();
        }

        /// <summary>
        /// 小数点"."ボタンが入力された
        /// </summary>
        internal void InputDecimalPoint()
        {
            this.state = this.state.InputDecimalPointEvent();
        }
        #endregion  // 公開メソッド
    }
    #endregion  // 計算機状態管理クラス
}
