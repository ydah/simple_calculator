using CalcApplication;

namespace CalcState
{
    public class WaitNumInputAfterOperationState : StateInterFace
    {
        MainForm form = null;
        internal WaitNumInputAfterOperationState(MainForm mainForm)
        {
            form = mainForm;
        }

        public StateInterFace InputNumberEvent(string num)
        {
            form.UpdateResultArea(num);
            return new DoCalcState(form);
        }
        public StateInterFace InputCalcOperationEvent(string operation)
        {
            form.ChangeOperation(operation);
            return this;
        }
        public StateInterFace InputCalculateEvent()
        {
            form.ClearFormulaArea();
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
            return this;
        }
        public StateInterFace InputBackSpaceEvent()
        {
            return this;
        }
        public StateInterFace InputSignToggleEvent()
        {
            return this;
        }
        public StateInterFace InputDecimalPointEvent()
        {
            form.ClearResultArea();
            form.AppendResultArea(".");
            return new DoCalcState(form);
        }
    }
}
