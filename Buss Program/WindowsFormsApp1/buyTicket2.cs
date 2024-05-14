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
    public partial class buyTicket2 : Form
    {
        public static string[,] data = new string[29, 7];
        public static string ticketNum;
        public buyTicket2()
        {
            InitializeComponent();
        }

        private void buyTicket2_Load(object sender, EventArgs e)
        {
            label9.Text = "";
            label9.Text = buyTicket.seat;  
        }

        private void button30_Click(object sender, EventArgs e)
        {
            data[Convert.ToInt16(buyTicket.seat) - 1, 0] = textBox1.Text;
            data[Convert.ToInt16(buyTicket.seat) - 1, 1] = textBox2.Text;
            if (genderControl.gender=="Man")
            {
                data[Convert.ToInt16(buyTicket.seat) - 1, 2] = "Man";
                genderControl.gender = null;
            }
            else if (genderControl.gender == "Woman") 
            { 
               data[Convert.ToInt16(buyTicket.seat) - 1, 2] = "Woman";
                genderControl.gender = null;
            }
            data[Convert.ToInt16(buyTicket.seat) - 1, 3] = maskedTextBox1.Text;
            data[Convert.ToInt16(buyTicket.seat) - 1 , 4] = comboBox1.Text;
            data[Convert.ToInt16(buyTicket.seat) - 1 , 5] = comboBox2.Text;
            data[Convert.ToInt16(buyTicket.seat) - 1, 6] = buyTicket.seat;
            label10.Text = ticketNum = $"2024{buyTicket.seat}";
            label11.Visible = true;  
        }
    }
}
