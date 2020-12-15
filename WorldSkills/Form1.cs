using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WorldSkills
{
    public partial class Form1 : Form
    {
        DataBase dataBase;
        public Form1()
        {
            InitializeComponent();
            dataBase = new DataBase("Server=localhost\\SQLEXPRESS;Database=WorldSkills;Trusted_Connection=True;");
        }

        private void Sign_In_Click(object sender, EventArgs e)
        {
            Login login = new Login(dataBase);

            if (login.UserLogin(login_text.Text, password_text.Text))
                MessageBox.Show("Вы вошли в аккаунт!");
            else
                MessageBox.Show("Логин или пароль не верны!");
        }
    }
}
