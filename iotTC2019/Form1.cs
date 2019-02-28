using System;
using System.Drawing;
using System.Windows.Forms;

namespace iotTC2019
{
    public partial class Form1 : Form
    {
        private bool isStart;

        public Form1()
        {
            InitializeComponent();
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void Button1_Click(object sender, EventArgs e)
        {
            button1.Enabled = false;

            if (isStart)
            {
                //DRAW button does nothing
            }
            else
            {

                string temp;
                string[] name = new string[10];

                name[0] = "Creative Station";
                name[1] = "Cockroachtic";
                name[2] = "Daniel";
                name[3] = "Doa Ibu";
                name[4] = "Erkim";
                name[5] = "Ex Team";
                name[6] = "Fight Team";
                name[7] = "Muazin";
                name[8] = "SIRI";
                name[9] = "Zenze Robo";

                Random rand = new Random();
                for (int i = 0; i < name.Length; i++)
                {
                    int j = rand.Next(i, name.Length);
                    temp = name[i];
                    name[i] = name[j];
                    name[j] = temp;
                }

                this.TeamName1.Text = name[0];

                this.TeamName2.Text = name[1];

                this.TeamName3.Text = name[2];

                this.TeamName4.Text = name[3];

                this.TeamName5.Text = name[4];

                this.TeamName6.Text = name[5];

                this.TeamName7.Text = name[6];

                this.TeamName8.Text = name[7];

                this.TeamName9.Text = name[8];

                this.TeamName10.Text = name[9];


                isStart = true;
            }
        }
    }
}
