using System.Globalization;
using System.Drawing;
using System.Windows.Forms;
using System.Data;
using System.Text.RegularExpressions;
using System.Xml;
using System;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Rebar;
using static System.Windows.Forms.DataFormats;
using System.Reflection;
using static System.Net.Mime.MediaTypeNames;
using Homework.Hotel;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TaskbarClock;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ToolTip;
using System.Reflection.Emit;
using System.Xml.Linq;
using Homework.Hotel.Properties;
using System.IO;

namespace Homework.Hotel
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            Timer timer = new Timer();
            timer.Interval = 1000;
            timer.Enabled = true;
            timer.Tick += new EventHandler(timer1_Tick);
            
            

        }
        

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void status_Click(object sender, EventArgs e)
        {
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            time.Text = DateTime.Now.ToLongTimeString();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void time_TextChanged(object sender, EventArgs e)
        {

        }

        private void checkedListBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            for (int i = 0; i < Tabel.Rows.Count; i++)
                Tabel.Rows[i].Visible = Tabel[1, i].Value.ToString() == "зарезервировано";
        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            for (int i = 0; i < Tabel.Rows.Count; i++)
                Tabel.Rows[i].Visible = Tabel[1, i].Value.ToString() == "свободно";
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            for (int i = 0; i < Tabel.Rows.Count; i++)
                Tabel.Rows[i].Visible = Tabel[1, i].Value.ToString() == "занято";
        }

        private void radioButton4_CheckedChanged(object sender, EventArgs e)
        {
            for (int i = 0; i < Tabel.Rows.Count; i++)
                Tabel.Rows[i].Visible = Tabel[1, i].Value.ToString() == "выписывается";
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < Tabel.Rows.Count; i++)
            {
                Tabel.Rows[i].Visible = false;
                for (int c = 0; c < Tabel.Columns.Count; c++)
                {
                    if (Tabel[c, i].Value.ToString() == textBox1.Text)
                    {
                        Tabel.Rows[i].Visible = true;
                        Tabel.Rows[i].DefaultCellStyle.BackColor = Color.Lavender;
                        break;
                    }
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            NewPerson open_form = new NewPerson();
            open_form.Show();

        }
    }
}
