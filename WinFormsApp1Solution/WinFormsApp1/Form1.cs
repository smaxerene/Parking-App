using ClassLibrary1;

namespace WinFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        //Next Button
        private void button1_Click(object sender, EventArgs e)
        {
            if (radioButton1.Checked) // Customer Parking selected
            {
                // Customer
                label3.Text = "Customer Parking\n" +
                              "Pay $2 for each hour\n" +
                              "Maximum Limit = 24 hours";
            }
            else if (radioButton2.Checked) // Staff Parking selected
            {
                // Staff
                label3.Text = "Staff Parking\n" +
                              "Pay $2 for first ten hours\n" +
                              "Pay $2 for each hour in excess of 10 hours\n" +
                              "Maximum Limit = 24 hours";
            }
            else
            {
                // No selection was made
                MessageBox.Show("Please select either Customer or Staff parking.");
            }

        }

        //Clear Button
        private void button2_Click(object sender, EventArgs e)
        {
            // Clear all input fields
            textBox1.Text = "";
            radioButton1.Checked = false;
            radioButton2.Checked = false;
            label3.Text = "";
            label5.Text = "";

        }

        //Calculate Button
        public double calculatedAmount = 0.0;
        public void CalculateParking(double hours)
        {
            // Check if hours are valid
            if (hours > 24)
            {
                MessageBox.Show("Parking time exceeds the maximum limit of 24 hours. Your car has been towed.");
                return;
            }

            if (radioButton1.Checked) // Customer parking selected
            {
                var customerParking = new CustomerParking((int)hours);
                calculatedAmount = hours * 2.0; // Fixed rate $2 per hour
            }
            else if (radioButton2.Checked) // Staff parking selected
            {
                var staffParking = new StaffParking((int)hours);
                
                double cost = 0;

                // Calculate the parking fee for staff
                if (hours <= 10)
                {
                    const double firstTenHoursRate = 2.0;
                    cost = firstTenHoursRate;
                }
                else if (hours > 10 && hours < 25)
                {
                    double firstTenHoursCost = 2.0;

                    // Additional hours beyond 10, each charged $2/hour
                    double additionalHoursCost = (hours - 10) * 2.0;

                    // Total cost calculation
                    calculatedAmount = firstTenHoursCost + additionalHoursCost;

                }
                else
                {
                    Console.WriteLine("You have exceeded 24 hours! Your car has been towed away");
                    cost = 0;
                }
                Console.WriteLine($"The total cost is $ {cost:F2}");
            }
            else
            {
                MessageBox.Show("Please select a parking type.");
                return;
            }

            // Display the calculated amount
            label5.Text = $"Parking Amount: ${calculatedAmount:F2}";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            double hours = 0;

            // Validate that the user entered a valid number of hours
            if (double.TryParse(textBox1.Text, out hours))
            {
                if (hours > 24)
                {
                    MessageBox.Show("Parking time exceeds the maximum limit of 24 hours. Your car has been towed.");
                    return;
                }

                // Calculate the parking details and store the results
                CalculateParking(hours);
            }
            else
            {
                MessageBox.Show("Please enter a valid number of hours.");
            }

        }

        //Exit Button
        private void button4_Click(object sender, EventArgs e)
        {
            // Ask for confirmation before closing the application
            var confirmResult = MessageBox.Show("Are you sure you want to exit?", "Exit Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (confirmResult == DialogResult.Yes)
            {
                Application.Exit(); // Close the application
            }
        }

        //Parking Amount
        private void label4_Click(object sender, EventArgs e)
        {
            label4.Text = $"Parking Amount: ${calculatedAmount:F2}";
        }

    }


}
