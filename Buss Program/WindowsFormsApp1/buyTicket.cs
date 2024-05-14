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
    public partial class buyTicket : Form
    {
        public static string seat;
        char[] butonColor = new char[29];
        public buyTicket()
        {
            InitializeComponent();
        }
        
        private void buyTicket_Load(object sender, EventArgs e)
        {
            if (startScreen.admin==true)
            {
                button1.Visible = true;
            }
            for (int i = 0; i < 29; i++)
            {
                if (buyTicket2.data[i, 2] == "Man")
                {
                    butonColor[i] = 'M';
                    
                }
                else if (buyTicket2.data[i,2]=="Woman")
                    butonColor[i] = 'W';
            }
            int horizontalAxis = 0, verticalAxis = 0, butonNumber = 1;
            for (int i = 0; i < 29; i++)
            {
                if (i == 18)
                {
                    horizontalAxis = 3;
                }
                if (i == 28)
                {
                    verticalAxis--;
                    horizontalAxis = 2;
                }
                Button btn = new Button();
                btn.Size = new Size(95, 65);
                this.Controls.Add(btn);
                btn.Click += new EventHandler(this.Btn_Click);
                btn.MouseHover += new EventHandler(this.Btn_MouseHover);
                btn.Location = new Point(307 - (horizontalAxis * 101), 90 + (verticalAxis * 70));
                btn.Text = butonNumber.ToString();
                btn.Name = butonNumber.ToString();
                if (butonColor[butonNumber - 1] == 'M')
                {
                    btn.BackColor = Color.LightBlue;
                }
                else if (butonColor[butonNumber - 1] == 'W')
                {
                    btn.BackColor = Color.Pink;
                }
                else
                    btn.BackColor = Color.Gainsboro;
                butonNumber++;
                horizontalAxis++;
                if (i == 18)
                {
                    verticalAxis++;
                    horizontalAxis = 0;
                }
                if (horizontalAxis % 2 == 0 && i != 18)
                {
                    horizontalAxis++;
                }
                if (i > 0 && i % 3 == 2 && i < 18)
                {
                    verticalAxis++;
                    horizontalAxis = 0;
                }
                if (i % 3 == 0 && i > 18)
                {
                    verticalAxis++;
                    horizontalAxis = 0;
                }
            }
        }
        private void Btn_Click(object sender, EventArgs e)
        {
            Button btn = sender as Button;
            seat = btn.Text;
            if (startScreen.admin == false)
            {
                if (buyTicket2.data[Convert.ToInt32(seat) - 1, 2] != null)
                {
                    MessageBox.Show("You cannot buy this seat");
                }
                else
                {
                    genderControl genderControlForm = new genderControl();
                    seat = btn.Text;
                    genderControlForm.Show();
                }
            }
            if (startScreen.admin == true)
            {
                if (buyTicket2.data[Convert.ToInt32(seat) - 1, 2] == null)
                {
                    MessageBox.Show("Ticket are not available");
                }
                else
                {
                    for (global::System.Int32 i = 0; i < 7; i++)
                    {
                        buyTicket2.data[Convert.ToInt32(seat) - 1, i] = null;
                    }
                    MessageBox.Show("deletion successful");
                }
            }
        }
        private void Btn_MouseHover(object sender, EventArgs e)
        {
            if (startScreen.admin==true)
            {
                Button btn = sender as Button;
                toolTip1.SetToolTip(btn, $"Name: {buyTicket2.data[Convert.ToInt32(btn.Text) - 1, 0]}\n" +
                    $"Surname: {buyTicket2.data[Convert.ToInt32(btn.Text) - 1, 1]}\n" +
                    $"Gender: {buyTicket2.data[Convert.ToInt32(btn.Text) - 1, 2]}\n" +
                    $"Phone: {buyTicket2.data[Convert.ToInt32(btn.Text) - 1, 3]}\n" +
                    $"From: {buyTicket2.data[Convert.ToInt32(btn.Text) - 1, 4]}\n" +
                    $"To: {buyTicket2.data[Convert.ToInt32(btn.Text) - 1, 5]}\n" +
                    $"Seat Num: {buyTicket2.data[Convert.ToInt32(btn.Text) - 1, 6]}");
            }  
        }

        private void button1_Click(object sender, EventArgs e)
        {
            startScreen.admin = false;
            MessageBox.Show("Process successfull");
            MessageBox.Show("Please Close the window");
        }
    }
}
