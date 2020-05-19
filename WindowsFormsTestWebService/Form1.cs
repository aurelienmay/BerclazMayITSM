using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsTestWebService
{
    public partial class Form1 : Form
    {
        private ServiceReferenceCalculator.CalculatorClient client;

        public Form1()
        {
            InitializeComponent();
            client = new ServiceReferenceCalculator.CalculatorClient();
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            var result = client.Add(double.Parse(textBoxA.Text), double.Parse(textBoxB.Text));
            textBoxResult.Text = result.ToString();
        }

        private void buttonSub_Click(object sender, EventArgs e)
        {
            var result = client.Sub(double.Parse(textBoxA.Text), double.Parse(textBoxB.Text));
            textBoxResult.Text = result.ToString();
        }

        private void buttonMult_Click(object sender, EventArgs e)
        {
            var result = client.Mult(double.Parse(textBoxA.Text), double.Parse(textBoxB.Text));
            textBoxResult.Text = result.ToString();
        }

        private void buttonDiv_Click(object sender, EventArgs e)
        {
            var result = client.Div(double.Parse(textBoxA.Text), double.Parse(textBoxB.Text));
            textBoxResult.Text = result.ToString();
        }
    }
}
