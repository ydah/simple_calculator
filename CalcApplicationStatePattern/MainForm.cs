﻿using System;
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
    public partial class MainForm : Form
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

        public MainForm()
        {
            InitializeComponent();
        }

        private void MainFrom_Load(object sender, EventArgs e)
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
        private void SignToggleButton_Click(object sender, EventArgs e)
        {
            double currentValue = Convert.ToDouble(resultDispArea.Text);
            currentValue *= -1;
            resultDispArea.Text = currentValue.ToString();

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

            if (resultDispArea.Text.Length > resultDispArea.MaxLength)
            {
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

            if (calcResult.ToString().Length > resultDispArea.MaxLength)
            {
                resultDispArea.Text = calcResult.ToString().Remove(calcResult.ToString().Length - (calcResult.ToString().Length - resultDispArea.MaxLength));
                formulaDispArea.Text = "Over Flow";
                calcResult = 0;
                isBeforeCalc = true;
                return;
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

        private void MainForm_KeyDown(object sender, KeyEventArgs e)
        {
            if ((e.KeyCode < Keys.D0) || (e.KeyCode > Keys.D9))
            {
                return;
            }

            string downKey = (e.KeyCode - Keys.D0).ToString();
            if ((downKey == "0") && (resultDispArea.Text.Length == 0))
            {
                return;
            }

            AppendResultDispArea(downKey);
        }
    }
}
