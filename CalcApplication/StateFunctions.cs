using CalcApplication;
using Defines;

namespace CalcState
{
    #region 計算可能状態クラス

    /// <summary>
    /// 計算可能状態クラス
    /// </summary>
    public class StateFunctions
    {
        #region コンストラクタ

        /// <summary>
        /// <see cref="StateFunctions"/>クラスの新しいインスタンスを初期化する。
        /// </summary>
        /// <param name="form">メイン画面のフォーム</param>
        internal StateFunctions(MainForm mainForm)
        {
            form = mainForm;
        }

        #endregion コンストラクタ

        #region フィールド

        /// <summary>
        /// メインフォームクラスインスタンス
        /// </summary>
        private MainForm form = null;

        /// <summary>
        /// 状態
        /// </summary>
        private ConstDefines.CalcState state = ConstDefines.CalcState.Initaial;

        #endregion フィールド

        #region 公開メソッド

        /// <summary>
        /// 状態を取得する。
        /// </summary>
        /// <returns>現在の状態</returns>
        internal ConstDefines.CalcState GetCalcState()
        {
            return this.state;
        }

        /// <summary>
        /// 状態を設定する。
        /// </summary>
        /// <param name="state">設定する状態</param>
        internal void SetCalcState(ConstDefines.CalcState state)
        {
            this.state = state;
        }

        /// <summary>
        /// 数字が入力された。(初期状態クラス)
        /// </summary>
        /// <param name="num">入力された数字</param>
        public void InputNumberEventInitialState(string num)
        {
            form.ResetAll();
            if (num == ConstDefines.InitCalcResultDisp)
            {
                return;
            }

            form.UpdateResultArea(num);
            SetCalcState(ConstDefines.CalcState.WaitOperation);
        }

        /// <summary>
        /// 計算符号が入力された。(初期状態クラス)
        /// </summary>
        /// <param name="operation">入力された計算符号</param>
        public void InputCalcOperationEventInitialState(string operation)
        {
            form.ResetAll();
            form.AppendFormulaDisplayArea(Defines.ConstDefines.InitCalcResultDisp + operation);
            form.SetCalcOperationFromText(operation);
            SetCalcState(ConstDefines.CalcState.WaitNumInputAfterOperation);
        }

        /// <summary>
        /// ＝ボタンが入力された。(初期状態クラス)
        /// </summary>
        public void InputCalculateEventInitialState()
        {
            form.ResetAll();
        }

        /// <summary>
        /// Cボタンが入力された。(初期状態クラス)
        /// </summary>
        public void InputCButtonEventInitialState()
        {
            form.ResetAll();
        }

        /// <summary>
        /// CEボタンが入力された。(初期状態クラス)
        /// </summary>
        public void InputCEButtonEventInitialState()
        {
            form.ResetAll();
        }

        /// <summary>
        /// ←ボタンが入力された。(初期状態クラス)
        /// </summary>
        public void InputBackSpaceEventInitialState()
        {
            // NOP
        }

        /// <summary>
        /// 正負切り替えボタンが入力された。(初期状態クラス)
        /// </summary>
        public void InputSignToggleEventInitialState()
        {
            if (form.IsInitialValueResultArea())
            {
                return;
            }

            form.TogglePositiveAndNegative();
            SetCalcState(ConstDefines.CalcState.WaitOperation);
        }

        /// <summary>
        /// 小数点"."ボタンが入力された。(初期状態クラス)
        /// </summary>
        public void InputDecimalPointEventInitialState()
        {
            form.ClearResultArea();
            form.AppendResultArea(ConstDefines.DecimalPoint);
            SetCalcState(ConstDefines.CalcState.WaitOperation);
        }

        /// <summary>
        /// 数字が入力された。(符号入力待ち状態)
        /// </summary>
        /// <param name="num">入力された数字</param>
        public void InputNumberEventWaitOperationInputState(string num)
        {
            form.AppendResultArea(num);
        }

        /// <summary>
        /// 計算符号が入力された。(符号入力待ち状態)
        /// </summary>
        /// <param name="operation">入力された計算符号</param>
        public void InputCalcOperationEventWaitOperationInputState(string operation)
        {
            form.AppendFormulaDisplayAreaFromResultArea();
            form.AppendFormulaDisplayArea(operation);
            form.SetCalcOperationFromText(operation);
            form.UpdateCalcResult();
            SetCalcState(ConstDefines.CalcState.WaitNumInputAfterOperation);
        }

        /// <summary>
        /// ＝ボタンが入力された。(符号入力待ち状態)
        /// </summary>
        public void InputCalculateEventWaitOperationInputState()
        {
            SetCalcState(ConstDefines.CalcState.Initaial);
        }

        /// <summary>
        /// Cボタンが入力された。(符号入力待ち状態)
        /// </summary>
        public void InputCButtonEventWaitOperationInputState()
        {
            form.ResetAll();
            SetCalcState(ConstDefines.CalcState.Initaial);
        }

        /// <summary>
        /// CEボタンが入力された。(符号入力待ち状態)
        /// </summary>
        public void InputCEButtonEventWaitOperationInputState()
        {
            form.ResetAll();
            SetCalcState(ConstDefines.CalcState.Initaial);
        }

        /// <summary>
        /// ←ボタンが入力された。(符号入力待ち状態)
        /// </summary>
        public void InputBackSpaceEventWaitOperationInputState()
        {
            if (form.getLengthResultArea() <= 1)
            {
                form.ResetAll();
                SetCalcState(ConstDefines.CalcState.Initaial);
                return;
            }
            form.DeleteLastChar();
        }

