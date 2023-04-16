using System;
using System.IO;
using System.Threading;
using System.Windows.Forms;

namespace Autolog
{
    public partial class AddAccount : UserControl
    {
        public void emailOrNot()
        {
            while (true)
            {
                try
                {
                    string cg = File.ReadAllText("C:\\Users\\tripp\\source\\repos\\Autolog\\Autolog\\CurrentGame.txt");
                    Thread.Sleep(1500);
                    if (cg == "r6" || cg == "fort")
                    {
                        UsernameLabel.Invoke((MethodInvoker)(() => UsernameLabel.Text = "Email Address"));
                    }
                    else
                    {
                        UsernameLabel.Invoke((MethodInvoker)(() => UsernameLabel.Text = "Username"));
                    }
                }
                catch (Exception ex)
                {

                }
            }

        }
        public AddAccount()
        {
            InitializeComponent();

            Thread email = new Thread(emailOrNot);
            email.IsBackground = true;
            email.Start();

        }

        private void UserTxt_TextChanged(object sender, EventArgs e)
        {

        }

        private void PassTxt_TextChanged(object sender, EventArgs e)
        {

        }

        private void AddAcc_Click(object sender, EventArgs e)
        {

            insertData add = new insertData();
            string db = File.ReadAllText("C:\\Users\\tripp\\source\\repos\\Autolog\\Autolog\\CurrentDatabase.txt");
            add.AddAcc(UserTxt.Text, PassTxt.Text);
            Hide();

            PassTxt.Clear();


        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            Hide();
        }

        private void AddAccount_Load(object sender, EventArgs e)
        {

        }
    }
}
