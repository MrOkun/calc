using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace calc
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
            Start();
        }

        static private string Operate(string rawA, string rawB, int _operator)
        {
            double a;
            double b;

            try
            {
                a = double.Parse(rawA);
                b = double.Parse(rawB);
            }
            catch
            {
                return "Invalid Numbers";
            }

            switch (_operator)
            {
                case 0:
                    {
                        try
                        {
                            string answer = (a + b).ToString();
                            return answer;
                        }
                        catch
                        {
                            return "";
                        }
                    }
                case 1:
                    {
                        try
                        {
                            string answer = (a - b).ToString();
                            return answer;
                        }
                        catch
                        {
                            return "";
                        }
                    }
                case 2:
                    {
                        try
                        {
                            string answer = (a * b).ToString();
                            return answer;
                        }
                        catch
                        {
                            return "";
                        }
                    }
                case 3:
                    {
                        try
                        {
                            string answer = (a / b).ToString();
                            return answer;
                        }
                        catch
                        {
                            return "";
                        }
                    }
            }

            return "";
        }

        private void First_Number_Box_TextChanged(object sender, EventArgs e)
        {
            Ansver_Box.Text = Operate(First_Number_Box.Text, Second_Number_Box.Text, Operator_Box.SelectedIndex).ToString();
        }

        private void Second_Number_Box_TextChanged(object sender, EventArgs e)
        {
            Ansver_Box.Text = Operate(First_Number_Box.Text, Second_Number_Box.Text, Operator_Box.SelectedIndex).ToString();
        }

        private void Operator_Box_SelectedIndexChanged(object sender, EventArgs e)
        {
            Ansver_Box.Text = Operate(First_Number_Box.Text, Second_Number_Box.Text, Operator_Box.SelectedIndex).ToString();
        }

        private void Ansver_Box_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Ответ был скопирован в буфер обмена.", "Оповещение");
            Clipboard.SetText(Ansver_Box.Text);
        }

        private void Start()
        {
            try
            {
                if (!File.Exists("dance.gif"))
                {
                    WebClient client = new WebClient();
                    client.DownloadFile("https://i.imgur.com/cjcYrqI.gif", "dance.gif");
                }

                pictureBox1.Image = new Bitmap("dance.gif", true);
            }
            catch
            {
                pictureBox1.Image = new Bitmap(100, 100);
            }
            
        }
    }
}
