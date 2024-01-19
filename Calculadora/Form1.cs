namespace Calculadora
{
    public partial class Calculadora : Form

    {
        string selectedOperator;
        int acumulatedValue;

        public Calculadora()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }


        private void NumberAction_Click(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            int buttonValue = int.Parse(button.Text);
            int currentValue = int.Parse(txtValue.Text);
            currentValue = currentValue * 10 + buttonValue;

            txtValue.Text = Convert.ToString(currentValue);
        }

        private void OperatorAction_Click(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            selectedOperator = button.Text;
            acumulatedValue = int.Parse(txtValue.Text);
            txtValue.Text = "0";

        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtValue.Text = "0";
            acumulatedValue = 0;
            selectedOperator = string.Empty;
        }

        private void btnEquals_Click(object sender, EventArgs e)
        {
            int secondAcomulatedValue = int.Parse(txtValue.Text);
            int result = 0;

            switch (selectedOperator)
            {
                case "*":
                    result = acumulatedValue * secondAcomulatedValue;
                    break;

                case "/":
                    result = acumulatedValue / secondAcomulatedValue;
                    break;

                case "+":
                    result = acumulatedValue + secondAcomulatedValue;
                    break;

                case "-":
                    result = acumulatedValue - secondAcomulatedValue;
                    break;

            }

            txtValue.Text = result.ToString();
        }
    }
}
 