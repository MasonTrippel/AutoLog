using System;
using System.IO;
using System.Windows.Forms;

namespace Autolog
{

    public partial class UserControl1 : UserControl
    {
        CheckLogin cl = new CheckLogin();

        public UserControl1()
        {
            InitializeComponent();
            File.WriteAllText("C:\\Users\\tripp\\source\\repos\\Autolog\\Autolog\\conString.txt", "Server=localhost;Port=3306;Database=lol_val;Uid=root;Pwd=mason123;");
            register1.Hide();
            button1.Hide();

            if (File.Exists("C:\\Users\\tripp\\source\\repos\\Autolog\\Autolog\\firstTime.txt"))
            {
                serverChange1.Show();
            }
            else
            {
                serverChange1.Hide();
            }

        }

        public void r1Hide()
        {
            register1.Hide();
        }


        private void label1_Click(object sender, EventArgs e)
        {

        }

        //username
        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
        //password
        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }
        //login
        private void button1_Click(object sender, EventArgs e)
        {
            string conString = File.ReadAllText("C:\\Users\\tripp\\source\\repos\\Autolog\\Autolog\\conString.txt");
            if (cl.SelectData(UserTxt.Text, PassTxt.Text))
            {
                Hide();

                Encrypt.MasterPass = PassTxt.Text;
                UserTxt.Clear();
                PassTxt.Clear();
            }
            else
            {
                UserTxt.Clear();
                PassTxt.Clear();
            }


        }
        //register
        private void RegisterBtn_Click(object sender, EventArgs e)
        {
            register1.Show();
            button1.Show();
            button1.BringToFront();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            register1.Hide();
            button1.Hide();
        }

        private void textBox1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Control)
            {
                if (e.KeyCode == Keys.Back)
                {

                    UserTxt.Clear();

                    SendKeys.Send("{BS}");

                }

            }
            if (e.KeyCode == Keys.Enter)
            {

                if (cl.SelectData(UserTxt.Text, PassTxt.Text))
                {
                    Encrypt.MasterPass = PassTxt.Text;
                    button1_Click(this, null);

                }
                else
                {
                    UserTxt.Clear();
                    PassTxt.Clear();
                }
            }


        }

        private void textBox2_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Control)
            {
                if (e.KeyCode == Keys.Back)
                {
                    PassTxt.Clear();

                    SendKeys.Send("{BS}");
                }

            }
            if (e.KeyCode == Keys.Enter)
            {

                if (cl.SelectData(UserTxt.Text, PassTxt.Text))
                {
                    Hide();

                }
                else
                {
                    UserTxt.Clear();
                    PassTxt.Clear();
                }
            }

        }




        private void UserControl1_KeyDown(object sender, KeyEventArgs e)
        {

        }

        private void serverChange1_Load(object sender, EventArgs e)
        {

        }
    }
}
