namespace CalcState
{
    /// <summary>
    /// 電卓の状態を表すクラス(インターフェース)
    /// </summary>
    public interface StateIF
    {
        /// <summary>
        /// 数字が入力された。
        /// </summary>
        /// <param name="num">入力された数字</param>
        /// <returns>状態</returns>
        StateIF InputNumberEvent(string num);

        /// <summary>
        /// 計算符号が入力された
        /// </summary>
        /// <param name="operation">入力された符号</param>
        /// <returns>状態</returns>
        StateIF InputCalcOperationEvent(string operation);

        /// <summary>
        /// ＝ボタンが入力された
        /// </summary>
        /// <returns>状態</returns>
        StateIF InputCalculateEvent();

        /// <summary>
        /// Cボタンが入力された
        /// </summary>
        /// <returns>状態</returns>
        StateIF InputCButtonEvent();

        /// <summary>
        /// CEボタンが入力された
        /// </summary>
        /// <returns>状態</returns>
        StateIF InputCEButtonEvent();

        /// <summary>
        /// ←ボタンが入力された
        /// </summary>
        /// <returns>状態</returns>
        StateIF InputBackSpaceEvent();

        /// <summary>
        /// 正負切り替えボタンが入力された
        /// </summary>
        /// <returns>状態</returns>
        StateIF InputSignToggleEvent();

        /// <summary>
        /// 小数点"."ボタンが入力された
        /// </summary>
        /// <returns>状態</returns>
        StateIF InputDecimalPointEvent();
    }
}
