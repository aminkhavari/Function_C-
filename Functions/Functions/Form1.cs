using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Functions
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }

        private void btnDay_Click(object sender, EventArgs e)
        {
            var a= -1;
            var s = int.TryParse(txtdaynumber.Text,out a);
            if(s == true)
            {
                MessageBox.Show(Week(a));
            }
            else
            {
                MessageBox.Show("...");
            }
            
        }

        string Week(int a)
        {
            string day;
            switch(a)
            {

                case 0:
                    day = "شنبه";
                    break;
                case 1:
                    day = "یکشنبه";
                    break;
                case 2:
                    day = "دوشنبه";
                    break;
                case 3:
                    day = "سه شنبه";
                    break;
                case 4:
                    day = "چهار شنبه";
                    break;
                case 5:
                    day = "پنجشنبه";
                    break;
                case 6:
                    day = "جمعه";
                    break;
                default :
                    day = "جمعه";
                    break;
            }
            return day;
        }
    }
}
