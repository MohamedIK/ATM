using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace ATM
{
    public partial class Other_Withdraw : Form
    {
        public Other_Withdraw()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            MyBalance.Exit();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Withdraw with = new Withdraw();
            this.Hide();
            with.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "")
            {
                MessageBox.Show("Please Enter A Number", "No Input", MessageBoxButtons.OK, MessageBoxIcon.Error);
                textBox1.Focus();
            }

            else if (double.Parse(textBox1.Text) > MyBalance.Balance)
            {
                MessageBox.Show("Insufficient Funds", "Invalid Balance", MessageBoxButtons.OK, MessageBoxIcon.Error);
                textBox1.Clear();
                textBox1.Focus();
            }

            else
            {
                MyBalance.Balance -= int.Parse(textBox1.Text);

                MessageBox.Show("Your Balance After Withdrawal Is " + MyBalance.Balance + " EGP", "Your Balance", MessageBoxButtons.OK, MessageBoxIcon.Information);

                DialogResult dr;

                dr = MessageBox.Show("Do You Want To Do Another Thing ?", "" , MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if(dr == DialogResult.Yes)
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

        private void label2_Click(object sender, EventArgs e)
        {
            
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void Other_Withdraw_Load(object sender, EventArgs e)
        {
            ControlBox = false;
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click_1(object sender, EventArgs e) // label that show the users balance
        {
            label2.Text = "Your Balance Is " + MyBalance.Balance + "EGP";
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e) // checkbox that checks if the user want to see his/her balance or not
        {
            if (checkBox1.Checked)
            {
                label2.Visible = true;
                label2.Text = "Your balance Is " + MyBalance.Balance + " EGP";
            }

            else
            {
                label2.Visible = false;
            }
        }
    }
}
