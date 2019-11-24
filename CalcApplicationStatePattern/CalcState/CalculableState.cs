using CalcApplication;

namespace CalcState
{
    public class CalculableState : StateIF
    {
        MainForm form = null;
        internal CalculableState(MainForm mainForm)
        {
            form = mainForm;
        }

        public StateIF InputNumberEvent(string num)
        {
            form.AppendResultArea(num);
            return this;
        }
        public StateIF InputCalcOperationEvent(string operation)
        {
            form.AppendFormulaDisplayAreaFromResultArea();
            form.Calculate();
            form.AppendFormulaDisplayArea(operation);
            form.SetCalcOperationFromText(operation);
            return new WaitNumInputAfterOperationState(form);
        }
        public StateIF InputCalculateEvent()
        {
            form.ClearFormulaArea();
            form.Calculate();
            return new InitialState(form);
        }
        public StateIF InputCButtonEvent()
        {
            form.ResetAll();
            return new InitialState(form);
        }
        public StateIF InputCEButtonEvent()
        {
            form.ClearResultArea();
            return new WaitNumInputAfterOperationState(form);
        }
        public StateIF InputBackSpaceEvent()
        {
            if (form.getLengthResultArea() <= 1) {
                form.ClearResultArea();
                return new WaitNumInputAfterOperationState(form);
            }
            form.DeleteLastChar();
            return this;
        }
        public StateIF InputSignToggleEvent()
        {
            form.TogglePositiveAndNegative();
            return this;
        }
        public StateIF InputDecimalPointEvent()
        {
            if (!form.IsContainDecimalPoint()) {
                form.AppendResultArea(".");
            }
            return this;
        }
    }
}
