namespace projet_C_sharp
{
    partial class Form1
    {
        /// <summary>
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur Windows Form

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.play = new System.Windows.Forms.Button();
            this.afficher_aide = new System.Windows.Forms.Button();
            this.menu = new System.Windows.Forms.Panel();
            this.son = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.fermer_aide = new System.Windows.Forms.Panel();
            this.btn_fermer_aide = new System.Windows.Forms.Button();
            this.aide = new System.Windows.Forms.Panel();
            this.aidebox = new System.Windows.Forms.Label();
            this.jeu = new System.Windows.Forms.Panel();
            this.palier = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.button4 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.button7 = new System.Windows.Forms.Button();
            this.jokerpublic = new System.Windows.Forms.Button();
            this.jokermoitie = new System.Windows.Forms.Button();
            this.jokerswitch = new System.Windows.Forms.Button();
            this.infoquestion = new System.Windows.Forms.Label();
            this.button5 = new System.Windows.Forms.Button();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.question = new System.Windows.Forms.DataGridView();
            this.quitter_appli = new System.Windows.Forms.Button();
            this.retour_accueil = new System.Windows.Forms.Button();
            this.barre_progression = new System.Windows.Forms.ProgressBar();
            this.titre = new System.Windows.Forms.Label();
            this.imagebox = new System.Windows.Forms.Panel();
            this.img_qvgdm = new System.Windows.Forms.PictureBox();
            this.panel_bonnechance = new System.Windows.Forms.Panel();
            this.bonnechance = new System.Windows.Forms.Label();
            this.victoirepanel = new System.Windows.Forms.Panel();
            this.label5 = new System.Windows.Forms.Label();
            this.exitend = new System.Windows.Forms.Button();
            this.menuwin = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.panel_defaite = new System.Windows.Forms.Panel();
            this.label9 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.retourmenudefaite = new System.Windows.Forms.Button();
            this.buttonexitperdu = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.panelfinprevu = new System.Windows.Forms.Panel();
            this.button6 = new System.Windows.Forms.Button();
            this.btfin = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.menu.SuspendLayout();
            this.fermer_aide.SuspendLayout();
            this.aide.SuspendLayout();
            this.jeu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.question)).BeginInit();
            this.imagebox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.img_qvgdm)).BeginInit();
            this.panel_bonnechance.SuspendLayout();
            this.victoirepanel.SuspendLayout();
            this.panel_defaite.SuspendLayout();
            this.panelfinprevu.SuspendLayout();
            this.SuspendLayout();
            // 
            // play
            // 
            this.play.BackColor = System.Drawing.Color.Wheat;
            this.play.FlatAppearance.BorderSize = 0;
            this.play.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.play.Location = new System.Drawing.Point(0, 0);
            this.play.Name = "play";
            this.play.Size = new System.Drawing.Size(351, 49);
            this.play.TabIndex = 1;
            this.play.Text = "JOUER\r\n";
            this.play.UseVisualStyleBackColor = false;
            this.play.Click += new System.EventHandler(this.button1_Click);
            // 
            // afficher_aide
            // 
            this.afficher_aide.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.afficher_aide.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.afficher_aide.Location = new System.Drawing.Point(0, 63);
            this.afficher_aide.Name = "afficher_aide";
            this.afficher_aide.Size = new System.Drawing.Size(351, 37);
            this.afficher_aide.TabIndex = 2;
            this.afficher_aide.Text = "COMMENT JOUER ?";
            this.afficher_aide.UseVisualStyleBackColor = false;
            this.afficher_aide.Click += new System.EventHandler(this.button2_Click);
            // 
            // menu
            // 
            this.menu.AccessibleRole = System.Windows.Forms.AccessibleRole.MenuBar;
            this.menu.Controls.Add(this.son);
            this.menu.Controls.Add(this.label2);
            this.menu.Controls.Add(this.label1);
            this.menu.Controls.Add(this.fermer_aide);
            this.menu.Controls.Add(this.play);
            this.menu.Controls.Add(this.afficher_aide);
            this.menu.Location = new System.Drawing.Point(12, 322);
            this.menu.Name = "menu";
            this.menu.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.menu.Size = new System.Drawing.Size(779, 104);
            this.menu.TabIndex = 1;
            this.menu.Paint += new System.Windows.Forms.PaintEventHandler(this.menu_Paint);
            // 
            // son
            // 
            this.son.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.son.FlatAppearance.BorderSize = 0;
            this.son.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.son.Image = ((System.Drawing.Image)(resources.GetObject("son.Image")));
            this.son.Location = new System.Drawing.Point(711, 63);
            this.son.Name = "son";
            this.son.Size = new System.Drawing.Size(42, 30);
            this.son.TabIndex = 10;
            this.son.UseVisualStyleBackColor = true;
            this.son.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(460, 48);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(280, 19);
            this.label2.TabIndex = 9;
            this.label2.Text = "©";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(460, 63);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(280, 37);
            this.label1.TabIndex = 8;
            this.label1.Text = "Thomas JAULGEY - Grégoire BIRON\r\n      2019 - Projet C#";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // fermer_aide
            // 
            this.fermer_aide.Controls.Add(this.btn_fermer_aide);
            this.fermer_aide.Location = new System.Drawing.Point(0, 63);
            this.fermer_aide.Name = "fermer_aide";
            this.fermer_aide.Size = new System.Drawing.Size(351, 37);
            this.fermer_aide.TabIndex = 7;
            this.fermer_aide.Visible = false;
            // 
            // btn_fermer_aide
            // 
            this.btn_fermer_aide.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(250)))), ((int)(((byte)(250)))));
            this.btn_fermer_aide.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_fermer_aide.Location = new System.Drawing.Point(0, 0);
            this.btn_fermer_aide.Name = "btn_fermer_aide";
            this.btn_fermer_aide.Size = new System.Drawing.Size(351, 38);
            this.btn_fermer_aide.TabIndex = 0;
            this.btn_fermer_aide.Text = "Fermer l\'aide";
            this.btn_fermer_aide.UseVisualStyleBackColor = false;
            this.btn_fermer_aide.Click += new System.EventHandler(this.button9_Click);
            // 
            // aide
            // 
            this.aide.Controls.Add(this.aidebox);
            this.aide.Location = new System.Drawing.Point(12, 89);
            this.aide.Name = "aide";
            this.aide.Size = new System.Drawing.Size(351, 209);
            this.aide.TabIndex = 5;
            this.aide.Visible = false;
            this.aide.Paint += new System.Windows.Forms.PaintEventHandler(this.panel2_Paint);
            // 
            // aidebox
            // 
            this.aidebox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(66)))), ((int)(((byte)(105)))));
            this.aidebox.ForeColor = System.Drawing.Color.White;
            this.aidebox.Location = new System.Drawing.Point(0, 0);
            this.aidebox.Name = "aidebox";
            this.aidebox.Size = new System.Drawing.Size(351, 209);
            this.aidebox.TabIndex = 0;
            this.aidebox.Text = resources.GetString("aidebox.Text");
            this.aidebox.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // jeu
            // 
            this.jeu.Controls.Add(this.palier);
            this.jeu.Controls.Add(this.label3);
            this.jeu.Controls.Add(this.button4);
            this.jeu.Controls.Add(this.button3);
            this.jeu.Controls.Add(this.button2);
            this.jeu.Controls.Add(this.button1);
            this.jeu.Controls.Add(this.pictureBox1);
            this.jeu.Controls.Add(this.button7);
            this.jeu.Controls.Add(this.jokerpublic);
            this.jeu.Controls.Add(this.jokermoitie);
            this.jeu.Controls.Add(this.jokerswitch);
            this.jeu.Controls.Add(this.infoquestion);
            this.jeu.Controls.Add(this.button5);
            this.jeu.Controls.Add(this.progressBar1);
            this.jeu.Controls.Add(this.question);
            this.jeu.Controls.Add(this.quitter_appli);
            this.jeu.Controls.Add(this.retour_accueil);
            this.jeu.Controls.Add(this.barre_progression);
            this.jeu.Location = new System.Drawing.Point(0, 86);
            this.jeu.Name = "jeu";
            this.jeu.Size = new System.Drawing.Size(799, 340);
            this.jeu.TabIndex = 6;
            this.jeu.Visible = false;
            this.jeu.Paint += new System.Windows.Forms.PaintEventHandler(this.jeu_Paint);
            // 
            // palier
            // 
            this.palier.BackColor = System.Drawing.Color.Transparent;
            this.palier.Font = new System.Drawing.Font("Microsoft New Tai Lue", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Italic | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.palier.ForeColor = System.Drawing.Color.White;
            this.palier.Location = new System.Drawing.Point(40, 67);
            this.palier.Name = "palier";
            this.palier.Size = new System.Drawing.Size(257, 23);
            this.palier.TabIndex = 25;
            this.palier.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            this.label3.BackColor = System.Drawing.Color.Black;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(90, 111);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(620, 69);
            this.label3.TabIndex = 13;
            this.label3.Text = "yup";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.Color.Black;
            this.button4.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button4.FlatAppearance.BorderSize = 0;
            this.button4.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Black;
            this.button4.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Black;
            this.button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button4.ForeColor = System.Drawing.Color.White;
            this.button4.Location = new System.Drawing.Point(448, 261);
            this.button4.Margin = new System.Windows.Forms.Padding(2);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(271, 33);
            this.button4.TabIndex = 21;
            this.button4.Text = "button4";
            this.button4.UseVisualStyleBackColor = false;
            this.button4.Click += new System.EventHandler(this.button4_Click_1);
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.Black;
            this.button3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button3.FlatAppearance.BorderSize = 0;
            this.button3.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Black;
            this.button3.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Black;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.ForeColor = System.Drawing.Color.White;
            this.button3.Location = new System.Drawing.Point(448, 203);
            this.button3.Margin = new System.Windows.Forms.Padding(2);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(271, 32);
            this.button3.TabIndex = 20;
            this.button3.Text = "button3";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click_1);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.Black;
            this.button2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Black;
            this.button2.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Black;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.ForeColor = System.Drawing.Color.White;
            this.button2.Location = new System.Drawing.Point(77, 261);
            this.button2.Margin = new System.Windows.Forms.Padding(2);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(271, 33);
            this.button2.TabIndex = 19;
            this.button2.Text = "button2";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click_1);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Black;
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Black;
            this.button1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Black;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(77, 203);
            this.button1.Margin = new System.Windows.Forms.Padding(2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(271, 32);
            this.button1.TabIndex = 18;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click_2);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(0, 98);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(802, 205);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 30;
            this.pictureBox1.TabStop = false;
            // 
            // button7
            // 
            this.button7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.button7.FlatAppearance.BorderSize = 0;
            this.button7.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button7.Location = new System.Drawing.Point(523, 15);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(86, 31);
            this.button7.TabIndex = 29;
            this.button7.Text = "Grille des gains";
            this.button7.UseVisualStyleBackColor = false;
            this.button7.Click += new System.EventHandler(this.button7_Click_1);
            // 
            // jokerpublic
            // 
            this.jokerpublic.BackColor = System.Drawing.Color.Transparent;
            this.jokerpublic.Cursor = System.Windows.Forms.Cursors.Hand;
            this.jokerpublic.FlatAppearance.BorderSize = 0;
            this.jokerpublic.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.jokerpublic.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.jokerpublic.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.jokerpublic.Image = ((System.Drawing.Image)(resources.GetObject("jokerpublic.Image")));
            this.jokerpublic.Location = new System.Drawing.Point(583, 55);
            this.jokerpublic.Name = "jokerpublic";
            this.jokerpublic.Size = new System.Drawing.Size(47, 44);
            this.jokerpublic.TabIndex = 28;
            this.jokerpublic.UseVisualStyleBackColor = false;
            this.jokerpublic.Click += new System.EventHandler(this.jokerpublic_Click);
            // 
            // jokermoitie
            // 
            this.jokermoitie.BackColor = System.Drawing.Color.Transparent;
            this.jokermoitie.Cursor = System.Windows.Forms.Cursors.Hand;
            this.jokermoitie.FlatAppearance.BorderSize = 0;
            this.jokermoitie.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.jokermoitie.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.jokermoitie.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.jokermoitie.Image = ((System.Drawing.Image)(resources.GetObject("jokermoitie.Image")));
            this.jokermoitie.Location = new System.Drawing.Point(635, 57);
            this.jokermoitie.Name = "jokermoitie";
            this.jokermoitie.Size = new System.Drawing.Size(42, 40);
            this.jokermoitie.TabIndex = 27;
            this.jokermoitie.UseVisualStyleBackColor = false;
            this.jokermoitie.Click += new System.EventHandler(this.jokermoitie_Click);
            // 
            // jokerswitch
            // 
            this.jokerswitch.BackColor = System.Drawing.Color.Transparent;
            this.jokerswitch.Cursor = System.Windows.Forms.Cursors.Hand;
            this.jokerswitch.FlatAppearance.BorderSize = 0;
            this.jokerswitch.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.jokerswitch.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.jokerswitch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.jokerswitch.Image = ((System.Drawing.Image)(resources.GetObject("jokerswitch.Image")));
            this.jokerswitch.Location = new System.Drawing.Point(683, 57);
            this.jokerswitch.Name = "jokerswitch";
            this.jokerswitch.Size = new System.Drawing.Size(41, 40);
            this.jokerswitch.TabIndex = 26;
            this.jokerswitch.UseVisualStyleBackColor = false;
            this.jokerswitch.Click += new System.EventHandler(this.jokerswitch_Click);
            // 
            // infoquestion
            // 
            this.infoquestion.Font = new System.Drawing.Font("Microsoft New Tai Lue", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.infoquestion.ForeColor = System.Drawing.Color.White;
            this.infoquestion.Location = new System.Drawing.Point(220, 20);
            this.infoquestion.Name = "infoquestion";
            this.infoquestion.Size = new System.Drawing.Size(297, 23);
            this.infoquestion.TabIndex = 24;
            this.infoquestion.Text = "infoquestion";
            this.infoquestion.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.infoquestion.Click += new System.EventHandler(this.infoquestion_Click);
            // 
            // button5
            // 
            this.button5.BackColor = System.Drawing.Color.Chocolate;
            this.button5.FlatAppearance.BorderSize = 0;
            this.button5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button5.ForeColor = System.Drawing.Color.White;
            this.button5.Location = new System.Drawing.Point(12, 15);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(202, 31);
            this.button5.TabIndex = 23;
            this.button5.Text = "Je souhaite m\'arrêter à cette question";
            this.button5.UseVisualStyleBackColor = false;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(759, 292);
            this.progressBar1.Maximum = 1500;
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(8, 11);
            this.progressBar1.Step = 1;
            this.progressBar1.Style = System.Windows.Forms.ProgressBarStyle.Continuous;
            this.progressBar1.TabIndex = 22;
            this.progressBar1.Value = 1;
            this.progressBar1.Visible = false;
            this.progressBar1.Click += new System.EventHandler(this.progressBar1_Click);
            // 
            // question
            // 
            this.question.BackgroundColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.question.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.question.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.question.DefaultCellStyle = dataGridViewCellStyle4;
            this.question.Location = new System.Drawing.Point(12, 86);
            this.question.Name = "question";
            this.question.Size = new System.Drawing.Size(779, 82);
            this.question.TabIndex = 12;
            this.question.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.question_CellContentClick);
            // 
            // quitter_appli
            // 
            this.quitter_appli.BackColor = System.Drawing.Color.DarkRed;
            this.quitter_appli.FlatAppearance.BorderSize = 0;
            this.quitter_appli.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.quitter_appli.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.quitter_appli.Location = new System.Drawing.Point(716, 15);
            this.quitter_appli.Margin = new System.Windows.Forms.Padding(0);
            this.quitter_appli.Name = "quitter_appli";
            this.quitter_appli.Size = new System.Drawing.Size(75, 31);
            this.quitter_appli.TabIndex = 7;
            this.quitter_appli.Text = "QUITTER";
            this.quitter_appli.UseVisualStyleBackColor = false;
            this.quitter_appli.Click += new System.EventHandler(this.button8_Click);
            // 
            // retour_accueil
            // 
            this.retour_accueil.BackColor = System.Drawing.Color.DimGray;
            this.retour_accueil.FlatAppearance.BorderSize = 0;
            this.retour_accueil.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.retour_accueil.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.retour_accueil.Location = new System.Drawing.Point(615, 15);
            this.retour_accueil.Margin = new System.Windows.Forms.Padding(0);
            this.retour_accueil.Name = "retour_accueil";
            this.retour_accueil.Size = new System.Drawing.Size(95, 31);
            this.retour_accueil.TabIndex = 6;
            this.retour_accueil.Text = "Retour au menu";
            this.retour_accueil.UseVisualStyleBackColor = false;
            this.retour_accueil.Click += new System.EventHandler(this.button7_Click);
            // 
            // barre_progression
            // 
            this.barre_progression.Location = new System.Drawing.Point(12, 314);
            this.barre_progression.Maximum = 16;
            this.barre_progression.Minimum = 1;
            this.barre_progression.Name = "barre_progression";
            this.barre_progression.Size = new System.Drawing.Size(779, 23);
            this.barre_progression.Step = 1;
            this.barre_progression.TabIndex = 5;
            this.barre_progression.Value = 1;
            this.barre_progression.Click += new System.EventHandler(this.barre_progression_Click);
            // 
            // titre
            // 
            this.titre.BackColor = System.Drawing.Color.SteelBlue;
            this.titre.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.titre.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.titre.Location = new System.Drawing.Point(12, 9);
            this.titre.Margin = new System.Windows.Forms.Padding(3, 0, 0, 0);
            this.titre.Name = "titre";
            this.titre.Size = new System.Drawing.Size(779, 52);
            this.titre.TabIndex = 7;
            this.titre.Text = "QUI VEUT GAGNER DES MILLIONS ?";
            this.titre.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.titre.Click += new System.EventHandler(this.titre_Click);
            // 
            // imagebox
            // 
            this.imagebox.Controls.Add(this.img_qvgdm);
            this.imagebox.Location = new System.Drawing.Point(435, 64);
            this.imagebox.Name = "imagebox";
            this.imagebox.Size = new System.Drawing.Size(350, 307);
            this.imagebox.TabIndex = 8;
            // 
            // img_qvgdm
            // 
            this.img_qvgdm.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("img_qvgdm.BackgroundImage")));
            this.img_qvgdm.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.img_qvgdm.Location = new System.Drawing.Point(37, 18);
            this.img_qvgdm.Name = "img_qvgdm";
            this.img_qvgdm.Size = new System.Drawing.Size(280, 280);
            this.img_qvgdm.TabIndex = 0;
            this.img_qvgdm.TabStop = false;
            this.img_qvgdm.Click += new System.EventHandler(this.img_qvgdm_Click);
            // 
            // panel_bonnechance
            // 
            this.panel_bonnechance.Controls.Add(this.bonnechance);
            this.panel_bonnechance.Location = new System.Drawing.Point(12, 9);
            this.panel_bonnechance.Name = "panel_bonnechance";
            this.panel_bonnechance.Size = new System.Drawing.Size(779, 430);
            this.panel_bonnechance.TabIndex = 9;
            this.panel_bonnechance.Visible = false;
            // 
            // bonnechance
            // 
            this.bonnechance.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bonnechance.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bonnechance.ForeColor = System.Drawing.Color.White;
            this.bonnechance.Location = new System.Drawing.Point(11, 62);
            this.bonnechance.Name = "bonnechance";
            this.bonnechance.Size = new System.Drawing.Size(779, 241);
            this.bonnechance.TabIndex = 0;
            this.bonnechance.Text = "C\'est parti,\r\nbonne chance !";
            this.bonnechance.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.bonnechance.Click += new System.EventHandler(this.bonnechance_Click);
            // 
            // victoirepanel
            // 
            this.victoirepanel.BackColor = System.Drawing.Color.Green;
            this.victoirepanel.Controls.Add(this.label5);
            this.victoirepanel.Controls.Add(this.exitend);
            this.victoirepanel.Controls.Add(this.menuwin);
            this.victoirepanel.Controls.Add(this.label4);
            this.victoirepanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.victoirepanel.Location = new System.Drawing.Point(0, 0);
            this.victoirepanel.Name = "victoirepanel";
            this.victoirepanel.Size = new System.Drawing.Size(800, 438);
            this.victoirepanel.TabIndex = 1;
            this.victoirepanel.Visible = false;
            // 
            // label5
            // 
            this.label5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.label5.Font = new System.Drawing.Font("Segoe Print", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label5.Location = new System.Drawing.Point(12, 9);
            this.label5.Margin = new System.Windows.Forms.Padding(3, 0, 0, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(779, 52);
            this.label5.TabIndex = 10;
            this.label5.Text = "QUI VEUT GAGNER DES MILLIONS ?";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // exitend
            // 
            this.exitend.BackColor = System.Drawing.Color.DarkOrange;
            this.exitend.FlatAppearance.BorderSize = 0;
            this.exitend.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.exitend.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.exitend.Location = new System.Drawing.Point(631, 227);
            this.exitend.Margin = new System.Windows.Forms.Padding(0);
            this.exitend.Name = "exitend";
            this.exitend.Size = new System.Drawing.Size(121, 31);
            this.exitend.TabIndex = 9;
            this.exitend.Text = "QUITTER";
            this.exitend.UseVisualStyleBackColor = false;
            this.exitend.Click += new System.EventHandler(this.exitend_Click);
            // 
            // menuwin
            // 
            this.menuwin.BackColor = System.Drawing.Color.DimGray;
            this.menuwin.FlatAppearance.BorderSize = 0;
            this.menuwin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.menuwin.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.menuwin.Location = new System.Drawing.Point(631, 170);
            this.menuwin.Margin = new System.Windows.Forms.Padding(0);
            this.menuwin.Name = "menuwin";
            this.menuwin.Size = new System.Drawing.Size(121, 31);
            this.menuwin.TabIndex = 7;
            this.menuwin.Text = "Retour au menu";
            this.menuwin.UseVisualStyleBackColor = false;
            this.menuwin.Click += new System.EventHandler(this.menuwin_Click_1);
            // 
            // label4
            // 
            this.label4.Font = new System.Drawing.Font("Microsoft YaHei", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(36, 158);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(501, 204);
            this.label4.TabIndex = 8;
            this.label4.Text = "Félicitations ! \r\nVous avez répondu avec brio aux 15 questions du jeu.\r\n\r\n\r\nVous " +
    "venez de remporter le million !\r\n\r\n\r\n\r\nN\'hésitez pas à refaire une partie pour d" +
    "écouvrir d\'autres questions.\r\n";
            // 
            // panel_defaite
            // 
            this.panel_defaite.BackColor = System.Drawing.Color.Maroon;
            this.panel_defaite.Controls.Add(this.label9);
            this.panel_defaite.Controls.Add(this.label7);
            this.panel_defaite.Controls.Add(this.retourmenudefaite);
            this.panel_defaite.Controls.Add(this.buttonexitperdu);
            this.panel_defaite.Controls.Add(this.label6);
            this.panel_defaite.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel_defaite.Location = new System.Drawing.Point(0, 0);
            this.panel_defaite.Name = "panel_defaite";
            this.panel_defaite.Size = new System.Drawing.Size(800, 438);
            this.panel_defaite.TabIndex = 1;
            this.panel_defaite.Visible = false;
            // 
            // label9
            // 
            this.label9.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.label9.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label9.Location = new System.Drawing.Point(12, 9);
            this.label9.Margin = new System.Windows.Forms.Padding(3, 0, 0, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(779, 52);
            this.label9.TabIndex = 13;
            this.label9.Text = "QUI VEUT GAGNER DES MILLIONS ?";
            this.label9.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label7
            // 
            this.label7.Font = new System.Drawing.Font("Microsoft New Tai Lue", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(36, 242);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(730, 65);
            this.label7.TabIndex = 12;
            this.label7.Text = "label7";
            this.label7.Click += new System.EventHandler(this.label7_Click);
            // 
            // retourmenudefaite
            // 
            this.retourmenudefaite.BackColor = System.Drawing.Color.DimGray;
            this.retourmenudefaite.FlatAppearance.BorderSize = 0;
            this.retourmenudefaite.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.retourmenudefaite.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.retourmenudefaite.Location = new System.Drawing.Point(450, 326);
            this.retourmenudefaite.Margin = new System.Windows.Forms.Padding(0);
            this.retourmenudefaite.Name = "retourmenudefaite";
            this.retourmenudefaite.Size = new System.Drawing.Size(121, 31);
            this.retourmenudefaite.TabIndex = 11;
            this.retourmenudefaite.Text = "Retour au menu";
            this.retourmenudefaite.UseVisualStyleBackColor = false;
            this.retourmenudefaite.Click += new System.EventHandler(this.retourmenudefaite_Click);
            // 
            // buttonexitperdu
            // 
            this.buttonexitperdu.BackColor = System.Drawing.Color.DarkOrange;
            this.buttonexitperdu.FlatAppearance.BorderSize = 0;
            this.buttonexitperdu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonexitperdu.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.buttonexitperdu.Location = new System.Drawing.Point(610, 326);
            this.buttonexitperdu.Margin = new System.Windows.Forms.Padding(0);
            this.buttonexitperdu.Name = "buttonexitperdu";
            this.buttonexitperdu.Size = new System.Drawing.Size(121, 31);
            this.buttonexitperdu.TabIndex = 10;
            this.buttonexitperdu.Text = "QUITTER";
            this.buttonexitperdu.UseVisualStyleBackColor = false;
            this.buttonexitperdu.Click += new System.EventHandler(this.buttonexitperdu_Click);
            // 
            // label6
            // 
            this.label6.Font = new System.Drawing.Font("Microsoft New Tai Lue", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(39, 141);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(603, 81);
            this.label6.TabIndex = 0;
            this.label6.Text = "Malheureusement, c\'est une mauvaise réponse ...\r\n\r\nVous pourrez retenter votre ch" +
    "ance une prochaine fois pour tenter de remporter le million.";
            // 
            // panelfinprevu
            // 
            this.panelfinprevu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(83)))), ((int)(((byte)(132)))));
            this.panelfinprevu.Controls.Add(this.button6);
            this.panelfinprevu.Controls.Add(this.btfin);
            this.panelfinprevu.Controls.Add(this.label8);
            this.panelfinprevu.Location = new System.Drawing.Point(-7, 67);
            this.panelfinprevu.Name = "panelfinprevu";
            this.panelfinprevu.Size = new System.Drawing.Size(809, 372);
            this.panelfinprevu.TabIndex = 11;
            this.panelfinprevu.Visible = false;
            this.panelfinprevu.Paint += new System.Windows.Forms.PaintEventHandler(this.panelfinprevu_Paint);
            // 
            // button6
            // 
            this.button6.BackColor = System.Drawing.Color.DimGray;
            this.button6.FlatAppearance.BorderSize = 0;
            this.button6.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button6.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.button6.Location = new System.Drawing.Point(274, 291);
            this.button6.Margin = new System.Windows.Forms.Padding(0);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(121, 31);
            this.button6.TabIndex = 9;
            this.button6.Text = "Retour au menu";
            this.button6.UseVisualStyleBackColor = false;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // btfin
            // 
            this.btfin.BackColor = System.Drawing.Color.DarkRed;
            this.btfin.FlatAppearance.BorderSize = 0;
            this.btfin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btfin.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btfin.Location = new System.Drawing.Point(433, 291);
            this.btfin.Margin = new System.Windows.Forms.Padding(0);
            this.btfin.Name = "btfin";
            this.btfin.Size = new System.Drawing.Size(121, 31);
            this.btfin.TabIndex = 8;
            this.btfin.Text = "QUITTER";
            this.btfin.UseVisualStyleBackColor = false;
            this.btfin.Click += new System.EventHandler(this.btfin_Click);
            // 
            // label8
            // 
            this.label8.Font = new System.Drawing.Font("Microsoft New Tai Lue", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.White;
            this.label8.Location = new System.Drawing.Point(61, 64);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(698, 177);
            this.label8.TabIndex = 0;
            this.label8.Text = "label8";
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(83)))), ((int)(((byte)(132)))));
            this.ClientSize = new System.Drawing.Size(800, 438);
            this.Controls.Add(this.panel_defaite);
            this.Controls.Add(this.victoirepanel);
            this.Controls.Add(this.jeu);
            this.Controls.Add(this.aide);
            this.Controls.Add(this.panelfinprevu);
            this.Controls.Add(this.titre);
            this.Controls.Add(this.panel_bonnechance);
            this.Controls.Add(this.imagebox);
            this.Controls.Add(this.menu);
            this.Name = "Form1";
            this.Text = "Qui veut gagner des millions ?   |    Projet C Sharp";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menu.ResumeLayout(false);
            this.fermer_aide.ResumeLayout(false);
            this.aide.ResumeLayout(false);
            this.jeu.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.question)).EndInit();
            this.imagebox.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.img_qvgdm)).EndInit();
            this.panel_bonnechance.ResumeLayout(false);
            this.victoirepanel.ResumeLayout(false);
            this.panel_defaite.ResumeLayout(false);
            this.panelfinprevu.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button play;
        private System.Windows.Forms.Button afficher_aide;
        public System.Windows.Forms.Panel aide;
        private System.Windows.Forms.Panel jeu;
        private System.Windows.Forms.Button quitter_appli;
        private System.Windows.Forms.Button retour_accueil;
        private System.Windows.Forms.ProgressBar barre_progression;
        private System.Windows.Forms.Button btn_fermer_aide;
        public System.Windows.Forms.Panel menu;
        public System.Windows.Forms.Panel fermer_aide;
        private System.Windows.Forms.Label titre;
        private System.Windows.Forms.Label aidebox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel imagebox;
        private System.Windows.Forms.PictureBox img_qvgdm;
        private System.Windows.Forms.Panel panel_bonnechance;
        private System.Windows.Forms.Label bonnechance;
        private System.Windows.Forms.Button son;
        private System.Windows.Forms.DataGridView question;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ProgressBar progressBar1;
        public System.Windows.Forms.Button menuwin;
        private System.Windows.Forms.Button exitend;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Panel victoirepanel;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Panel panel_defaite;
        private System.Windows.Forms.Button buttonexitperdu;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button retourmenudefaite;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Panel panelfinprevu;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button btfin;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Label infoquestion;
        private System.Windows.Forms.Label palier;
        private System.Windows.Forms.Button jokerswitch;
        private System.Windows.Forms.Button jokermoitie;
        private System.Windows.Forms.Button jokerpublic;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label9;
    }
}

