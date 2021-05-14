using System;
using System.Windows.Forms;

namespace Calculator
{
    public partial class CalcForm : Form
    {
        Calculator calculator = new Calculator();

        public CalcForm()
        {
            InitializeComponent();
            RefreshOutput();
        }
        
        private void RefreshOutput()
        {
            calcOutputLabel.Text = calculator.Total;
        }
       
        //button clicks
        private void oneButton_Click(object sender, EventArgs e)
        {
            if(!calculator.IsOperatorSelected)
                calculator.AppendToLeftNum("1");
            else
                calculator.AppendToRightNum("1");
             
            RefreshOutput();
        }

        private void twoButton_Click(object sender, EventArgs e)
        {
            if (!calculator.IsOperatorSelected)
                calculator.AppendToLeftNum("2");
            else
                calculator.AppendToRightNum("2");

            RefreshOutput();
        }

        private void threeButton_Click(object sender, EventArgs e)
        {
            if (!calculator.IsOperatorSelected)
                calculator.AppendToLeftNum("3");
            else
                calculator.AppendToRightNum("3");

            RefreshOutput();
        }
        private void fourButton_Click(object sender, EventArgs e)
        {
            if (!calculator.IsOperatorSelected)
                calculator.AppendToLeftNum("4");
            else
                calculator.AppendToRightNum("4");

            RefreshOutput();
        }

        private void fiveButton_Click(object sender, EventArgs e)
        {
            if (!calculator.IsOperatorSelected)
                calculator.AppendToLeftNum("5");
            else
                calculator.AppendToRightNum("5");

            RefreshOutput();
        }

        private void sixButton_Click(object sender, EventArgs e)
        {
            if (!calculator.IsOperatorSelected)
                calculator.AppendToLeftNum("6");
            else
                calculator.AppendToRightNum("6");

            RefreshOutput();
        }

        private void sevenButton_Click(object sender, EventArgs e)
        {
            if (!calculator.IsOperatorSelected)
                calculator.AppendToLeftNum("7");
            else
                calculator.AppendToRightNum("7");

            RefreshOutput();
        }

        private void eightButton_Click(object sender, EventArgs e)
        {
            if (!calculator.IsOperatorSelected)
                calculator.AppendToLeftNum("8");
            else
                calculator.AppendToRightNum("8");

            RefreshOutput();
        }

        private void nineButton_Click(object sender, EventArgs e)
        {
            if (!calculator.IsOperatorSelected)
                calculator.AppendToLeftNum("9");
            else
                calculator.AppendToRightNum("9");

            RefreshOutput();
        }

        private void zeroButton_Click(object sender, EventArgs e)
        {
            if (!calculator.IsOperatorSelected)
                calculator.AppendToLeftNum("0");
            else
                calculator.AppendToRightNum("0");

            RefreshOutput();
        }

        private void decimalButton_Click(object sender, EventArgs e)
        {
            if (!calculator.IsOperatorSelected)
                calculator.AppendToLeftNum(".");
            else
                calculator.AppendToRightNum(".");

            RefreshOutput();
        }

        private void additionButton_Click(object sender, EventArgs e)
        {
            if (calculator.IsReadyToCalculate)
                calculator.CalculateTotal();
            
            calculator.SetOperator(OperatorType.ADD);

            RefreshOutput();
        }

        private void subtractButton_Click(object sender, EventArgs e)
        {
            if (calculator.IsReadyToCalculate)
                calculator.CalculateTotal();

            calculator.SetOperator(OperatorType.SUBTRACT);

            RefreshOutput();
        }
        private void multiplyButton_Click(object sender, EventArgs e)
        {
            if (calculator.IsReadyToCalculate)
                calculator.CalculateTotal();

            calculator.SetOperator(OperatorType.MULTIPLY);

            RefreshOutput();
        }

        private void divideButton_Click(object sender, EventArgs e)
        {
            if (calculator.IsReadyToCalculate)
                calculator.CalculateTotal();

            calculator.SetOperator(OperatorType.DIVIDE);

            RefreshOutput();
        }

        private void inverseButton_Click(object sender, EventArgs e)
        {
            if (calculator.IsReadyToCalculate)
                calculator.CalculateTotal();

            if (!calculator.IsOperatorSelected)
                calculator.CalculateInverse();

            RefreshOutput();
        }

        private void negativeButton_Click(object sender, EventArgs e)
        {
            calculator.ToggleNegative();
            RefreshOutput();
        }

        private void equalsButton_Click(object sender, EventArgs e)
        {
            if (calculator.IsReadyToCalculate)
            {
                calculator.CalculateTotal();
                RefreshOutput();
            }
        }

        private void clearButton_Click(object sender, EventArgs e)
        {
            calculator.ClearAll();
            RefreshOutput();
        }

        private void calcOutputLabel_Click(object sender, EventArgs e)
        {

        }
    }
}
