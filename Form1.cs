using System;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace Autolog
{

    public partial class Form1 : Form
    {


        private void setButtonColors()
        {
            Val_btn.BackColor = Color.FromArgb(192, 0, 0);
            LOL_btn.BackColor = Color.FromArgb(192, 0, 0);
            R6_btn.BackColor = Color.FromArgb(192, 0, 0);
            Chrome_btn.BackColor = Color.FromArgb(192, 0, 0);
            Spot_btn.BackColor = Color.FromArgb(192, 0, 0);
            Fort_btn.BackColor = Color.FromArgb(192, 0, 0);
            MW_btn.BackColor = Color.FromArgb(192, 0, 0);
        }




        public Form1()
        {
            InitializeComponent();
            loluc1.Hide();



            userControl11.Show();



        }

        public static string database = File.ReadAllText("C:\\Users\\tripp\\source\\repos\\Autolog\\Autolog\\CurrentDatabase.txt");
        private void button1_Click(object sender, EventArgs e)
        {
            LOLUC.itemSelected = false;
            setButtonColors();
            LOL_btn.BackColor = Color.FromArgb(255, 40, 40);
            loluc1.Show();
            File.WriteAllText("C:\\Users\\tripp\\source\\repos\\Autolog\\Autolog\\CurrentGame.txt", "lol");
            //File.WriteAllText("C:\\Users\\tripp\\source\\repos\\Autolog\\Autolog\\CurrentDatabase.txt", "lol_val");
            database = "lol_val";

        }

        private void Val_btn_Click_1(object sender, EventArgs e)
        {
            LOLUC.itemSelected = false;
            setButtonColors();
            Val_btn.BackColor = Color.FromArgb(255, 40, 30);


            loluc1.Show();

            File.WriteAllText("C:\\Users\\tripp\\source\\repos\\Autolog\\Autolog\\CurrentGame.txt", "val");
            //File.WriteAllText("C:\\Users\\tripp\\source\\repos\\Autolog\\Autolog\\CurrentDatabase.txt", "lol_val");
            database = "lol_val";
        }


        private void R6_btn_Click(object sender, EventArgs e)
        {
            LOLUC.itemSelected = false;
            setButtonColors();
            R6_btn.BackColor = Color.FromArgb(255, 40, 30);

            //File.WriteAllText("C:\\Users\\tripp\\source\\repos\\Autolog\\Autolog\\CurrentDatabase.txt", "r6");
            File.WriteAllText("C:\\Users\\tripp\\source\\repos\\Autolog\\Autolog\\CurrentGame.txt", "r6");
            database = "r6";
            loluc1.Show();
        }



        private void MW_btn_Click(object sender, EventArgs e)
        {
            LOLUC.itemSelected = false;
            setButtonColors();
            MW_btn.BackColor = Color.FromArgb(255, 40, 30);
            File.WriteAllText("C:\\Users\\tripp\\source\\repos\\Autolog\\Autolog\\CurrentGame.txt", "mw");
            //File.WriteAllText("C:\\Users\\tripp\\source\\repos\\Autolog\\Autolog\\CurrentDatabase.txt", "mw");
            database = "mw";


        }

        private void Fort_btn_Click(object sender, EventArgs e)
        {
            LOLUC.itemSelected = false;
            setButtonColors();
            Fort_btn.BackColor = Color.FromArgb(255, 40, 30);
            File.WriteAllText("C:\\Users\\tripp\\source\\repos\\Autolog\\Autolog\\CurrentGame.txt", "fort");
            // File.WriteAllText("C:\\Users\\tripp\\source\\repos\\Autolog\\Autolog\\CurrentDatabase.txt", "fort");
            database = "fort";
            Process.Start("C:\\Program Files (x86)\\Epic Games\\Launcher\\Engine\\Binaries\\Win64\\EpicGamesLauncher.exe");

        }

        private void Spot_btn_Click(object sender, EventArgs e)
        {
            LOLUC.itemSelected = false;
            loluc1.Hide();
            setButtonColors();
            Spot_btn.BackColor = Color.FromArgb(255, 40, 30);
            Process.Start("C:\\Users\\tripp\\AppData\\Local\\Microsoft\\WindowsApps\\Spotify.exe");
        }

        private void Chrome_btn_Click(object sender, EventArgs e)
        {
            LOLUC.itemSelected = false;
            loluc1.Hide();
            setButtonColors();
            Chrome_btn.BackColor = Color.FromArgb(255, 40, 30);
            Process.Start("C:\\Program Files\\Google\\Chrome\\Application\\chrome.exe");
        }
        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void lol_Val_UC1_Load_1(object sender, EventArgs e)
        {

        }

        private void lol_Val_UC1_Load(object sender, EventArgs e)
        {

        }

        private void loluc1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            loluc1.Hide();

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void register1_Load(object sender, EventArgs e)
        {

        }

        private void userControl11_Load(object sender, EventArgs e)
        {

        }

        private void userControl11_Load_1(object sender, EventArgs e)
        {

        }
    }
}
