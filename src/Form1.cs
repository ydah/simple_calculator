using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

enum CalcType
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
        private Int64 calc_res = 0;
        private CalcType calc_type = CalcType.Undefined;
        private bool isnext = false;
        private bool isfirst = true;


        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            appendResultDispArea("1");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            appendResultDispArea("2");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            appendResultDispArea("3");
        }

        private void button4_Click(object sender, EventArgs e)
        {
            appendResultDispArea("4");
        }

        private void button5_Click(object sender, EventArgs e)
        {
            appendResultDispArea("5");
        }

        private void button6_Click(object sender, EventArgs e)
        {
            appendResultDispArea("6");
        }

        private void button7_Click(object sender, EventArgs e)
        {
            appendResultDispArea("7");
        }

        private void button8_Click(object sender, EventArgs e)
        {
            appendResultDispArea("8");
        }

        private void button9_Click(object sender, EventArgs e)
        {
            appendResultDispArea("9");
        }

        private void button0_Click(object sender, EventArgs e)
        {
            if (resultDispArea.Text.Length == 0)
                return;

            appendResultDispArea("0");
        }

        private void sumButton_Click(object sender, EventArgs e)
        {
            calc_type = CalcType.Sum;
            appendFormulaDisplayArea(resultDispArea.Text);
            appendFormulaDisplayArea("+");
            if (isfirst)
            {
                calc_res = Convert.ToInt64(resultDispArea.Text);
                isnext = true;
                isfirst = false;
                return;
            }
            calcResult();
        }

        private void minButton_Click(object sender, EventArgs e)
        {
            calc_type = CalcType.Minus;
            appendFormulaDisplayArea(resultDispArea.Text);
            appendFormulaDisplayArea("-");
            if (isfirst)
            {
                calc_res = Convert.ToInt64(resultDispArea.Text);
                isnext = true;
                isfirst = false;
                return;
            }
            calcResult();
        }

        private void multiButton_Click(object sender, EventArgs e)
        {
            calc_type = CalcType.Times;
            appendFormulaDisplayArea(resultDispArea.Text);
            appendFormulaDisplayArea("*");
            if (isfirst)
            {
                calc_res = Convert.ToInt64(resultDispArea.Text);
                isnext = true;
                isfirst = false;
                return;
            }
            calcResult();
        }

        private void divButton_Click(object sender, EventArgs e)
        {
            calc_type = CalcType.Divide;
            appendFormulaDisplayArea(resultDispArea.Text);
            appendFormulaDisplayArea("/");
            if (isfirst)
            {
                calc_res = Convert.ToInt64(resultDispArea.Text);
                isnext = true;
                isfirst = false;
                return;
            }
            calcResult();
        }

        private void signToggleButton_Click(object sender, EventArgs e)
        {

        }

        private void decimalPointButton_Click(object sender, EventArgs e)
        {

        }

        private void CEButton_Click(object sender, EventArgs e)
        {
            resultDispArea.Text = "0";
            formulaDispArea.ResetText();
            calc_res = 0;
            isfirst = true;
        }

        private void CButton_Click(object sender, EventArgs e)
        {
            resultDispArea.Text = "0";
        }

        private void backSpaceButton_Click(object sender, EventArgs e)
        {
            if (resultDispArea.Text.Length <= 1)
            {
                resultDispArea.Text = "0";
                return;
            }

            resultDispArea.Text = resultDispArea.Text.Remove(resultDispArea.Text.Length - 1);
        }

        private void resultDisplayButton_Click(object sender, EventArgs e)
        {
            if (formulaDispArea.Text.Length == 0)
                return;

            appendFormulaDisplayArea(resultDispArea.Text);
            calcResult();
            formulaDispArea.ResetText();
            calc_res = 0;
            isfirst = true;
        }

        private void appendResultDispArea(string str)
        {
            if (isnext)
            {
                resultDispArea.Text = str;
                isnext = false;
                return;
            }

            if ((resultDispArea.Text.Length == 1) && (resultDispArea.Text == "0"))
            {
                resultDispArea.Text = str;
            }
            else
            {
                resultDispArea.AppendText(str);
            }
        }

        private void appendFormulaDisplayArea(string chars)
        {
            formulaDispArea.AppendText(chars);
        }

        private void calcResult()
        {
            try {
                checked {
                    switch (calc_type) {
                        case CalcType.Sum:
                            calc_res += Convert.ToInt64(resultDispArea.Text);
                            break;
                        case CalcType.Minus:
                            calc_res -= Convert.ToInt64(resultDispArea.Text);
                            break;
                        case CalcType.Times:
                            calc_res = (calc_res * Convert.ToInt64(resultDispArea.Text));
                            break;
                        case CalcType.Divide:
                            calc_res = (calc_res / Convert.ToInt64(resultDispArea.Text));
                            break;
                        default:
                            resultDispArea.Text = "Fatal";
                            break;
                    }
                }
            }
            catch (OverflowException ex)
            {
                resultDispArea.Text = "Over flow";
                return;
            }
            catch (FormatException ex)
            {
                resultDispArea.Text = "Fatal";
                return;
            }
            resultDispArea.Text = calc_res.ToString();
            isnext = true;
            calc_type = CalcType.Undefined;
        }

        private void changeOperation(string operation)
        {
            if (calc_type != CalcType.Undefined)
                formulaDispArea.Text = formulaDispArea.Text.Remove(formulaDispArea.Text.Length - 1);

            appendFormulaDisplayArea(operation);
        }
    }
}
