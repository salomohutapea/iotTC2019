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

                for (int i = 0; i < name.Length; i++)
                {
                    name[i] = "TEAM" + " " + (i + 1);
                }

                Random rand = new Random();
                for (int i = 0; i < name.Length; i++)
                {
                    int j = rand.Next(i, name.Length);
                    temp = name[i];
                    name[i] = name[j];
                    name[j] = temp;
                }

                this.TeamName1.Text = name[0];
                this.TeamName1.BackColor = Color.FromArgb(150, Color.Black);

                this.TeamName2.Text = name[1];
                this.TeamName2.BackColor = Color.FromArgb(150, Color.Black);

                this.TeamName3.Text = name[2];
                this.TeamName3.BackColor = Color.FromArgb(150, Color.Black);

                this.TeamName4.Text = name[3];
                this.TeamName4.BackColor = Color.FromArgb(150, Color.Black);

                this.TeamName5.Text = name[4];
                this.TeamName5.BackColor = Color.FromArgb(150, Color.Black);

                this.TeamName6.Text = name[5];
                this.TeamName6.BackColor = Color.FromArgb(150, Color.Black);

                this.TeamName7.Text = name[6];
                this.TeamName7.BackColor = Color.FromArgb(150, Color.Black);

                this.TeamName8.Text = name[7];
                this.TeamName8.BackColor = Color.FromArgb(150, Color.Black);

                this.TeamName9.Text = name[8];
                this.TeamName9.BackColor = Color.FromArgb(150, Color.Black);

                this.TeamName10.Text = name[9];
                this.TeamName10.BackColor = Color.FromArgb(150, Color.Black);

                isStart = true;
            }
        }
    }
}
