using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ATM
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(textBox1.Text == "") //If the user didnt type anything
            {
                MessageBox.Show("Please Enter Your PIN", "No Input", MessageBoxButtons.OK, MessageBoxIcon.Error);
                textBox1.Clear(); //make the textbox empty
                textBox1.Focus(); //focus on the textbox to make the user enter the PIN again
            }

            else if (textBox1.Text.Length < 4) //If the user typed numbers less that 4 numbers
            {
                MessageBox.Show("PIN Must Be 4 Digits", "" , MessageBoxButtons.OK, MessageBoxIcon.Error);
                textBox1.Clear();
                textBox1.Focus();
            }

            else // 4 numbers are entered
            {
                Main_Menu MainMenu = new Main_Menu();
                this.Hide();
                MainMenu.Show(); // from line 36 to 38 : switch from login to main menu and hide login window
                MyBalance.Balance = MyBalance.GetBalance(); // call the method "GetBalance" form class "MyBalance"

            }
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar)) 
            {
                e.Handled = true;
            }

            //This condition make the user enter numbers only
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void Login_Load(object sender, EventArgs e)
        {
            ControlBox = false; // Disable control box
        }
    }
}

public static class MyBalance
{
    public static double Balance;
    public static double GetBalance()
    {
        Random rand = new Random(); // "Random" is a built-in class to generate a random number and i made an object from it called "rand" 

        Balance = rand.Next(1 , 1000001); // This will generate an integer number from 1 to one million (i am assuming different people will enter different PIN so they have their balance)

        return Convert.ToDouble(Balance); // convert the balance to double
    }

    public static void Exit() // A method that when the user exit the ATM the following messagebox will be displayed
    {
        MessageBox.Show("Thank You For Banking With Us", "Thank You", MessageBoxButtons.OK);
        Application.Exit(); // Function to stop the program
    }
}