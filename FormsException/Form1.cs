namespace FormsException
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCompute_Click(object sender, EventArgs e)
        {
            try
            {
                var num1 = Convert.ToDouble(textBox1.Text);
                var num2 = Convert.ToDouble(textBox2.Text);

                if (num1 == 0 || num2 == 0)
                {
                    throw new DivideByZeroException("Cannot divide 0.");
                }

                double result = num1 / num2;

                MessageBox.Show("Total: " + result);
            }
            catch (FormatException exception)
            {
                // show a dialog that indicates wrong input
                MessageBox.Show(exception.Message);
            }
            catch (DivideByZeroException exception)
            {
                // show a dialog that indicates wrong input
                MessageBox.Show(exception.Message);
            }
            finally
            {
                MessageBox.Show("Thank you for using the app!");
            }

        }
    }
}