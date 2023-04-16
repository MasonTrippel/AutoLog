using System;
using System.IO;
using System.Windows.Forms;

namespace Autolog
{
    public partial class serverChange : UserControl
    {
        public serverChange()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void serverAddress_TextChanged(object sender, EventArgs e)
        {

        }

        private void serverUsername_TextChanged(object sender, EventArgs e)
        {

        }

        private void serverPassword_TextChanged(object sender, EventArgs e)
        {

        }

        private void serverDatabase_TextChanged(object sender, EventArgs e)
        {

        }

        private void LoginBtn_Click(object sender, EventArgs e)
        {

            File.WriteAllText("C:\\Users\\tripp\\source\\repos\\Autolog\\Autolog\\conString.txt", "Server=" + serverAddress.Text + ";Port=" + serverPort.Text + ";Database=" + serverDatabase.Text + ";Uid=" + serverUsername.Text + ";Pwd=" + serverPassword.Text + ";");
            insertData ins = new insertData();
            if (ins.serverTest())
            {
                //File.Delete("C:\\Users\\tripp\\source\\repos\\Autolog\\Autolog\\firstTime.txt");
                Hide();
            }
            else
            {
                System.Windows.Forms.MessageBox.Show("The server information you entered was not valid please try again", "Information", System.Windows.Forms.MessageBoxButtons.OK, System.Windows.Forms.MessageBoxIcon.Error);

            }

        }
    }
}
