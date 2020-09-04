using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace AppJournalisteClient
{
    // fenetre d'authentification qui achemine vers une deuxieme fenetre pour l'insertion des articles

    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void ValidationBtn_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(textBox1.Text) || string.IsNullOrEmpty(textBox2.Text))
            {
                MessageBox.Show("veuillez saisir votre nom et / ou votre mot de passe", "Message"
                   , MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if (textBox1.Text.Equals("mohamed") && textBox2.Text.Equals("abcd") || textBox1.Text.Equals("youssef") && textBox2.Text.Equals("efgh"))
            {
                MessageBox.Show("You have beeen successfully logged in", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Hide();
                Form2 f2 = new Form2();
                f2.Show();
            }
            else
            {
                MessageBox.Show("Your username or password is incorrect", "message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                textBox1.Text = "";
                textBox2.Text = "";
            }
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)13)
                textBox2.Focus();

        }

        private void textBox2_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)13)
                ValidationBtn.PerformClick();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
