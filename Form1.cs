using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WeightApp
{
    public partial class Form1 : Form
    {
        
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        String weight;
        private void SelfWeightBox_TextChanged(object sender, EventArgs e)
        {


            weight = SelfWeightBox.Text;
            
        }

        private void MarsWeightBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            int userWeight = int.Parse(weight);
            int weightOnMars = (int)((int)(userWeight) * 0.38);

            MessageBox.Show("Your Weight On Mars Is " + weightOnMars + " Pounds!");
        }

        private void marsWeight_Click(object sender, EventArgs e)
        {

        }

        private void earthWeight_Click(object sender, EventArgs e)
        {
          
        }

        private void clearWeight_Click(object sender, EventArgs e)
        {
            SelfWeightBox.Text = "";
        }
    }
}
