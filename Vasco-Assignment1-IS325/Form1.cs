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

            }
            catch (Exception ex)
            {
                lblOutput.Text = "PLEASE ENTER A NUMBER FOR YOUR HOURS WORKED";
            }

        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            lblOutput.Text = "";
        }
    }
}
