using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Main
{
    public partial class LoginForm : Form
    {
        private Game game;

        public LoginForm(Game game)
        {
            InitializeComponent();
            this.game = game;
        }

        private void loginButton_Click(object sender, EventArgs e)
        {
            string username = usernameTextBox.Text;
            string password = passwordTextBox.Text;
            /*
            if (game.LoginAccount(username, password))
            {
                this.Close();
            }
            else
            {
                MessageBox.Show("Неправильний логін або пароль.");
            }
            */
        }

        private void registerButton_Click(object sender, EventArgs e)
        {
            string username = usernameTextBox.Text;
            string password = passwordTextBox.Text;
            /*
            try
            {
                game.RegisterAccount(username, password);
                MessageBox.Show("Реєстрація успішна.");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            */
        }
    }

}