        /// <summary>
        /// 正負切り替えボタンが入力された。(符号入力待ち状態)
        /// </summary>
        public void InputSignToggleEventWaitOperationInputState()
        {
            form.TogglePositiveAndNegative();
        }

        /// <summary>
        /// 小数点"."ボタンが入力された。(符号入力待ち状態)
        /// </summary>
        public void InputDecimalPointEventWaitOperationInputState()
        {
            if (!form.IsContainDecimalPoint())
            {
                form.AppendResultArea(ConstDefines.DecimalPoint);
            }
        }

        /// <summary>
        /// 数字が入力された。(符号入力後、数値入力待ち状態)
        /// </summary>
        /// <param name="num">入力された数字</param>
        public void InputNumberEventWaitNumInputAfterOperationState(string num)
        {
            form.ClearResultArea();
            if (form.IsInitialValueResultArea() && (num == ConstDefines.InitCalcResultDisp))
            {
                return;
            }
            form.UpdateResultArea(num);
            SetCalcState(ConstDefines.CalcState.Calulable);
        }

        /// <summary>
        /// 計算符号が入力された。(符号入力後、数値入力待ち状態)
        /// </summary>
        /// <param name="operation">入力された計算符号</param>
        public void InputCalcOperationEventWaitNumInputAfterOperationState(string operation)
        {
            form.ChangeOperation(operation);
        }

        /// <summary>
        /// ＝ボタンが入力された。(符号入力後、数値入力待ち状態)
        /// </summary>
        public void InputCalculateEventWaitNumInputAfterOperationState()
        {
            form.ClearFormulaArea();
            SetCalcState(ConstDefines.CalcState.Initaial);
        }

        /// <summary>
        /// Cボタンが入力された。(符号入力後、数値入力待ち状態)
        /// </summary>
        public void InputCButtonEventWaitNumInputAfterOperationState()
        {
            form.ResetAll();
            SetCalcState(ConstDefines.CalcState.Initaial);
        }

        /// <summary>
        /// CEボタンが入力された。(符号入力後、数値入力待ち状態)
        /// </summary>
        public void InputCEButtonEventWaitNumInputAfterOperationState()
        {
            form.ClearResultArea();
        }

        /// <summary>
        /// ←ボタンが入力された。(符号入力後、数値入力待ち状態)
        /// </summary>
        public void InputBackSpaceEventWaitNumInputAfterOperationState()
        {
            // NOP
        }

        /// <summary>
        /// 正負切り替えボタンが入力された。(符号入力後、数値入力待ち状態)
        /// </summary>
        public void InputSignToggleEventWaitNumInputAfterOperationState()
        {
            // NOP
        }

        /// <summary>
        /// 小数点"."ボタンが入力された。(符号入力後、数値入力待ち状態)
        /// </summary>
        public void InputDecimalPointEventWaitNumInputAfterOperationState()
        {
            form.ClearResultArea();
            form.AppendResultArea(ConstDefines.DecimalPoint);
            SetCalcState(ConstDefines.CalcState.Calulable);
        }

        /// <summary>
        /// 数字が入力された。(計算可能状態)
        /// </summary>
        /// <param name="num">入力された数字</param>
        public void InputNumberEventCalculableState(string num)
        {
            form.AppendResultArea(num);
        }

        /// <summary>
        /// 計算符号が入力された。(計算可能状態)
        /// </summary>
        /// <param name="operation">入力された計算符号</param>
        public void InputCalcOperationEventCalculableState(string operation)
        {
            form.AppendFormulaDisplayAreaFromResultArea();
            if (!form.Calculate())
            {
                SetCalcState(ConstDefines.CalcState.Initaial);
                return;
            }
            form.AppendFormulaDisplayArea(operation);
            form.SetCalcOperationFromText(operation);
            SetCalcState(ConstDefines.CalcState.WaitNumInputAfterOperation);
        }

        /// <summary>
        /// ＝ボタンが入力された。(計算可能状態)
        /// </summary>
        public void InputCalculateEventCalculableState()
        {
            form.ClearFormulaArea();
            if (!form.Calculate())
            {
                SetCalcState(ConstDefines.CalcState.Initaial);
                return;
            }
            SetCalcState(ConstDefines.CalcState.Initaial);
        }

        /// <summary>
        /// Cボタンが入力された。(計算可能状態)
        /// </summary>
        public void InputCButtonEventCalculableState()
        {
            form.ResetAll();
            SetCalcState(ConstDefines.CalcState.Initaial);
        }

        /// <summary>
        /// CEボタンが入力された。(計算可能状態)
        /// </summary>
        public void InputCEButtonEventCalculableState()
        {
            form.ClearResultArea();
            SetCalcState(ConstDefines.CalcState.WaitNumInputAfterOperation);
        }

        /// <summary>
        /// ←ボタンが入力された。(計算可能状態)
        /// </summary>
        public void InputBackSpaceEventCalculableState()
        {
            if (form.getLengthResultArea() <= 1)
            {
                form.ClearResultArea();
                SetCalcState(ConstDefines.CalcState.WaitNumInputAfterOperation);
                return;
            }
            form.DeleteLastChar();
        }

        /// <summary>
        /// 正負切り替えボタンが入力された。(計算可能状態)
        /// </summary>
        public void InputSignToggleEventCalculableState()
        {
            form.TogglePositiveAndNegative();
        }

        /// <summary>
        /// 小数点"."ボタンが入力された。(計算可能状態)
        /// </summary>
        public void InputDecimalPointEventCalculableState()
        {
            if (!form.IsContainDecimalPoint())
            {
                form.AppendResultArea(ConstDefines.DecimalPoint);
            }
        }

        #endregion 公開メソッド
    }

    #endregion 計算可能状態クラス
}