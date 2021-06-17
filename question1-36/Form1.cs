using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace question1_36
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        int[,] studentDetails = new int[50, 4];

        private void btnInsert_Click(object sender, EventArgs e)
        {

            int stuNo = int.Parse(txtStuNo.Text);
            int dm = int.Parse(txtDM.Text);
            int rad = int.Parse(txtRAD.Text);
            int os = int.Parse(txtOS.Text);

            Calculation cal = new Calculation();

            cal.InsertMarks(stuNo, dm, rad, os);

           
            studentDetails = cal.InsertMarks(stuNo, dm, rad, os); 
           lblAvg.Text = studentDetails[0,0].ToString() + " data inserted";

            txtDM.Clear();
            txtOS.Clear();
            txtRAD.Clear();
            txtStuNo.Clear();


        }

        private void btnOverall_Click(object sender, EventArgs e)
        {
            Calculation cal = new Calculation();
            
            double[] average = cal.CalcAvg(studentDetails);
            
            

             lblAvg.Text = "rad avg = " + average [0].ToString();
        }
    }
}
