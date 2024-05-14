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
    public partial class viewTicket : Form
    {
        int seat;
        bool butonControl=false;
        public viewTicket()
        {
            InitializeComponent();
        }

        private void viewTicket_Load(object sender, EventArgs e)
        { }

        private void button1_Click(object sender, EventArgs e)
        {
            if (butonControl==false)
            {
                seat = Convert.ToInt32(textBox1.Text);
                seat -= 202400;
                if (seat < 0)
                    seat += 182160;
                else { }
                if (buyTicket2.data[seat - 1, 0] == null)
                {
                    MessageBox.Show("Ticket are not available");
                    textBox1.Clear();
                }
                else
                {
                    for (int i = 0; i < 7; i++)
                    {
                        listBox1.Items.Add(buyTicket2.data[seat - 1, i]);
                    }
                    butonControl = true;
                }    
            }
            else
            {
                listBox1.Items.Clear();
                seat = Convert.ToInt32(textBox1.Text);
                seat -= 202400;
                if (seat < 0)
                    seat += 182160;
                else { }
                if (buyTicket2.data[seat - 1, 0] == null)
                {
                    MessageBox.Show("Ticket are not available");
                    textBox1.Clear();
                }
                else
                {
                    for (int i = 0; i < 7; i++)
                    {
                        listBox1.Items.Add(buyTicket2.data[seat - 1, i]);
                    }
                    butonControl = true;
                }
            }
        }
    }
}
