using MySql.Data.MySqlClient;
using System;

namespace Autolog
{
    class CheckLogin
    {


        public bool SelectData(string userInsert, string passInsert)
        {
            string conString = "SERVER= localhost;DATABASE=lol_val;UID=root;PASSWORD=mason123;";

            MySqlConnection conn = new MySqlConnection(conString);



            conn.Open();
            try
            {

                MySqlCommand command = new MySqlCommand();
                command.Connection = conn;
                command.CommandText = ("Select * from login where (userName, Pass) = (@name, @password)");
                command.Parameters.AddWithValue("@name", userInsert);
                command.Parameters.AddWithValue("@password", Encrypt.HashString(passInsert));

                MySqlDataReader reader = command.ExecuteReader();

                if (reader.Read())
                {
                    Encrypt.MasterPass = passInsert;
                    return true;
                    
                }
                else
                {
                    System.Windows.Forms.MessageBox.Show("Your username or password was not valid. Please try again", "Information", System.Windows.Forms.MessageBoxButtons.OK, System.Windows.Forms.MessageBoxIcon.Error);
                    return false;
                }


            }
            catch (Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message, "Information", System.Windows.Forms.MessageBoxButtons.OK, System.Windows.Forms.MessageBoxIcon.Warning);
                return false;
            }
            finally
            {
                conn.Close();
            }

        }
    }
}