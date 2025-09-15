using System.Xml.Linq;

namespace Vasco_Assignment1_IS325
{
    public partial class Assignment1 : Form
    {
        private double HOUR_PAY = 10.50;
        public Assignment1()
        {
            InitializeComponent();
        }

        private void summarizeButton_Click(object sender, EventArgs e)
        {
            try
            {
                lblOutput.Text = $" {txtFirstName.Text} {txtLastName.Text} worked {txtHoursWorked.Text} hours at ${HOUR_PAY} an hour for a total of ${int.Parse(txtHoursWorked.Text) * HOUR_PAY}.";
                lblOutput.ForeColor = Color.Black;

            }
            catch (Exception ex)
            {
                lblOutput.Text = "Please enter a number of hours worked";
                lblOutput.ForeColor = Color.Red;
            }

        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            lblOutput.Text = "";
        }

        private void txtFirstName_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtLastName_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtHoursWorked_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
