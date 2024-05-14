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
    public partial class genderControl : Form
    {
        public static string gender;
        public genderControl()
        {
            InitializeComponent();
        }
        int seat;
        private void genderControl_Load(object sender, EventArgs e)
        {
            seat=Convert.ToInt32(buyTicket.seat);
        }
        private void pictureBox2_Click(object sender, EventArgs e)
        {
            gender = "Woman";
            genderControlMethod(gender);
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            gender = "Man";
            genderControlMethod(gender);
        }
        private void genderControlMethodIf(bool ıf, string gender, int i, int j)
        {
            if (ıf == true)
            {
                if (buyTicket2.data[seat - i, 2] == gender || buyTicket2.data[seat - i, 2] == null)
                {
                    buyTicket2 buyTicket2Form = new buyTicket2();
                    buyTicket2Form.Show();
                }
                else
                {
                    MessageBox.Show("You cannot buy this seat");
                    gender = null;
                }
            }
            else
            {
                if (buyTicket2.data[seat - i, 2] == gender && buyTicket2.data[seat - j, 2] == gender)
                {
                    buyTicket2 buyTicket2Form = new buyTicket2();
                    buyTicket2Form.Show();
                }
                else if (buyTicket2.data[seat - i, 2] == gender && buyTicket2.data[seat - j, 2] == null)
                {
                    buyTicket2 buyTicket2Form = new buyTicket2();
                    buyTicket2Form.Show();
                }
                else if (buyTicket2.data[seat - i, 2] == null && buyTicket2.data[seat - j, 2] == null)
                {
                    buyTicket2 buyTicket2Form = new buyTicket2();
                    buyTicket2Form.Show();
                }
                else if (buyTicket2.data[seat - i, 2] == null && buyTicket2.data[seat - j, 2] == gender)
                {
                    buyTicket2 buyTicket2Form = new buyTicket2();
                    buyTicket2Form.Show();
                }
                else
                {
                    MessageBox.Show("You cannot buy this seat");
                    gender = null;
                }
            }
        }
        private void genderControlMethod(string gender)
        {
            if (seat < 18 && seat % 3 == 2)
            {
                genderControlMethodIf(true, gender, 2,0);
            }
            else if (seat < 18 && seat % 3 == 1)
            {
                genderControlMethodIf(true, gender, 0, 0);
            }
            else if (seat == 27)
            {
                genderControlMethodIf(false, gender, 2, -1);  
            }
            else if ((seat < 29 && seat > 19) && seat % 3 == 0)
            {
                genderControlMethodIf(true, gender, 2, 0);
            }
            else if ((seat < 29 && seat > 19) && seat % 3 == 2)
            {
                genderControlMethodIf(true, gender, 0, 0);
            }
            else if ((seat < 30 && seat > 27) && seat % 3 == 1)
            {
                genderControlMethodIf(true, gender, 0, 0);
            }
            else if (seat==29)
            {
                genderControlMethodIf(false, gender, 2, 3);
            }
        }   
    }
}
