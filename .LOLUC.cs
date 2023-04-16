using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Threading;
using System.Windows.Forms;

namespace Autolog
{
    public partial class LOLUC : UserControl
    {

        GameLogin login = new GameLogin();
        public static bool noErrors = true;
        public List<string> SqlData(string acc, string db)
        {
            Encrypt en = new Encrypt();
            string conString = File.ReadAllText("C:\\Users\\tripp\\source\\repos\\Autolog\\Autolog\\conString.txt");

            MySqlConnection conn = new MySqlConnection(conString);

            string account = acc.ToString();

            try
            {
                conn.Open();


                string query = $"select* from UsernamePass where Username = '{ account }'";

                MySqlCommand cmd = new MySqlCommand(query, conn);

                MySqlDataReader reader = cmd.ExecuteReader();

                List<string> data = new List<string>();
                while (reader.Read())
                {
                    var UN = reader["Username"];
                    data.Add(UN.ToString());
                    var Pass = reader["Pass"];
                    data.Add(en.gamePassDecrypt(Pass.ToString()));
                }

                conn.Close();
                return data;
            }
            catch (Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message + "\n Please check your server connection settings");
                noErrors = false;
            }
            return null;
        }


        public void refreshUserNames()
        {

            while (true)
            {
                while (itemSelected)
                {
                    Thread.Sleep(250);
                }
                string db = File.ReadAllText("C:\\Users\\tripp\\source\\repos\\Autolog\\Autolog\\CurrentDatabase.txt");

                getLolValNames lv = new getLolValNames();
                List<string> usernames = lv.getUsernames(db);
                try
                {
                    listBox1.Invoke((MethodInvoker)(() => listBox1.Items.Clear()));
                    foreach (string un in usernames)
                    {
                        listBox1.Invoke((MethodInvoker)(() => listBox1.Items.Add(un)));
                    }
                    listBox1.Invoke((MethodInvoker)(() => listBox1.Height = 32 * usernames.Count()));

                    LoginBtn.Invoke((MethodInvoker)(() => AddAcc.Location = new Point(215, (269 + listBox1.Height - 32))));

                    RemoveAcc.Invoke((MethodInvoker)(() => RemoveAcc.Location = new Point(69, (269 + listBox1.Height - 32))));

                }
                catch (Exception ex){

                }
                Thread.Sleep(250);

            }
        }

        public void initialize()
        {
            string db = File.ReadAllText("C:\\Users\\tripp\\source\\repos\\Autolog\\Autolog\\CurrentDatabase.txt");
            addAccount1.Hide();
            listBox1.Items.Clear();
            getLolValNames lv = new getLolValNames();
            List<string> usernames = lv.getUsernames(db);
            foreach (string un in usernames)
            {
                listBox1.Items.Add(un);
            }
            listBox1.Height = 32 * usernames.Count();
            AddAcc.Location = new Point(215, (269 + listBox1.Height - 32));
            RemoveAcc.Location = new Point(69, (269 + listBox1.Height - 32));
        }

        public LOLUC()
        {
            InitializeComponent();

            Thread accountRefresh = new Thread(refreshUserNames)
            {
                IsBackground = true
            };
            accountRefresh.Start();
            addAccount1.Hide();

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }




        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }

        public static bool itemSelected = false;
        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listBox1.SelectedIndex != -1)
            {
                itemSelected = true;
            }
            
        }

        private void LoginBtn_Click(object sender, EventArgs e)
        {
            login.login(listBox1.SelectedItem.ToString(), checkBox1.Checked);
        }

        private void AddAcc_Click(object sender, EventArgs e)
        {
            addAccount1.Show();
            listBox1.ClearSelected();

        }

        private void RemoveAcc_Click(object sender, EventArgs e)
        {

            insertData remove = new insertData();
            DialogResult result;
            if (listBox1.SelectedItem != null)
            {


                result = System.Windows.Forms.MessageBox.Show("Are you sure you want to delete this account?", null, System.Windows.Forms.MessageBoxButtons.YesNo);
                if (result == System.Windows.Forms.DialogResult.Yes)
                {

                    remove.RemoveAcc(listBox1.SelectedItem.ToString());

                }
            }

        }
        private void pictureBox1_Click(object sender, EventArgs e)
        {
            initialize();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            Hide();
        }
    }
}
