using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Racing_Assign_sec
{
    public partial class Form1 : Form
    {

        better bet = new better();

        public String PlayerName = "";
        public int better1 = 100, better2 = 100, better3 = 100;
        public int winner = 0,Dog=0;
        public Form1()
        {
            InitializeComponent();
            int x = 1;
            for (x = 1; x <= 50; x++) {
                betAmountCB.Items.Add(x.ToString());
            }
            btn_run.Enabled = false;
        }

        private void pl_ranjeet_CheckedChanged(object sender, EventArgs e)
        {
            if (pl_ranjeet.Checked == true)
            {
                PlayerName = "Ranjeet";
                
            }

            pl_jagroop.Checked = false;
            pl_inder.Checked = false;
        }

        private void pl_inder_CheckedChanged(object sender, EventArgs e)
        {
            if (pl_inder.Checked == true)
            {
                PlayerName = "Inder";

            }

            pl_jagroop.Checked = false;
            pl_ranjeet .Checked = false;
        }

        private void sl_dog1_CheckedChanged(object sender, EventArgs e)
        {
            if (sl_dog1.Checked == true) {
                Dog = 1;
            }
            sl_dog2.Checked = false;
            sl_dog3.Checked = false;
            sl_dog4.Checked = false;
            
        }

        private void sl_dog2_CheckedChanged(object sender, EventArgs e)
        {
            if (sl_dog2.Checked == true)
            {
                Dog = 2;
            }
            sl_dog1.Checked = false;
            sl_dog3.Checked = false;
            sl_dog4.Checked = false;

        }

        private void sl_dog3_CheckedChanged(object sender, EventArgs e)
        {
            if (sl_dog3.Checked == true)
            {
                Dog = 3;
            }
            sl_dog1.Checked = false;
            sl_dog2.Checked = false;
            sl_dog4.Checked = false;

        }

        private void sl_dog4_CheckedChanged(object sender, EventArgs e)
        {
            if (sl_dog4.Checked == true)
            {
                Dog = 4;
            }
            sl_dog1.Checked = false;
            sl_dog2.Checked = false;
            sl_dog3.Checked = false;

        }

        private void btn_lock_Click(object sender, EventArgs e)
        {
            //the whole code is used to check the setup of the race and the account buget of the player also 
            if (PlayerName.Equals("Jagroop") && Dog > 0 && !betAmountCB.Text.Equals(""))
            {
                if (Convert.ToInt32(betAmountCB.SelectedItem.ToString()) <= better1)
                {
                    pl1_has.Text = "Jagroop Select Dog " + Dog + " with the Bet Amount of " + betAmountCB.SelectedItem.ToString() + " Dollar";
                    btn_run.Enabled = true;
                }
                else
                {
                    MessageBox.Show("You didn't have enough balance ");
                }
            }
            else if (PlayerName.Equals("Ranjeet") && Dog > 0 && !betAmountCB.Text.Equals(""))
            {
                if (Convert.ToInt32(betAmountCB.SelectedItem.ToString()) <= better3)
                {
                    pl3_has.Text = "Ranjeet Select Dog " + Dog + " with the Bet Amount of " + betAmountCB.SelectedItem.ToString() + " Dollar";
                    btn_run.Enabled = true;
                }
                else
                {
                    MessageBox.Show("You didn't have enough balance ");
                }
            }
            else if (PlayerName.Equals("Inder") && Dog > 0 && !betAmountCB.Text.Equals(""))
            {
                if (Convert.ToInt32(betAmountCB.SelectedItem.ToString()) <= better2)
                {
                    pl2_has.Text = "Inder Select Dog " + Dog + " with the Bet Amount of " + betAmountCB.SelectedItem.ToString() + " Dollar";
                    btn_run.Enabled = true;
                }
                else
                {
                    MessageBox.Show("You didn't have enough balance ");
                }
            }
            else {
                MessageBox.Show("Select the Dog and Player Name to Play in the Race ");
            }


            PlayerName = "";
            Dog = 0;


        }

        private void btn_run_Click(object sender, EventArgs e)
        {
            timer1.Enabled = true;
            timer1.Start();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {

            if (pictureBox1.Left > 550)
            {
                timer1.Enabled = false;
                timer1.Stop();
                MessageBox.Show("First Dog won the race ");
                winner = 1;
                resultAnnouncment();
            }

            else if (pictureBox2.Left > 550)
            {
                timer1.Enabled = false;
                timer1.Stop();
                MessageBox.Show("Second Dog won the race ");
                winner = 2;
                resultAnnouncment();
            }



            else if (pictureBox3.Left > 550)
            {
                timer1.Enabled = false;
                timer1.Stop();
                MessageBox.Show("Third Dog won the race ");
                winner = 3;
                resultAnnouncment();
            }

            else if (pictureBox4.Left > 550)
            {
                timer1.Enabled = false;
                timer1.Stop();
                MessageBox.Show("Fourth Dog won the race ");
                winner = 4;
                resultAnnouncment();
            }
            else {

            }

            pictureBox1.Left += bet.Dog_run();
            pictureBox2.Left += bet.Dog_run();
            pictureBox3.Left += bet.Dog_run();
            pictureBox4.Left += bet.Dog_run();



        }

        public void resultAnnouncment() {
            if (pl1_has.Text.Contains("Select")) {
                better1=bet.result(pl1_has.Text,winner,better1);
            }
            if (pl2_has.Text.Contains("Select"))
            {
                better2 = bet.result(pl2_has.Text, winner, better2);
            }
            if (pl3_has.Text.Contains("Select"))
            {
                better3 = bet.result(pl3_has.Text, winner, better3);
            }
            pl1_has.Text = "Jagroop has " + better1;
            pl2_has.Text = "Inder has " + better2;
            pl3_has.Text = "Ranjeet has " + better3;

            pictureBox1.Left = 0;
            pictureBox2.Left = 0;
            pictureBox3.Left = 0;
            pictureBox4.Left = 0;

            winner = 0;
            btn_run.Enabled = false;

        }
        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void pl_jagroop_CheckedChanged(object sender, EventArgs e)
        {
            if (pl_jagroop.Checked==true) {
                PlayerName = "Jagroop";
            }
            pl_ranjeet.Checked = false;
            pl_inder.Checked = false;
        }
    }
}
