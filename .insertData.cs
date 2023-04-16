using MySql.Data.MySqlClient;
using System;
using System.IO;

namespace Autolog
{
    class insertData
    {

        public string InsertData(string User, string Pass, string insertDateTime)
        {


            string conString = File.ReadAllText("C:\\Users\\tripp\\source\\repos\\Autolog\\Autolog\\conString.txt");
            MySqlConnection con = new MySqlConnection(conString);
            Encrypt en = new Encrypt();
            con.ChangeDatabase(File.ReadAllText("C:\\Users\\tripp\\source\\repos\\Autolog\\Autolog\\CurrentDatabase.txt"));
            try
            {
                con.Open();
                con.ChangeDatabase(Form1.database);
                MySqlCommand command = new MySqlCommand();
                command.Connection = con;
                command.CommandText = "INSERT INTO login(userName,Pass,Registered) VALUES (@name, @password, @datetime)";
                command.Parameters.AddWithValue("@name", User);
                command.Parameters.AddWithValue("@password", Encrypt.HashString(Pass));
                command.Parameters.AddWithValue("@datetime", insertDateTime);
                command.ExecuteNonQuery();
                con.Close();
                return User + Pass + insertDateTime;

            }
            catch (Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
                return null;
            }
            finally
            {
                con.Close();
            }


        }
        public void AddAcc(string User, string Pass)
        {

            string conString = File.ReadAllText("C:\\Users\\tripp\\source\\repos\\Autolog\\Autolog\\conString.txt");
            MySqlConnection con = new MySqlConnection(conString);
            Encrypt en = new Encrypt();

            try
            {
                con.Open();
                con.ChangeDatabase(Form1.database);
                MySqlCommand command = new MySqlCommand();
                command.Connection = con;
                command.CommandText = "INSERT INTO usernamepass(Username,Pass) VALUES (@name, @password)";
                command.Parameters.AddWithValue("@name", User);
                command.Parameters.AddWithValue("@password", en.gameHashString(Pass));

                command.ExecuteNonQuery();
                con.Close();

            }
            catch (Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message + "\n Please check your server connection settings");

            }
            finally
            {
                con.Close();
            }
        }
        public void RemoveAcc(string acc)
        {
            string conString = File.ReadAllText("C:\\Users\\tripp\\source\\repos\\Autolog\\Autolog\\conString.txt");
            MySqlConnection con = new MySqlConnection(conString);
            Encrypt en = new Encrypt();

            try
            {
                con.Open();
                con.ChangeDatabase(Form1.database);
                MySqlCommand command = new MySqlCommand();
                command.Connection = con;
                command.CommandText = "DELETE FROM usernamepass WHERE Username = @acc";
                command.Parameters.AddWithValue("@acc", acc);
                command.ExecuteNonQuery();


                con.Close();

            }
            catch (Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);

            }
            finally
            {
                con.Close();
            }
        }
        public bool serverTest()
        {
            string conString = File.ReadAllText("C:\\Users\\tripp\\source\\repos\\Autolog\\Autolog\\conString.txt");



            try
            {
                MySqlConnection conn = new MySqlConnection(conString);
                conn.Open();
                return true;
            }
            catch (Exception)
            {
                return false;
            }


        }

    }
}
