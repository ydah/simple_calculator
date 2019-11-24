namespace CalcState
{
    /// <summary>
    /// 電卓の状態を表すクラス(インターフェース)
    /// </summary>
    public interface StateInterFace
    {
        /// <summary>
        /// 数字が入力された。
        /// </summary>
        /// <param name="num">入力された数字</param>
        /// <returns>状態</returns>
        StateInterFace InputNumberEvent(string num);

        /// <summary>
        /// 計算符号が入力された
        /// </summary>
        /// <param name="operation">入力された符号</param>
        /// <returns>状態</returns>
        StateInterFace InputCalcOperationEvent(string operation);

        /// <summary>
        /// ＝ボタンが入力された
        /// </summary>
        /// <returns>状態</returns>
        StateInterFace InputCalculateEvent();

        /// <summary>
        /// Cボタンが入力された
        /// </summary>
        /// <returns>状態</returns>
        StateInterFace InputCButtonEvent();

        /// <summary>
        /// CEボタンが入力された
        /// </summary>
        /// <returns>状態</returns>
        StateInterFace InputCEButtonEvent();

        /// <summary>
        /// ←ボタンが入力された
        /// </summary>
        /// <returns>状態</returns>
        StateInterFace InputBackSpaceEvent();

        /// <summary>
        /// 正負切り替えボタンが入力された
        /// </summary>
        /// <returns>状態</returns>
        StateInterFace InputSignToggleEvent();

        /// <summary>
        /// 小数点"."ボタンが入力された
        /// </summary>
        /// <returns>状態</returns>
        StateInterFace InputDecimalPointEvent();
    }
}
