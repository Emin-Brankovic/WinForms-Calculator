using System.Text.RegularExpressions;

namespace FITCalculator2024
{
    public enum Operations
    {
        Addition,
        Subtraction,
        Multiplication,
        Division,
    }

    public partial class frmCalculator : Form
    {
        private Stack<Operations> OperationsStack;
        private double Buffer { get; set; } = double.NaN;

        public frmCalculator()
        {
            InitializeComponent();
            OperationsStack = new Stack<Operations>();
            txtDisplay.Focus();
        }

        private void NumberButton_Clicked(object sender, EventArgs e)
        {
            var button = sender as Button;
            if (button != null)
            {
                if (button.Text == ".")
                {
                    var str = txtDisplay.Text;
                    if (!str.Contains("."))
                    {
                        txtDisplay.Text += ".";
                    }
                }
                else
                    txtDisplay.Text += button.Text;
            }
        }
        private void PerformOperation()
        {
            if (double.IsNaN(Buffer))
            {
                Buffer = double.Parse(txtDisplay.Text);
                lblBuffer.Text = Buffer.ToString();
            }
            else if (OperationsStack.Count > 0)
            {
                var operation = OperationsStack.Pop();
                EvaluateOperation(operation);
            }
        }

        private void EvaluateOperation(Operations operation)
        {
            if (!string.IsNullOrEmpty(txtDisplay.Text))
            {
                switch (operation)
                {
                    case Operations.Addition:
                        Buffer += double.Parse(txtDisplay.Text);
                        break;
                    case Operations.Subtraction:
                        Buffer -= double.Parse(txtDisplay.Text);
                        break;
                    case Operations.Multiplication:
                        Buffer *= double.Parse(txtDisplay.Text);
                        break;
                    case Operations.Division:
                        Buffer /= double.Parse(txtDisplay.Text);
                        break;
                }
            }
            txtDisplay.Text = Buffer.ToString("F2");
            lblBuffer.Text = Buffer.ToString("F2");
        }

        private void ExecuteOperation(Operations operation)
        {
            PerformOperation();

            OperationsStack.Push(operation);
            txtDisplay.Clear();
        }


        private void btnBackspace_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtDisplay.Text))
                return;

            var str = txtDisplay.Text;
            str = str.Remove(str.Length - 1);
            txtDisplay.Text = str;
        }

        private void btnNegate_Click(object sender, EventArgs e)
        {
            var number = double.TryParse(txtDisplay.Text, out var result) ? result * -1 : 0;
            txtDisplay.Text = number.ToString();
        }

        private void btnAddition_Click(object sender, EventArgs e)
        {
            ExecuteOperation(Operations.Addition);
        }

        private void btnSubtraction_Click(object sender, EventArgs e)
        {
            ExecuteOperation(Operations.Subtraction);
        }

        private void btnMultiplication_Click(object sender, EventArgs e)
        {
            ExecuteOperation(Operations.Multiplication);
        }

        private void btnDivision_Click(object sender, EventArgs e)
        {
            ExecuteOperation(Operations.Division);
        }

        private void btnEquals_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtDisplay.Text))
            {
                if (OperationsStack.Count != 0)
                {
                    var operation = OperationsStack.Pop();
                    EvaluateOperation(operation);
                }
            }

            txtDisplay.Text = Buffer.ToString("F2");
            lblBuffer.Text = Buffer.ToString("F2");
            OperationsStack.Clear();
            txtDisplay.Focus();
        }

        private void txtDisplay_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != (char)Keys.Back && e.KeyChar != ',')
                e.Handled = true;

            OperationRecognition(e);
        }

        private void OperationRecognition(KeyPressEventArgs e)
        {
            switch (e.KeyChar)
            {
                case '+':
                    ExecuteOperation(Operations.Addition);
                    //if (!double.IsNaN(Buffer))
                    //    txtDisplay.Clear();
                    break;
                case '-':
                    ExecuteOperation(Operations.Subtraction);
                    if (!double.IsNaN(Buffer))
                        txtDisplay.Clear();
                    break;
                case '*':
                    ExecuteOperation(Operations.Multiplication);
                    if (!double.IsNaN(Buffer))
                        txtDisplay.Clear();
                    break;
                case '/':
                    ExecuteOperation(Operations.Division);
                    if (!double.IsNaN(Buffer))
                        txtDisplay.Clear();
                    break;
                default:
                    return;
            }
        }

        private void btnClearErr_Click(object sender, EventArgs e)
        {
            txtDisplay.Clear();
            txtDisplay.Focus();
        }

        private void btnClearAll_Click(object sender, EventArgs e)
        {
            OperationsStack.Clear();
            Buffer = double.NaN;
            txtDisplay.Clear();
            lblBuffer.Text = "";
            txtDisplay.Focus();
        }
    }
}