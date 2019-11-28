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
        internal ConstDefines.CalcState GetState()
        {
            return this.state;
        }

        /// <summary>
        /// 状態を設定する。
        /// </summary>
        /// <param name="state">設定する状態</param>
        internal void SetState(ConstDefines.CalcState state)
        {
            this.state = state;
        }

        /// <summary>
        /// 数字が入力された。(初期状態クラス)
        /// </summary>
        /// <param name="num">入力された数字</param>
        public void InputNumberInitialState(string num)
        {
            form.ResetAll();
            if (num == ConstDefines.InitCalcResultDisp)
            {
                return;
            }

            form.UpdateResultArea(num);
            SetState(ConstDefines.CalcState.WaitOperation);
        }

        /// <summary>
        /// 計算符号が入力された。(初期状態クラス)
        /// </summary>
        /// <param name="operation">入力された計算符号</param>
        public void InputCalcOperationInitialState(string operation)
        {
            form.ResetAll();
            form.AppendFormulaDisplayArea(Defines.ConstDefines.InitCalcResultDisp + operation);
            form.SetCalcOperationFromText(operation);
            SetState(ConstDefines.CalcState.WaitNumInputAfterOperation);
        }

        /// <summary>
        /// ＝ボタンが入力された。(初期状態クラス)
        /// </summary>
        public void InputCalculateInitialState()
        {
            form.ResetAll();
        }

        /// <summary>
        /// Cボタンが入力された。(初期状態クラス)
        /// </summary>
        public void InputCButtonInitialState()
        {
            form.ResetAll();
        }

        /// <summary>
        /// CEボタンが入力された。(初期状態クラス)
        /// </summary>
        public void InputCEButtonInitialState()
        {
            form.ResetAll();
        }

        /// <summary>
        /// ←ボタンが入力された。(初期状態クラス)
        /// </summary>
        public void InputBackSpaceInitialState()
        {
            // NOP
        }

        /// <summary>
        /// 正負切り替えボタンが入力された。(初期状態クラス)
        /// </summary>
        public void InputSignToggleInitialState()
        {
            if (form.IsInitialValueResultArea())
            {
                return;
            }

            form.TogglePositiveAndNegative();
            SetState(ConstDefines.CalcState.WaitOperation);
        }

        /// <summary>
        /// 小数点"."ボタンが入力された。(初期状態クラス)
        /// </summary>
        public void InputDecimalPointInitialState()
        {
            form.ClearResultArea();
            form.AppendResultArea(ConstDefines.DecimalPoint);
            SetState(ConstDefines.CalcState.WaitOperation);
        }

        /// <summary>
        /// 数字が入力された。(符号入力待ち状態)
        /// </summary>
        /// <param name="num">入力された数字</param>
        public void InputNumberWaitOperationInputState(string num)
        {
            form.AppendResultArea(num);
        }

        /// <summary>
        /// 計算符号が入力された。(符号入力待ち状態)
        /// </summary>
        /// <param name="operation">入力された計算符号</param>
        public void InputCalcOperationWaitOperationInputState(string operation)
        {
            form.AppendFormulaDisplayAreaFromResultArea();
            form.AppendFormulaDisplayArea(operation);
            form.SetCalcOperationFromText(operation);
            form.UpdateCalcResult();
            SetState(ConstDefines.CalcState.WaitNumInputAfterOperation);
        }

        /// <summary>
        /// ＝ボタンが入力された。(符号入力待ち状態)
        /// </summary>
        public void InputCalculateWaitOperationInputState()
        {
            SetState(ConstDefines.CalcState.Initaial);
        }

        /// <summary>
        /// Cボタンが入力された。(符号入力待ち状態)
        /// </summary>
        public void InputCButtonWaitOperationInputState()
        {
            form.ResetAll();
            SetState(ConstDefines.CalcState.Initaial);
        }

        /// <summary>
        /// CEボタンが入力された。(符号入力待ち状態)
        /// </summary>
        public void InputCEButtonWaitOperationInputState()
        {
            form.ResetAll();
            SetState(ConstDefines.CalcState.Initaial);
        }

        /// <summary>
        /// ←ボタンが入力された。(符号入力待ち状態)
        /// </summary>
        public void InputBackSpaceWaitOperationInputState()
        {
            if (form.getLengthResultArea() <= 1)
            {
                form.ResetAll();
                SetState(ConstDefines.CalcState.Initaial);
                return;
            }
            form.DeleteLastChar();
        }

        /// <summary>
        /// 正負切り替えボタンが入力された。(符号入力待ち状態)
        /// </summary>
        public void InputSignToggleWaitOperationInputState()
        {
            form.TogglePositiveAndNegative();
        }

        /// <summary>
        /// 小数点"."ボタンが入力された。(符号入力待ち状態)
        /// </summary>
        public void InputDecimalPointWaitOperationInputState()
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
        public void InputNumberWaitNumInputAfterOperationState(string num)
        {
            form.ClearResultArea();
            if (form.IsInitialValueResultArea() && (num == ConstDefines.InitCalcResultDisp))
            {
                return;
            }
            form.UpdateResultArea(num);
            SetState(ConstDefines.CalcState.Calulable);
        }

        /// <summary>
        /// 計算符号が入力された。(符号入力後、数値入力待ち状態)
        /// </summary>
        /// <param name="operation">入力された計算符号</param>
        public void InputCalcOperationWaitNumInputAfterOperationState(string operation)
        {
            form.ChangeOperation(operation);
        }

        /// <summary>
        /// ＝ボタンが入力された。(符号入力後、数値入力待ち状態)
        /// </summary>
        public void InputCalculateWaitNumInputAfterOperationState()
        {
            form.ClearFormulaArea();
            SetState(ConstDefines.CalcState.Initaial);
        }

        /// <summary>
        /// Cボタンが入力された。(符号入力後、数値入力待ち状態)
        /// </summary>
        public void InputCButtonWaitNumInputAfterOperationState()
        {
            form.ResetAll();
            SetState(ConstDefines.CalcState.Initaial);
        }

        /// <summary>
        /// CEボタンが入力された。(符号入力後、数値入力待ち状態)
        /// </summary>
        public void InputCEButtonWaitNumInputAfterOperationState()
        {
            form.ClearResultArea();
        }

        /// <summary>
        /// ←ボタンが入力された。(符号入力後、数値入力待ち状態)
        /// </summary>
        public void InputBackSpaceWaitNumInputAfterOperationState()
        {
            // NOP
        }

        /// <summary>
        /// 正負切り替えボタンが入力された。(符号入力後、数値入力待ち状態)
        /// </summary>
        public void InputSignToggleWaitNumInputAfterOperationState()
        {
            // NOP
        }

        /// <summary>
        /// 小数点"."ボタンが入力された。(符号入力後、数値入力待ち状態)
        /// </summary>
        public void InputDecimalPointWaitNumInputAfterOperationState()
        {
            form.ClearResultArea();
            form.AppendResultArea(ConstDefines.DecimalPoint);
            SetState(ConstDefines.CalcState.Calulable);
        }

        /// <summary>
        /// 数字が入力された。(計算可能状態)
        /// </summary>
        /// <param name="num">入力された数字</param>
        public void InputNumberCalculableState(string num)
        {
            form.AppendResultArea(num);
        }

        /// <summary>
        /// 計算符号が入力された。(計算可能状態)
        /// </summary>
        /// <param name="operation">入力された計算符号</param>
        public void InputCalcOperationCalculableState(string operation)
        {
            form.AppendFormulaDisplayAreaFromResultArea();
            if (!form.Calculate())
            {
                SetState(ConstDefines.CalcState.Initaial);
                return;
            }
            form.AppendFormulaDisplayArea(operation);
            form.SetCalcOperationFromText(operation);
            SetState(ConstDefines.CalcState.WaitNumInputAfterOperation);
        }

        /// <summary>
        /// ＝ボタンが入力された。(計算可能状態)
        /// </summary>
        public void InputCalculateCalculableState()
        {
            form.ClearFormulaArea();
            if (!form.Calculate())
            {
                SetState(ConstDefines.CalcState.Initaial);
                return;
            }
            SetState(ConstDefines.CalcState.Initaial);
        }

        /// <summary>
        /// Cボタンが入力された。(計算可能状態)
        /// </summary>
        public void InputCButtonCalculableState()
        {
            form.ResetAll();
            SetState(ConstDefines.CalcState.Initaial);
        }

        /// <summary>
        /// CEボタンが入力された。(計算可能状態)
        /// </summary>
        public void InputCEButtonCalculableState()
        {
            form.ClearResultArea();
            SetState(ConstDefines.CalcState.WaitNumInputAfterOperation);
        }

        /// <summary>
        /// ←ボタンが入力された。(計算可能状態)
        /// </summary>
        public void InputBackSpaceCalculableState()
        {
            if (form.getLengthResultArea() <= 1)
            {
                form.ClearResultArea();
                SetState(ConstDefines.CalcState.WaitNumInputAfterOperation);
                return;
            }
            form.DeleteLastChar();
        }

        /// <summary>
        /// 正負切り替えボタンが入力された。(計算可能状態)
        /// </summary>
        public void InputSignToggleCalculableState()
        {
            form.TogglePositiveAndNegative();
        }

        /// <summary>
        /// 小数点"."ボタンが入力された。(計算可能状態)
        /// </summary>
        public void InputDecimalPointCalculableState()
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