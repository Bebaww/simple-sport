using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)

        {
            double h = Convert.ToDouble(txt_height.Text);
           double W=Convert.ToDouble(  txt_weight.Text);
           double bmi = Convert.ToDouble(W / (h * h));
            txt_bmi.Text = bmi.ToString();

            MessageBox.Show("name:" + txt_name.Text + "\n" +
                "weight:" + txt_weight.Text + "kg" + "\n"+
                "height:" + txt_height.Text + "m"+ "\n"+
                "bmi:" + txt_bmi.Text +"\n"+
                "exercise:" + txt_exercise.Text +"\n"+
                "reps:" + txt_reps.Text);


        }
    }
}
