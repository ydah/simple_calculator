using CalcApplication;

namespace CalcState
{
    /// <summary>
    /// 初期状態クラス
    /// </summary>
    public class InitialState : StateInterFace
    {
        MainForm form = null;
        internal InitialState(MainForm mainForm)
        {
            form = mainForm;
        }

        public StateInterFace InputNumberEvent(string num)
        {
            form.ResetAll();
            form.UpdateResultArea(num);
            return new WaitOperationInputState(form);
        }
        public StateInterFace InputCalcOperationEvent(string operation)
        {
            form.ResetAll();
			form.AppendFormulaDisplayArea(Defines.ConstDefines.InitCalcResultDisp+ operation);
            return new WaitNumInputAfterOperationState(form);
        }
        public StateInterFace InputCalculateEvent()
        {
            form.ResetAll();
            return this;
        }
        public StateInterFace InputCButtonEvent()
        {
            form.ResetAll();
            return this;
        }
        public StateInterFace InputCEButtonEvent()
        {
            form.ResetAll();
            return this;
        }
        public StateInterFace InputBackSpaceEvent()
        {
            return this;
        }
        public StateInterFace InputSignToggleEvent()
        {
            if (form.IsInitialValueResultArea()) {
                return this;
            }

            form.TogglePositiveAndNegative();
            return new WaitOperationInputState(form);
        }
        public StateInterFace InputDecimalPointEvent()
        {
            form.ClearResultArea();
            form.AppendResultArea(".");
            return new WaitOperationInputState(form);
        }
    }
}
