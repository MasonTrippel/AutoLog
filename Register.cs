using System;
using System.Windows.Forms;

namespace Autolog
{
    public partial class Register : UserControl
    {
        insertData insert = new insertData();
        public Register()
        {
            InitializeComponent();
        }
        bool LoginIsSecure()
        {
            bool PassLength = false;
            bool PassNum = false;
            if (PassTxt.Text.Length > 7)
            {
                PassLength = true;
            }

            foreach (char c in PassTxt.Text)
            {

                if (int.TryParse(c.ToString(), out _))
                {
                    PassNum = true;
                }
                else
                {
                    PassNum = false;
                }
            }
            if (PassTxt.Text == PassConfirmTxt.Text && PassLength && PassNum)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        private void UserTxt_TextChanged(object sender, EventArgs e)
        {

        }

        private void PassTxt_TextChanged(object sender, EventArgs e)
        {

        }

        private void PassConfirmTxt_TextChanged(object sender, EventArgs e)
        {

        }

        private void RegisterBtn_Click(object sender, EventArgs e)
        {
            string date = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss");


            if (LoginIsSecure())
            {
                insert.InsertData(UserTxt.Text, PassTxt.Text, date);
                MessageBox.Show("Acount Successfully Created");


            }
            else if (!LoginIsSecure())
            {
                MessageBox.Show("Invalid Password.Password must be at least 8 characters long and contain at least one number.");
            }

        }

        private void RegisterBtn_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyValue == ((int)Keys.Enter))
            {
                RegisterBtn_Click(null, null);
            }
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            Hide();
        }
    }
}
