using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.IO;

namespace Autolog
{
    public class getLolValNames
    {

        public List<string> getUsernames(string db)
        {
            string conString = File.ReadAllText("C:\\Users\\tripp\\source\\repos\\Autolog\\Autolog\\conString.txt");

            MySqlConnection conn = new MySqlConnection(conString);


            List<string> usernames = new List<string>();
            conn.Open();
            conn.ChangeDatabase(Form1.database);
            try
            {

                MySqlCommand command = new MySqlCommand();
                command.Connection = conn;
                command.CommandText = ("Select username from usernamepass");


                MySqlDataReader reader = command.ExecuteReader();

                while (reader.Read())
                {

                    usernames.Add(reader.GetValue(0).ToString());

                }


                conn.Close();
                return usernames;


            }
            catch (Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message, "Information", System.Windows.Forms.MessageBoxButtons.OK, System.Windows.Forms.MessageBoxIcon.Warning);
                return null;
            }
            finally
            {
                conn.Close();
            }

        }


    }
}

