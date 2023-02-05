using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace ATM
{
    public partial class Donate : Form
    {
        Donate_Cash doncash = new Donate_Cash();
        
        public Donate()
        {
            InitializeComponent();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            MyBalance.Exit();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Main_Menu MainMenu = new Main_Menu();
            this.Hide();
            MainMenu.Show();
        }

        private void button2_Click(object sender, EventArgs e) // the lines 34-35 / 40-41 / 46-47 / 52-53 will show donate cash form
        {
            this.Hide();
            doncash.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            doncash.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Hide();
            doncash.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Hide();
            doncash.Show();
        }

        private void Donate_Load(object sender, EventArgs e)
        {
            ControlBox = false;
        }
    }
}
