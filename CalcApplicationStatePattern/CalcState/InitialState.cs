using CalcApplication;

namespace CalcState
{
    #region 初期状態クラス
    /// <summary>
    /// 初期状態クラス
    /// </summary>
    public class InitialState : StateIF
    {
        #region コンストラクタ
        /// <summary>
        /// <see cref="CalcStateManage"/>クラスの新しいインスタンスを初期化する。
        /// </summary>
        /// <param name="form">メイン画面のフォーム</param>
        internal InitialState(MainForm mainForm)
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
            form.ResetAll();
            form.UpdateResultArea(num);
            return new WaitOperationInputState(form);
        }

        /// <summary>
        /// 計算符号が入力された。
        /// </summary>
        /// <param name="operation">入力された計算符号</param>
        public StateIF InputCalcOperationEvent(string operation)
        {
            form.ResetAll();
            form.AppendFormulaDisplayArea(Defines.ConstDefines.InitCalcResultDisp+ operation);
            return new WaitNumInputAfterOperationState(form);
        }

        /// <summary>
        /// ＝ボタンが入力された
        /// </summary>
        public StateIF InputCalculateEvent()
        {
            form.ResetAll();
            return this;
        }

        /// <summary>
        /// Cボタンが入力された
        /// </summary>
        public StateIF InputCButtonEvent()
        {
            form.ResetAll();
            return this;
        }

        /// <summary>
        /// CEボタンが入力された
        /// </summary>
        public StateIF InputCEButtonEvent()
        {
            form.ResetAll();
            return this;
        }

        /// <summary>
        /// ←ボタンが入力された
        /// </summary>
        public StateIF InputBackSpaceEvent()
        {
            return this;
        }

        /// <summary>
        /// 正負切り替えボタンが入力された
        /// </summary>
        public StateIF InputSignToggleEvent()
        {
            if (form.IsInitialValueResultArea()) {
                return this;
            }

            form.TogglePositiveAndNegative();
            return new WaitOperationInputState(form);
        }

        /// <summary>
        /// 小数点"."ボタンが入力された
        /// </summary>
        public StateIF InputDecimalPointEvent()
        {
            form.ClearResultArea();
            form.AppendResultArea(".");
            return new WaitOperationInputState(form);
        }
        #endregion  // 公開メソッド
    }
    #endregion  // 初期状態クラス
}
