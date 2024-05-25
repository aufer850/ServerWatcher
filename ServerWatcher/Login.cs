using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;

namespace ServerWatcher
{
    
    public partial class Login : Form
    {
        public static string Amogus;
        
        public Login()
        {
            
            InitializeComponent();
        }
        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            // читання файлу з паролем
            DataSet ds = new DataSet();
            ds.ReadXml("pswd.xml");
            // перевірка, чи підходить логін та пароль до одного з користувачів
            foreach (DataRow item in ds.Tables["User"].Rows)
            {
                string Name = item["Name"].ToString();
                string Pass = item[0].ToString();
                string Ad = item[1].ToString();
                if (string.Equals(Name,UserLogin.Text))
                {
                    if (string.Equals(Pass,Password.Text))
                    {                        
                        // відкриття програми
                        ServerWatcherform F1 = new ServerWatcherform(Name, Ad);
                        F1.Show();
                        // Закриття вікна логіну
                        this.Hide();
                        return;
                    }
                }
            }
            MessageBox.Show("Неправильний логін або пароль","Помилка!");
        }

        private void Login_Load(object sender, EventArgs e)
        {

        }


    }

}
