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
    
    public partial class startScreen : Form
    {
        public static bool admin = false;
        public startScreen()
        {
            InitializeComponent();
        }

        private void startScreen_Load(object sender, EventArgs e)
        {}

        private void button1_Click(object sender, EventArgs e)
        {
            buyTicket buyTicketForm = new buyTicket();
            buyTicketForm.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            viewTicket viewTicketForm = new viewTicket();
            viewTicketForm.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            sellTicket sellTicketForm = new sellTicket();
            sellTicketForm.Show();
        }
        private void button4_Click_1(object sender, EventArgs e)
        {
            admin = true;
            buyTicket buyTicketForm = new buyTicket();
            buyTicketForm.Show();
        }
    }
}
