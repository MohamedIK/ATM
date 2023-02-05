using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace ATM
{
    public partial class Withdraw : Form
    {
        public Withdraw()
        {
            InitializeComponent();
        }

        Main_Menu mainmenu = new Main_Menu(); // object from class main menu

        private void button3_Click(object sender, EventArgs e)
        {
            if(MyBalance.Balance < 3000) // if the users balance less than the amount that the user wants to withdraw
            {
                MessageBox.Show("Insufficient Funds", "Invalid Balance", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            else // if the previous condition is false
            {
                MyBalance.Balance -= 3000; //withdraw

                MessageBox.Show("Your Balance After Withdrawal Is " + MyBalance.Balance + " EGP", "Your Balance", MessageBoxButtons.OK);

                DialogResult dr; // indicate return value from a dialog box

                dr = MessageBox.Show("Do You Want To Do Another Thing ?", "", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (dr == DialogResult.Yes) // if the person clicked on yes from the message box written above , the user will be sent to the main menu
                {
                    this.Hide();
                    mainmenu.Show();
                }

                else
                {
                    MyBalance.Exit();
                }
            }

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button7_Click(object sender, EventArgs e)
        {
            MyBalance.Exit();
        }

        private void button6_Click(object sender, EventArgs e) // button that will go back to amin menu
        {
            this.Hide();
            mainmenu.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (MyBalance.Balance < 1000)
            {
                MessageBox.Show("Insufficient Funds", "Invalid Balance", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            else
            {
                MyBalance.Balance -= 1000;

                MessageBox.Show("Your Balance After Withdrawal Is " + MyBalance.Balance + " EGP", "Your Balance", MessageBoxButtons.OK);

                DialogResult dr;

                dr = MessageBox.Show("Do You Want To Do Another Thing ?", "", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (dr == DialogResult.Yes)
                {
                    Main_Menu main = new Main_Menu();
                    this.Hide();
                    main.Show();
                }

                else
                {
                    MyBalance.Exit();
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (MyBalance.Balance < 2000)
            {
                MessageBox.Show("Insufficient Funds", "Invalid Balance", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            else
            {
                MyBalance.Balance -= 2000;

                MessageBox.Show("Your Balance After Withdrawal Is " + MyBalance.Balance + " EGP", "Your Balance", MessageBoxButtons.OK);

                DialogResult dr;

                dr = MessageBox.Show("Do You Want To Do Another Thing ?", "", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (dr == DialogResult.Yes)
                {
                    this.Hide();
                    mainmenu.Show();
                }

                else
                {
                    MyBalance.Exit();
                }
            }

        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (MyBalance.Balance < 4000)
            {
                MessageBox.Show("Insufficient Funds", "Invalid Balance", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            else
            {
                MyBalance.Balance -= 4000;

                MessageBox.Show("Your Balance After Withdrawal Is " + MyBalance.Balance + " EGP", "Your Balance", MessageBoxButtons.OK);

                DialogResult dr;

                dr = MessageBox.Show("Do You Want To Do Another Thing ?", "", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (dr == DialogResult.Yes)
                {
                    this.Hide();
                    mainmenu.Show();
                }

                else
                {
                    MyBalance.Exit();
                }
            }
        }

        private void button5_Click(object sender, EventArgs e)  // button that will swtich to other withdraw form (if the user wants to withdraw an amout not listed in this form)
        {
            Other_Withdraw other = new Other_Withdraw();
            this.Hide();
            other.Show();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            if (MyBalance.Balance < 5000)
            {
                MessageBox.Show("Insufficient Funds", "Invalid Balance", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            else
            {
                MyBalance.Balance -= 5000;

                MessageBox.Show("Your Balance After Withdrawal Is " + MyBalance.Balance + " EGP", "Your Balance", MessageBoxButtons.OK);

                DialogResult dr;

                dr = MessageBox.Show("Do You Want To Do Another Thing ?", "", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (dr == DialogResult.Yes)
                {
                    this.Hide();
                    mainmenu.Show();
                }

                else
                {
                    MyBalance.Exit();
                }
            }
        }

        private void Withdraw_Load(object sender, EventArgs e)
        {
            ControlBox = false;
        }
    }
}
