using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
//On inclue la librairie
using Npgsql;
using NpgsqlTypes;

namespace projet_C_sharp
{
    public partial class Form1 : Form
    {
        string Conx = "Server=localhost;Port=5432;Database=bibliotheque;User Id=qvgdm;Password=qvgdm;";
        NpgsqlCommand MyCmd = null;
        NpgsqlConnection MyCnx = null;

        System.Media.SoundPlayer player = new System.Media.SoundPlayer();
        System.Media.SoundPlayer alarmefin = new System.Media.SoundPlayer();
        int value_son = 1;
        public Form1()
        {
            InitializeComponent();
            
            player.SoundLocation = "courtqvgdm.wav";
            alarmefin.SoundLocation = "alarmefin.wav";
            
        }

        public void lecture_BDD()
        {
            Random aleatoire = new Random();
            int numero = aleatoire.Next(6);

            DataTable MyData = new DataTable();
            NpgsqlDataAdapter da;
            MyCnx = new NpgsqlConnection(Conx);
            string select = "SELECT * FROM question WHERE id = 1";

            MyCnx.Open();

            NpgsqlCommand Cmd = new NpgsqlCommand(select, MyCnx);
            da = new NpgsqlDataAdapter(Cmd);

            da.Fill(MyData);
            question.DataSource = MyData;

            MyCnx.Close();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (value_son == 1) player.Play(); 
            panel_bonnechance.Visible = true;
            panel_bonnechance.Refresh();
            System.Threading.Thread.Sleep(2500);
            panel_bonnechance.Visible = false;
            aide.Visible = false;
            fermer_aide.Visible = false;
            menu.Visible = false;
            imagebox.Visible = false;
            jeu.Visible = true;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            aide.Visible = true;
            fermer_aide.Visible = true;
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void button8_Click(object sender, EventArgs e)
        {
            if (value_son == 1) alarmefin.Play();
            System.Threading.Thread.Sleep(800);
            DialogResult quitter = MessageBox.Show("Voulez-vous vraiment quitter l'application ?", "Fermeture de l'application", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (quitter == DialogResult.Yes)
            {
                Application.Exit();
            }
            else
            {
                
            }
            
        }

        private void button7_Click(object sender, EventArgs e)
        {
            DialogResult retour = MessageBox.Show("Voulez-vous vraiment retourner au menu ? \n Toute progression sera perdue.", "Retour au menu", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (retour == DialogResult.Yes)
            {
                jeu.Visible = false;
                menu.Visible = true;
                imagebox.Visible = true;
            }
            else
            {

            }
        }

        private void button4_Click(object sender, EventArgs e)
        {

        }

        private void button9_Click(object sender, EventArgs e)
        {
            aide.Visible = false;
            fermer_aide.Visible = false;
        }

        private void menu_Paint(object sender, PaintEventArgs e)
        {

        }

        private void img_qvgdm_Click(object sender, EventArgs e)
        {

        }

        private void titre_Click(object sender, EventArgs e)
        {

        }

        private void bonnechance_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
          
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
           if( value_son == 0)
            {
                value_son = 1;
                son.Image = new Bitmap("son.png");
            }
            else {
                value_son = 0;
                son.Image = new Bitmap("mute.png");
            }
            
        }

        private void question_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }
    }
}
