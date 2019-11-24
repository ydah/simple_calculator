using CalcApplication;

namespace CalcState
{
    #region 符号入力後、数値入力待ち状態クラス
    /// <summary>
    /// 符号入力後、数値入力待ち状態クラス
    /// </summary>
    public class WaitNumInputAfterOperationState : StateInterFace
    {
        #region コンストラクタ
        /// <summary>
        /// <see cref="CalcStateManage"/>クラスの新しいインスタンスを初期化する。
        /// </summary>
        /// <param name="form">メイン画面のフォーム</param>
        internal WaitNumInputAfterOperationState(MainForm mainForm)
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
            form.UpdateResultArea(num);
            return new DoCalcState(form);
        }
        /// <summary>
        /// 計算符号が入力された。
        /// </summary>
        /// <param name="operation">入力された計算符号</param>
        public StateInterFace InputCalcOperationEvent(string operation)
        {
            form.ChangeOperation(operation);
            return this;
        }

        /// <summary>
        /// ＝ボタンが入力された
        /// </summary>
        public StateInterFace InputCalculateEvent()
        {
            form.ClearFormulaArea();
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
            form.ClearResultArea();
            return this;
        }

        /// <summary>
        /// ←ボタンが入力された
        /// </summary>
        public StateInterFace InputBackSpaceEvent()
        {
            return this;
        }

        /// <summary>
        /// 正負切り替えボタンが入力された
        /// </summary>
        public StateInterFace InputSignToggleEvent()
        {
            return this;
        }

        /// <summary>
        /// 小数点"."ボタンが入力された
        /// </summary>
        public StateInterFace InputDecimalPointEvent()
        {
            form.ClearResultArea();
            form.AppendResultArea(".");
            return new DoCalcState(form);
        }
        #endregion  // 公開メソッド
    }
    #endregion  // 符号入力後、数値入力待ち状態クラス
}
