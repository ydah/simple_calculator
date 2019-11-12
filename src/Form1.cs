using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

internal enum CalcType
{
    Undefined = -1,
    Sum = 0,
    Minus,
    Times,
    Divide
};

namespace simple_calculator
{
    public partial class Form1 : Form
    {
        private double calcResult = 0;
        private CalcType calcSignType = CalcType.Undefined;
        private bool isAppendingMode = false;
        private bool isBeforeCalc = true;
        private static readonly Dictionary<string, CalcType> constCalcTypeTable = new Dictionary<string, CalcType>
        {
            { "＋", CalcType.Sum    },
            { "－", CalcType.Minus  },
            { "×", CalcType.Times  },
            { "÷", CalcType.Divide },
        };

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void NumberButton_Click(object sender, EventArgs e)
        {
            if ((((Button)sender).Text == "0") && (resultDispArea.Text.Length == 0))
            {
                return;
            }

            AppendResultDispArea(((Button)sender).Text);
        }

        private void CalcTypeSign_Click(object sender, EventArgs e)
        {
            SetCalcTypeFromText(((Button)sender).Text);
            AppendFormulaDisplayArea(resultDispArea.Text);
            AppendFormulaDisplayArea(((Button)sender).Text);
            if (isBeforeCalc)
            {
                calcResult = Convert.ToDouble(resultDispArea.Text);
                isAppendingMode = true;
                isBeforeCalc = false;
                return;
            }
            CalcResult();
        }

        private void SumButton_Click(object sender, EventArgs e)
        {
            calcSignType = CalcType.Sum;
            AppendFormulaDisplayArea(resultDispArea.Text);
            AppendFormulaDisplayArea("+");
            if (isBeforeCalc)
            {
                calcResult = Convert.ToDouble(resultDispArea.Text);
                isAppendingMode = true;
                isBeforeCalc = false;
                return;
            }
            CalcResult();
        }

        private void MinButton_Click(object sender, EventArgs e)
        {
            calcSignType = CalcType.Minus;
            AppendFormulaDisplayArea(resultDispArea.Text);
            AppendFormulaDisplayArea("-");
            if (isBeforeCalc)
            {
                calcResult = Convert.ToDouble(resultDispArea.Text);
                isAppendingMode = true;
                isBeforeCalc = false;
                return;
            }
            CalcResult();
        }

        private void MultiButton_Click(object sender, EventArgs e)
        {
            calcSignType = CalcType.Times;
            AppendFormulaDisplayArea(resultDispArea.Text);
            AppendFormulaDisplayArea("*");
            if (isBeforeCalc)
            {
                calcResult = Convert.ToDouble(resultDispArea.Text);
                isAppendingMode = true;
                isBeforeCalc = false;
                return;
            }
            CalcResult();
        }

        private void DivButton_Click(object sender, EventArgs e)
        {
            calcSignType = CalcType.Divide;
            AppendFormulaDisplayArea(resultDispArea.Text);
            AppendFormulaDisplayArea("/");
            if (isBeforeCalc)
            {
                calcResult = Convert.ToDouble(resultDispArea.Text);
                isAppendingMode = true;
                isBeforeCalc = false;
                return;
            }
            CalcResult();
        }

        private void SignToggleButton_Click(object sender, EventArgs e)
        {

        }

        private void DecimalPointButton_Click(object sender, EventArgs e)
        {

        }

        private void CEButton_Click(object sender, EventArgs e)
        {
            resultDispArea.Text = "0";
            formulaDispArea.ResetText();
            calcResult = 0;
            isBeforeCalc = true;
        }

        private void CButton_Click(object sender, EventArgs e)
        {
            resultDispArea.Text = "0";
        }

        private void BackSpaceButton_Click(object sender, EventArgs e)
        {
            if (resultDispArea.Text.Length <= 1)
            {
                resultDispArea.Text = "0";
                return;
            }

            resultDispArea.Text = resultDispArea.Text.Remove(resultDispArea.Text.Length - 1);
        }

        private void ResultDisplayButton_Click(object sender, EventArgs e)
        {
            if (formulaDispArea.Text.Length == 0)
                return;

            AppendFormulaDisplayArea(resultDispArea.Text);
            CalcResult();
            formulaDispArea.ResetText();
            calcResult = 0;
            isBeforeCalc = true;
        }

        private void AppendResultDispArea(string word)
        {
            if (isAppendingMode)
            {
                resultDispArea.Text = word;
                isAppendingMode = false;
                return;
            }

            if ((resultDispArea.Text.Length == 1) && (resultDispArea.Text == "0"))
            {
                resultDispArea.Text = word;
            }
            else
            {
                resultDispArea.AppendText(word);
            }
        }

        private void AppendFormulaDisplayArea(string chars)
        {
            formulaDispArea.AppendText(chars);
        }

        private void CalcResult()
        {
            switch (calcSignType) {
                case CalcType.Sum:
                    calcResult += Convert.ToDouble(resultDispArea.Text);
                    break;
                case CalcType.Minus:
                    calcResult -= Convert.ToDouble(resultDispArea.Text);
                    break;
                case CalcType.Times:
                    calcResult *= Convert.ToDouble(resultDispArea.Text);
                    break;
                case CalcType.Divide:
                    calcResult /= Convert.ToDouble(resultDispArea.Text);
                    break;
                default:
                    resultDispArea.Text = "Fatal";
                    break;
            }
            resultDispArea.Text = calcResult.ToString();
            isAppendingMode = true;
            calcSignType = CalcType.Undefined;
        }

        private void ChangeOperation(string operation)
        {
            if (calcSignType != CalcType.Undefined)
                formulaDispArea.Text = formulaDispArea.Text.Remove(formulaDispArea.Text.Length - 1);

            AppendFormulaDisplayArea(operation);
        }

        private void SetCalcTypeFromText(string text)
        {
            calcSignType = constCalcTypeTable[text];
        }
    }
}
