using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Train_Booking_Form
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

            if(monthCalendar1.SelectionStart > monthCalendar1.TodayDate)
            {
                label5.Text = textBox1.Text+" ,From "+textBox2.Text+" To "+textBox3.Text +" Tickets Booked for"+monthCalendar1.SelectionStart.ToString();
            }
            else
            {
                label5.Text = "Sorry! Ticket not Availabel";
            }
        }

        private void monthCalendar1_DateChanged(object sender, DateRangeEventArgs e)
        {
            textBox4.Text = monthCalendar1.SelectionStart.ToShortDateString();
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }
    }
}
