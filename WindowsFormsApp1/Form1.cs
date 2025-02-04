using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApp1;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        GPACalculator gPACalculator;
        public Form1()
        {
            InitializeComponent();
            gPACalculator = new GPACalculator();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            try
            {
                double input = double.Parse(this.tbInputGPA.Text);
                gPACalculator.setGPA(input);

                this.tbGPAx.Text = gPACalculator.getGPAX().ToString("F2");
                this.tbInputStd.Text = gPACalculator.getStudentCount().ToString();
                this.tbMax.Text = gPACalculator.getMaxGPA().ToString("F2");
                this.tbMin.Text = gPACalculator.getMinGPA().ToString("F2");

                MessageBox.Show(gPACalculator.getGPAInfo(), "DATA GPA");

                this.tbInputGPA.Text = string.Empty;
            }
            catch(Exception ex) 
            {
                MessageBox.Show("ตัวเลขไม่ถูกต้อง");
                this.tbInputGPA.Text=string.Empty;
            }
        }


        private void tbInputGPA_TextChanged(object sender, EventArgs e)
        {

        }

        private void tbGPAx_TextChanged(object sender, EventArgs e)
        {

        }

    }
}
