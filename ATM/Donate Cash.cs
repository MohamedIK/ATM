using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace ATM
{
    public partial class Donate_Cash : Form
    {
        public Donate_Cash()
        {
            InitializeComponent();
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
                MyBalance.Balance -= double.Parse(textBox1.Text);

                MessageBox.Show("Thank You For Your Donation" + "\n" + "Your Balance After Donation Is " + MyBalance.Balance + " EGP", "Your Balance", MessageBoxButtons.OK, MessageBoxIcon.Information);

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

        private void button2_Click(object sender, EventArgs e) // go back to donate form
        {
            Donate don = new Donate();
            this.Hide();
            don.Show();
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && e.KeyChar != '.') // the user will enter numbers and one decimal point only
            {
                e.Handled = true;
            }

            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1)) // checks the decimal point is only one
            {
                e.Handled = true;
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            MyBalance.Exit();
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
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

        private void Donate_Cash_Load(object sender, EventArgs e)
        {
            ControlBox = false;
        }
    }
}
