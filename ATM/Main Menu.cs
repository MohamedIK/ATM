using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace ATM
{
    public partial class Main_Menu : Form
    {
        public Main_Menu()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e) // button that will show the balance
        {
            MessageBox.Show("Your Balance is " + MyBalance.Balance + " EGP", "Your Balance", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void button1_Click(object sender, EventArgs e) // button that will swtich to withdraw form
        {
            Withdraw with = new Withdraw();
            this.Hide();
            with.Show();
        }

        private void button5_Click(object sender, EventArgs e) // using exit method from class "MyBalance"
        {
            MyBalance.Exit();
        }

        private void Main_Menu_Load(object sender, EventArgs e)
        {
            ControlBox = false;
        }

        private void button2_Click(object sender, EventArgs e) // button that will swtich to deposit form
        {
            Deposit dep = new Deposit();
            this.Hide();
            dep.Show();
        }

        private void button4_Click(object sender, EventArgs e) // button that will swtich to donate form
        {
            Donate don = new Donate();
            this.Hide();
            don.Show();
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {

        }
    }
}
