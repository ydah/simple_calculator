using CalcApplication;

namespace CalcState
{
    public class DoCalcState : StateInterFace
    {
        MainForm form = null;
        internal DoCalcState(MainForm mainForm)
        {
            form = mainForm;
        }

        public StateInterFace InputNumberEvent(string num)
        {
            form.AppendResultArea(num);
            return this;
        }
        public StateInterFace InputCalcOperationEvent(string operation)
        {
            form.AppendFormulaDisplayAreaFromResultArea();
            form.Calculate();
            form.AppendFormulaDisplayArea(operation);
            form.SetCalcOperationFromText(operation);
            return new WaitNumInputAfterOperationState(form);
        }
        public StateInterFace InputCalculateEvent()
        {
            form.ClearFormulaArea();
            form.Calculate();
            return new InitialState(form);
        }
        public StateInterFace InputCButtonEvent()
        {
            form.ResetAll();
            return new InitialState(form);
        }
        public StateInterFace InputCEButtonEvent()
        {
            form.ClearResultArea();
            return new WaitNumInputAfterOperationState(form);
        }
        public StateInterFace InputBackSpaceEvent()
        {
            if (form.getLengthResultArea() <= 1) {
                form.ClearResultArea();
                return new WaitNumInputAfterOperationState(form);
            }
            form.DeleteLastChar();
            return this;
        }
        public StateInterFace InputSignToggleEvent()
        {
            form.TogglePositiveAndNegative();
            return this;
        }
        public StateInterFace InputDecimalPointEvent()
        {
            if (!form.IsContainDecimalPoint()) {
                form.AppendResultArea(".");
            }
            return this;
        }
    }
}
