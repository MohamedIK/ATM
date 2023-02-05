using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace ATM
{
    public partial class Deposit : Form
    {
        public Deposit()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            MyBalance.Exit();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Main_Menu MainMenu = new Main_Menu();
            this.Hide();
            MainMenu.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "")
            {
                MessageBox.Show("Please Enter A Number", "No Input", MessageBoxButtons.OK, MessageBoxIcon.Error);
                textBox1.Focus();
            }

            else
            {
                MyBalance.Balance += int.Parse(textBox1.Text);

                MessageBox.Show("Your Balance After Deposit is " + MyBalance.Balance + " EGP", "Your Balance", MessageBoxButtons.OK, MessageBoxIcon.Information);

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

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void label2_Click(object sender, EventArgs e)
        {
            label2.Text = "Your Balance Is " + MyBalance.Balance + " EGP";
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void checkBox3_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void checkBox4_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void Deposit_Load(object sender, EventArgs e)
        {

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
                label2.Visible = true;
                label2.Text = "Your Balance Is " + MyBalance.Balance + " EGP";
            }

            else
            {
                label2.Visible = false;
            }
        }

        private void Deposit_Load_1(object sender, EventArgs e)
        {
            ControlBox = false;
        }
    }
}
