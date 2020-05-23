using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsTestWebservice
{
    public partial class Form1 : Form
    {

        private ServiceReferencePayment.PaymentServiceClient client;


        // Constructor
        public Form1()
        {
            InitializeComponent();
            client = new ServiceReferencePayment.PaymentServiceClient();
        }

        private void radioButtonUID_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void radioButtonUsername_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void textBoxUIDUsername_TextChanged(object sender, EventArgs e)
        {

        }

        private void buttonShowBalance_Click(object sender, EventArgs e)
        {

            double result=-1;
            double quotas = -1;

            try{

                if (radioButtonUID.Checked == true)
                {
                    result = client.GetBalanceByUID(Int32.Parse(textBoxUIDUsername.Text));
                    quotas = client.ShowQuotasByUID(Int32.Parse(textBoxUIDUsername.Text));
                }

                if (radioButtonUsername.Checked == true)
                {
                    result = client.GetBalanceByUsername(textBoxUIDUsername.Text);
                    quotas = client.ShowQuotasByUsername(textBoxUIDUsername.Text);
                }

               
                textBoxResult.Text = result.ToString();
                textBoxQuotas.Text = quotas.ToString();

            }
            catch(Exception error){
                Console.WriteLine("IOException source: {0}", error.Source);
                MessageBox.Show("Fail, nothing found try again or change values. Error message:" + error.Message);
            }
        }

        private void textBoxAmount_TextChanged(object sender, EventArgs e)
        {

        }

        private void buttonAmount_Click(object sender, EventArgs e)
        {

            var result = "";

            try
            {
                double amount = double.Parse(textBoxAmount.Text);

                if (radioButtonUID.Checked == true)
                {
                    client.AddCashWithUID(Int32.Parse(textBoxUIDUsername.Text), float.Parse(textBoxAmount.Text));

                    result = "Successfully added " + amount + " on UID: " + textBoxUIDUsername.Text;
                }

                if (radioButtonUsername.Checked == true)
                {
                    client.AddCashWithUsername(textBoxUIDUsername.Text, float.Parse(textBoxAmount.Text));

                    result = "Successfully added " + amount + " for username: " + textBoxUIDUsername.Text;
                }

                textBoxResult.Text = result;
                textBoxQuotas.Text = "For " + amount + " CHF: " + Convert.ToInt32(Math.Floor(amount / 0.08)).ToString() + " A4 pages";

            }
            catch (Exception error)
            {
                Console.WriteLine("IOException source: {0}", error.Source);
                MessageBox.Show("Fail, please enter an amount to add. Error message:" + error.Message);
            }

        }

        private void textBoxResult_TextChanged(object sender, EventArgs e)
        {
        }

        private void labelResult_Click(object sender, EventArgs e)
        {

        }

        private void textBoxQuotas_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
