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
        int avancement = 0;
        int euros = 0;
        int eurosstop;
        int q = 1;
        int temp = 0;
        int[] generer = new int[17];
        
        string Conx = "Server=localhost;Port=5432;Database=bibliotheque;User Id=qvgdm;Password=qvgdm;";
        NpgsqlCommand MyCmd = null;
        NpgsqlConnection MyCnx = null;

        System.Media.SoundPlayer player = new System.Media.SoundPlayer();
        System.Media.SoundPlayer alarmefin = new System.Media.SoundPlayer();
        System.Media.SoundPlayer victoire = new System.Media.SoundPlayer();
        System.Media.SoundPlayer perdu = new System.Media.SoundPlayer();
        int value_son = 1;

        public Form1()
        {
            InitializeComponent();

            System.Drawing.Text.PrivateFontCollection pfc = new System.Drawing.Text.PrivateFontCollection();
            pfc.AddFontFile("OPTICopperplate.otf");
            titre.Font = new Font(pfc.Families[0], 15, FontStyle.Regular);
            label5.Font = new Font(pfc.Families[0], 15, FontStyle.Regular);

            player.SoundLocation = "courtqvgdm.wav";
            alarmefin.SoundLocation = "alarmefin.wav";
            victoire.SoundLocation = "victoire.wav";
            perdu.SoundLocation = "perdu.wav";
        }

        public bool verification_reponse(int num, int i) {
            bool a = false;

            DataTable MyData = new DataTable();
            NpgsqlDataAdapter da;
            MyCnx = new NpgsqlConnection(Conx);
            string select = "Select reponse.type_rep,reponse.nom,question.nom from question FULL JOIN reponse ON question.id=reponse.question WHERE id =" + num + ";";

            MyCnx.Open();

            NpgsqlCommand Cmd = new NpgsqlCommand(select, MyCnx);
            da = new NpgsqlDataAdapter(Cmd);
         
            da.Fill(MyData);
            question.DataSource = MyData;
            a = (bool)question[0, i].Value;
            //MessageBox.Show(a); test

            MyCnx.Close();
            return a;
        }
        public string lecture_BDD_reponse4(int num)
        {
            string a = "yupnon";
            Random aleatoire = new Random();
            int numero = aleatoire.Next(28);

            DataTable MyData = new DataTable();
            NpgsqlDataAdapter da;
            MyCnx = new NpgsqlConnection(Conx);
            string select = "Select reponse.nom,question.nom from question FULL JOIN reponse ON question.id=reponse.question WHERE id =" + num + ";";

            MyCnx.Open();

            NpgsqlCommand Cmd = new NpgsqlCommand(select, MyCnx);
            da = new NpgsqlDataAdapter(Cmd);
            
            da.Fill(MyData);
            question.DataSource = MyData;
            a = (String)question[0, 3].Value;

            MyCnx.Close();
            return a;
        }
        public string lecture_BDD_reponse3(int num)
        {
            string a = "yupnon";
            Random aleatoire = new Random();
            int numero = aleatoire.Next(28);

            DataTable MyData = new DataTable();
            NpgsqlDataAdapter da;
            MyCnx = new NpgsqlConnection(Conx);
            string select = "Select reponse.nom,question.nom from question FULL JOIN reponse ON question.id=reponse.question WHERE id =" + num + ";";

            MyCnx.Open();

            NpgsqlCommand Cmd = new NpgsqlCommand(select, MyCnx);
            da = new NpgsqlDataAdapter(Cmd);
            
            da.Fill(MyData);
            question.DataSource = MyData;
            a = (String)question[0, 2].Value;

            MyCnx.Close();
            return a;
        }
        public string lecture_BDD_reponse2(int num)
        {
            string a = "yupnon";
            Random aleatoire = new Random();
            int numero = aleatoire.Next(28);

            DataTable MyData = new DataTable();
            NpgsqlDataAdapter da;
            MyCnx = new NpgsqlConnection(Conx);
            string select = "Select reponse.nom,question.nom from question FULL JOIN reponse ON question.id=reponse.question WHERE id =" + num + ";";

            MyCnx.Open();

            NpgsqlCommand Cmd = new NpgsqlCommand(select, MyCnx);
            da = new NpgsqlDataAdapter(Cmd);
            
            da.Fill(MyData);
            question.DataSource = MyData;
            a = (String)question[0, 1].Value;

            MyCnx.Close();
            return a;
        }
        public string lecture_BDD_reponse1(int num)
        {
            string a = "yupnon";
            Random aleatoire = new Random();
            int numero = aleatoire.Next(28);

            DataTable MyData = new DataTable();
            NpgsqlDataAdapter da;
            MyCnx = new NpgsqlConnection(Conx);
            string select = "Select reponse.nom,question.nom from question FULL JOIN reponse ON question.id=reponse.question WHERE id =" + num + ";";

            MyCnx.Open();

            NpgsqlCommand Cmd = new NpgsqlCommand(select, MyCnx);
            da = new NpgsqlDataAdapter(Cmd);
            
            da.Fill(MyData);
            question.DataSource = MyData;
            a = (String)question[0, 0].Value;

            MyCnx.Close();
            return a;
        }


        public string lecture_BDD(int num)
        {
            string a = "yupnon";
            Random aleatoire = new Random();
            int numero = aleatoire.Next(28);

            DataTable MyData = new DataTable();
            NpgsqlDataAdapter da;
            MyCnx = new NpgsqlConnection(Conx);
            string select = "Select reponse.nom,question.nom from question FULL JOIN reponse ON question.id=reponse.question WHERE id =" + num + ";";

            MyCnx.Open();

            NpgsqlCommand Cmd = new NpgsqlCommand(select, MyCnx);
            da = new NpgsqlDataAdapter(Cmd);
            
            da.Fill(MyData);
            question.DataSource = MyData;
            a = (String)question[1, 1].Value;

            MyCnx.Close();
            return a;
        }

        public void switcheuros()
        {
            q = barre_progression.Value;
            switch (barre_progression.Value)
            {
                case 1: { euros = 200; break; }
                case 2: { euros = 300; break; }
                case 3: { euros = 500; break; }
                case 4: { euros = 800; break; }
                case 5: { euros = 1500; break; }
                case 6: { euros = 3000; break; }
                case 7: { euros = 6000; break; }
                case 8: { euros = 12000; break; }
                case 9: { euros = 24000; break; }
                case 10: { euros = 48000; break; }
                case 11: { euros = 72000; break; }
                case 12: { euros = 100000; break; }
                case 13: { euros = 150000; break; }
                case 14: { euros = 300000; break; }
                case 15: { euros = 1000000; break; }
            }
        }
        public void switcheurosstop()
        {
            switch (barre_progression.Value)
            {
                case 1: { eurosstop = 0; break; }
                case 2: { eurosstop = 200; break; }
                case 3: { eurosstop = 300; break; }
                case 4: { eurosstop = 500; break; }
                case 5: { eurosstop = 800; break; }
                case 6: { eurosstop = 1500; break; }
                case 7: { eurosstop = 3000; break; }
                case 8: { eurosstop = 6000; break; }
                case 9: { eurosstop = 12000; break; }
                case 10: { eurosstop = 24000; break; }
                case 11: { eurosstop = 48000; break; }
                case 12: { eurosstop = 72000; break; }
                case 13: { eurosstop = 100000; break; }
                case 14: { eurosstop = 150000; break; }
                case 15: { eurosstop = 300000; break; }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Random r = new Random();
            for (int i = 0; i < generer.Length; i++)
            {
                //genere un nombre
                generer[i] = r.Next(28);
                generer[i] = generer[i] + 1;

                int double_ = 0;

                while (double_ != 1)
                {
                    generer[i] = r.Next(28);
                    generer[i] = generer[i] + 1;
                    double_ = 0;
                    for (int j = 0; j < generer.Length; j++)
                    {
                        //on vérifie si il est en double 
                        if (generer[i] == generer[j])
                        {
                            double_ = double_ + 1;
                        }
                    }
                }
                Console.Write(generer[i]);
            }
            // gestion des affichages au lancement de la partie 
            if (value_son == 1) player.Play();
            victoirepanel.Visible = false;
            panel_bonnechance.Visible = true;
            aide.Visible = false;
            fermer_aide.Visible = false;
            menu.Visible = false;
            imagebox.Visible = false;
            panel_bonnechance.Refresh();
            System.Threading.Thread.Sleep(2500);
            panel_bonnechance.Visible = false;
            panel_defaite.Visible = false;
            barre_progression.Value = 1;
            palier.Text = "";
            jokerswitch.Visible = false;
            jokermoitie.Visible = true;
            jokerpublic.Visible = true;
            button1.Visible = true;
            button2.Visible = true;
            button3.Visible = true;
            button4.Visible = true;
            jeu.Visible = true;
            switcheuros();
            infoquestion.Text="Vous jouez pour la question "+ q + " à "+ euros +"€.";
            //utilisation BDD
            Random aleatoire = new Random();
            int num = aleatoire.Next(28);
            num = num + 1;
            temp = 0;
            num = generer[0];
            
            string aa;
            aa = lecture_BDD(num);
            label3.Text = aa;
            aa = lecture_BDD_reponse1(num);
            button1.Text = aa;
            aa = lecture_BDD_reponse2(num);
            button2.Text = aa;
            aa = lecture_BDD_reponse3(num);
            button3.Text = aa;
            aa = lecture_BDD_reponse4(num);
            button4.Text = aa;

            progressBar1.Value = num;
            question.Visible = false;
        }

        public void lancer_question(int avancement)
        {
            Random aleatoire = new Random();
            int num = aleatoire.Next(28);
            temp = temp + 1;
            num = generer[temp];
            button1.Visible = true;
            button2.Visible = true;
            button3.Visible = true;
            button4.Visible = true;

            string aa;
            aa = lecture_BDD(num);
            label3.Text = aa;
            aa = lecture_BDD_reponse1(num);
            button1.Text = aa;
            aa = lecture_BDD_reponse2(num);
            button2.Text = aa;
            aa = lecture_BDD_reponse3(num);
            button3.Text = aa;
            aa = lecture_BDD_reponse4(num);
            button4.Text = aa;

            progressBar1.Value = num;
            question.Visible = false;
        }


        private void button2_Click(object sender, EventArgs e)
        {
            aide.Visible = true;
            fermer_aide.Visible = true;
        }

        private void textBox2_TextChanged(object sender, EventArgs e) {   }

        private void Form1_Load(object sender, EventArgs e) {   }

        private void panel2_Paint(object sender, PaintEventArgs e) {   }

        private void button3_Click(object sender, EventArgs e) {   }

        private void button8_Click(object sender, EventArgs e)
        {
            if (value_son == 1) alarmefin.Play();
            System.Threading.Thread.Sleep(800);
            DialogResult quitter = MessageBox.Show("Voulez-vous vraiment quitter l'application ?", "Fermeture de l'application", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (quitter == DialogResult.Yes)
            {
                Application.Exit();
            }
            else {   }
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
            else {  }
        }

        private void button4_Click(object sender, EventArgs e) {   }

        private void button9_Click(object sender, EventArgs e)
        {
            aide.Visible = false;
            fermer_aide.Visible = false;
        }

        private void menu_Paint(object sender, PaintEventArgs e) {   }

        private void img_qvgdm_Click(object sender, EventArgs e) {   }

        private void titre_Click(object sender, EventArgs e) {   }

        private void bonnechance_Click(object sender, EventArgs e) {   }

        private void pictureBox1_Click(object sender, EventArgs e) {   }

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

        private void question_CellContentClick(object sender, DataGridViewCellEventArgs e) {   }

       private void label3_Click(object sender, EventArgs e) {   }

        private void jeu_Paint(object sender, PaintEventArgs e) {   }

        private void rep2_CellContentClick(object sender, DataGridViewCellEventArgs e) {   }

        private void button1_Click_2(object sender, EventArgs e)
        {
            if (verification_reponse(progressBar1.Value, 0))
            {
               // MessageBox.Show("vrai");
                lancer_question(2);
                barre_progression.Value++;
                switcheuros();
                infoquestion.Text = "Vous jouez pour la question " + q + " à " + euros + "€.";
                if (barre_progression.Value == 6)
                {
                    palier.Text = "Vous avez atteint le palier 1 à 1500€.";
                }
                if (barre_progression.Value == 11)
                {
                    palier.Text = "Vous avez atteint le palier 2 à 48000€.";
                }
                if (barre_progression.Value == 16)
                {
                    victoirepanel.Visible = true;
                    if (value_son == 1) victoire.Play();
                    jeu.Visible = false;
                }
                if (barre_progression.Value == 6) { jokerswitch.Visible = true; }
            }
            else {
                panel_defaite.Visible = true;
                if (value_son == 1) perdu.Play();
                int score, palier;
                if (barre_progression.Value <= 6)
                {
                    score = 0;
                    palier = 0;
                }
                else
                {
                    if (barre_progression.Value > 6 && barre_progression.Value <= 11)
                    {
                        score = 1500;
                        palier = 1;
                    }
                    else
                    {
                        score = 48000;
                        palier = 2;
                    }
                }
                label7.Text = "Vous avez perdu à la question " + barre_progression.Value + " qui valait " +euros+ "€.\nVous retombez donc au palier " + palier + " et repartez avec "+ score +"€.";
                jeu.Visible = false;
            }
        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            if (verification_reponse(progressBar1.Value, 2))
            {
                lancer_question(2);
                barre_progression.Value++;
                switcheuros();
                infoquestion.Text = "Vous jouez pour la question " + q + " à " + euros + "€.";
                if (barre_progression.Value == 6)
                {
                    palier.Text = "Vous avez atteint le palier 1 à 1500€.";
                }
                if (barre_progression.Value == 11)
                {
                    palier.Text = "Vous avez atteint le palier 2 à 48000€.";
                }
                if (barre_progression.Value == 16)
                {
                    jeu.Visible = false;
                    if (value_son == 1) victoire.Play();
                    victoirepanel.Visible = true;
                }
                if (barre_progression.Value == 6) { jokerswitch.Visible = true; }
            }
            else { 
                panel_defaite.Visible = true;
                if (value_son == 1) perdu.Play();
                int score, palier;
                if (barre_progression.Value < 5)
                {
                    score = 0;
                    palier = 0;
                }
                else
                {
                    if (barre_progression.Value < 10)
                    {
                        score = 1500;
                        palier = 1;
                    }
                    else
                    {
                        score = 48000;
                        palier = 2;
                    }
                }
                label7.Text = "Vous avez perdu à la question " + barre_progression.Value + " qui valait " + euros + "€.\nVous retombez donc au palier " + palier + " et repartez avec " + score + "€.";
                jeu.Visible = false;
            }
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            if (verification_reponse(progressBar1.Value, 1))
            {
                lancer_question(2);
                barre_progression.Value++;
                switcheuros();
                infoquestion.Text = "Vous jouez pour la question " + q + " à " + euros + "€.";
                if (barre_progression.Value == 6)
                {
                    palier.Text = "Vous avez atteint le palier 1 à 1500€.";
                }
                if (barre_progression.Value == 11)
                {
                    palier.Text = "Vous avez atteint le palier 2 à 48000€.";
                }
                if (barre_progression.Value == 16)
                {
                    jeu.Visible = false;
                    if (value_son == 1) victoire.Play();
                    victoirepanel.Visible = true;
                }
                if (barre_progression.Value == 6) { jokerswitch.Visible = true; }
            }
            else { 
                panel_defaite.Visible = true;
                if (value_son == 1) perdu.Play();
                int score, palier;
                if (barre_progression.Value < 5)
                {
                    score = 0;
                    palier = 0;
                }
                else
                {
                    if (barre_progression.Value < 10)
                    {
                        score = 1500;
                        palier = 1;
                    }
                    else
                    {
                        score = 48000;
                        palier = 2;
                    }
                }
                label7.Text = "Vous avez perdu à la question " + barre_progression.Value + " qui valait " + euros + "€.\nVous retombez donc au palier " + palier + " et repartez avec " + score + "€.";
                jeu.Visible = false;
            }
        }

        private void button4_Click_1(object sender, EventArgs e)
        {
            if (verification_reponse(progressBar1.Value, 3))
            {
                lancer_question(2);
                barre_progression.Value++;
                switcheuros();
                infoquestion.Text = "Vous jouez pour la question " + q + " à " + euros + "€.";
                if (barre_progression.Value == 6)
                {
                    palier.Text = "Vous avez atteint le palier 1 à 1500€.";
                }
                if (barre_progression.Value == 11)
                {
                    palier.Text = "Vous avez atteint le palier 2 à 48000€.";
                }
                if (barre_progression.Value == 16)
                {
                    jeu.Visible = false;
                    if (value_son == 1) victoire.Play();
                    victoirepanel.Visible = true;
                }
                if (barre_progression.Value == 6) { jokerswitch.Visible = true; }
            }
            else {
                panel_defaite.Visible = true;
                int score, palier;
                if (barre_progression.Value < 5)
                {
                    score = 0;
                    palier = 0;
                }
                else
                {
                    if (barre_progression.Value < 10)
                    {
                        score = 1500;
                        palier = 1;
                    }
                    else
                    {
                        score = 48000;
                        palier = 2;
                    }
                }
                label7.Text = "Vous avez perdu à la question " + barre_progression.Value + " qui valait " + euros + "€.\nVous retombez donc au palier " + palier + " et repartez avec " + score + "€.";
                jeu.Visible = false;
                if (value_son == 1) perdu.Play();
            }
        }

        private void progressBar1_Click(object sender, EventArgs e) {   }

        private void barre_progression_Click(object sender, EventArgs e) {   }

        private void menuwin_Click(object sender, EventArgs e) {   }

        private void exitend_Click(object sender, EventArgs e)
        {
            if (value_son == 1) alarmefin.Play();
            System.Threading.Thread.Sleep(800);
            DialogResult quitter = MessageBox.Show("Voulez-vous vraiment quitter l'application ?", "Fermeture de l'application", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (quitter == DialogResult.Yes)
            {
                Application.Exit();
            }
            else {   }
        }

        private void buttonexitperdu_Click(object sender, EventArgs e)
        {
            if (value_son == 1) alarmefin.Play();
            System.Threading.Thread.Sleep(800);
            DialogResult quitter = MessageBox.Show("Voulez-vous vraiment quitter l'application ?", "Fermeture de l'application", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (quitter == DialogResult.Yes)
            {
                Application.Exit();
            }
            else {   }
        }

        private void retourmenudefaite_Click(object sender, EventArgs e)
        {
            jeu.Visible = false;
            menu.Visible = true;
            imagebox.Visible = true;
            victoirepanel.Visible = false;
            panel_defaite.Visible = false;
        }

        private void menuwin_Click_1(object sender, EventArgs e)
        {
            victoirepanel.Visible = false;
            menu.Visible = true;
            imagebox.Visible = true;
        }

        private void label7_Click(object sender, EventArgs e) {   }

        private void button5_Click(object sender, EventArgs e)
        {
            DialogResult quitter = MessageBox.Show("C'est votre dernier mot?", "Je souhaite m'arrêter à cette question", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (quitter == DialogResult.Yes)
            {
                panelfinprevu.Visible = true;
                switcheurosstop();
                label8.Text = "Vous avez fait le choix de ne pas répondre à la question " + barre_progression.Value + ".\n\nVous repartez donc avec la somme de " + eurosstop + "€.\n\n\n" +
                    "Bravo, c'est tout de même une belle somme !\nRevenez quand vous voulez pour tenter de remporter le million !";
                jeu.Visible = false;
            }
            else {   }
        }

        private void btfin_Click(object sender, EventArgs e)
        {
            if (value_son == 1) alarmefin.Play();
            System.Threading.Thread.Sleep(800);
            DialogResult quitter = MessageBox.Show("Voulez-vous vraiment quitter l'application ?", "Fermeture de l'application", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (quitter == DialogResult.Yes)
            {
                Application.Exit();
            }
            else {   }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            jeu.Visible = false;
            menu.Visible = true;
            imagebox.Visible = true;
            victoirepanel.Visible = false;
            panelfinprevu.Visible = false;
            panel_defaite.Visible = false;
        }

        private void panelfinprevu_Paint(object sender, PaintEventArgs e) {   }

        private void jokerswitch_Click(object sender, EventArgs e)
        {
            //on change la question 
            lancer_question(2);
            jokerswitch.Visible = false;
        }
        
        void fonction5050()
        {
            int q1a, q1b;
            Random choix = new Random();
            q1a = choix.Next(4);
            q1b = choix.Next(4);
            
            while ((verification_reponse(progressBar1.Value, q1a)) || (verification_reponse(progressBar1.Value, q1b)) || (q1a == q1b))
           {
                q1a = choix.Next(4);
                q1b = choix.Next(4);
           }
           if (q1a == 0 || q1b == 0) { button1.Visible = false; };
           if (q1a == 1 || q1b == 1) { button2.Visible = false; };
           if (q1a == 2 || q1b == 2) { button3.Visible = false; };
           if (q1a == 3 || q1b == 3) { button4.Visible = false; };
        }
        
        private void jokermoitie_Click(object sender, EventArgs e)
        {
            fonction5050();
            jokermoitie.Visible = false;
        }

        private void jokerpublic_Click(object sender, EventArgs e)
        {
            var form2 = new Form2();
            form2.Show();
            jokerpublic.Visible = false;
        }

        private void infoquestion_Click(object sender, EventArgs e) {   }

        private void button7_Click_1(object sender, EventArgs e)
        {
            var form3 = new Form3();
            form3.Show();
        }
    }
}
