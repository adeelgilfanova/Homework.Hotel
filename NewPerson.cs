using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using System.Xml.Linq;

namespace Homework.Hotel
{
    public partial class NewPerson : Form
    {
        string Photo;
        string fileName = @".\..\..\..\Info.txt";
        public new string Number
        {
            get { return label1.Text; }
            set { label1.Text = value; }
        }

        public static NewPerson open_form { get; internal set; }

        public NewPerson()
        {
            InitializeComponent();
            StartPosition = FormStartPosition.CenterScreen;
        }
        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                File.AppendAllText(@".\..\..\..\Info.txt", "\n");
                File.AppendAllText(@".\..\..\..\Info.txt", textBox1.Text + "|" + comboBox1.SelectedItem + "|" + label1.Text + "|" + textBox4.Text + "|" + textBox5.Text + "|" + textBox2.Text + "|" + textBox3.Text + "|" + comboBox2.Text + "|" + ".\\..\\..\\..\\Resources\\" + Photo + "|" + textBox6.Text);
                string[] lines = File.ReadAllLines(fileName);
                string[] readText = File.ReadAllLines(fileName);
                using (StreamWriter writer = new StreamWriter(fileName))
                    foreach (string line in readText)
                    {
                        if (!string.IsNullOrWhiteSpace(line))
                            writer.WriteLine(line);
                    }
            }
            catch
            {
                MessageBox.Show("Поля заполнены некорректно");
            }
            this.Close();

        }

        private void NewPerson_Load(object sender, EventArgs e)
        {

        }

        private void photo_Click(object sender, EventArgs e)
        {
            OpenFileDialog fileDialog = new OpenFileDialog();
            fileDialog.Filter = "Image Files(*.BMP;*.JPG;*.GIF;*.PNG)|*.BMP;*.JPG;*.GIF;*.PNG|All files (*.*)|*.*";
            if (fileDialog.ShowDialog() == DialogResult.OK)
            {
                char end;
                FileInfo address = new FileInfo(fileDialog.FileName);
                Photo = address.Name;
            }
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

        
    }
}
