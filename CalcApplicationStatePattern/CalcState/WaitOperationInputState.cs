using CalcApplication;

namespace CalcState
{
    public class WaitOperationInputState : StateInterFace
    {
        MainForm form = null;
        internal WaitOperationInputState(MainForm mainForm)
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
            form.AppendFormulaDisplayArea(operation);
            form.SetCalcOperationFromText(operation);
            form.UpdateCalcResult();
            return new WaitNumInputAfterOperationState(form);
        }
        public StateInterFace InputCalculateEvent()
        {
            return new InitialState(form);
        }
        public StateInterFace InputCButtonEvent()
        {
            form.ResetAll();
            return new InitialState(form);
        }
        public StateInterFace InputCEButtonEvent()
        {
            form.ResetAll();
            return new InitialState(form);
        }
        public StateInterFace InputBackSpaceEvent()
        {
            if (form.getLengthResultArea() <= 1) {
                form.ResetAll();
                return new InitialState(form);
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
