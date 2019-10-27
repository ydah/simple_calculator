using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace simple_calculator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            appendFormulaDisplayArea("1");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            appendFormulaDisplayArea("2");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            appendFormulaDisplayArea("3");
        }

        private void button4_Click(object sender, EventArgs e)
        {
            appendFormulaDisplayArea("4");
        }

        private void button5_Click(object sender, EventArgs e)
        {
            appendFormulaDisplayArea("5");
        }

        private void button6_Click(object sender, EventArgs e)
        {
            appendFormulaDisplayArea("6");
        }

        private void button7_Click(object sender, EventArgs e)
        {
            appendFormulaDisplayArea("7");
        }

        private void button8_Click(object sender, EventArgs e)
        {
            appendFormulaDisplayArea("8");
        }

        private void button9_Click(object sender, EventArgs e)
        {
            appendFormulaDisplayArea("9");
        }

        private void button0_Click(object sender, EventArgs e)
        {
            if (formulaDispArea.Text.Length == 0)
                return;

            appendFormulaDisplayArea("0");
        }

        private void sumButton_Click(object sender, EventArgs e)
        {
            if (formulaDispArea.Text.Length == 0)
                return;

            appendFormulaDisplayArea("+");
        }

        private void minButton_Click(object sender, EventArgs e)
        {

        }

        private void multiButton_Click(object sender, EventArgs e)
        {

        }

        private void divButton_Click(object sender, EventArgs e)
        {

        }

        private void signToggleButton_Click(object sender, EventArgs e)
        {

        }

        private void decimalPointButton_Click(object sender, EventArgs e)
        {

        }

        private void CEButton_Click(object sender, EventArgs e)
        {

        }

        private void CButton_Click(object sender, EventArgs e)
        {
            formulaDispArea.ResetText();
        }

        private void backSpaceButton_Click(object sender, EventArgs e)
        {
            if (formulaDispArea.Text.Length == 0)
                return;

            formulaDispArea.Text = formulaDispArea.Text.Remove(formulaDispArea.Text.Length - 1);
        }

        private void resultDisplayButton_Click(object sender, EventArgs e)
        {
            if (formulaDispArea.Text.Length == 0)
                return;

            string[] split_values = formulaDispArea.Text.Split('+');
            var list = new List<string>();
            list.AddRange(split_values);

            long result = 0;
            try
            {
                checked
                {
                    foreach (string value in list)
                    {
                        if (value == "")
                            continue;

                        result += Convert.ToInt64(value);
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
            resultDispArea.Text = result.ToString();
        }

        private void appendFormulaDisplayArea(string character)
        {
            formulaDispArea.AppendText(character);
        }
    }
}
