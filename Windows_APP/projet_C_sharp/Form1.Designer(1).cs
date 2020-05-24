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
            this.quitter_appli = new System.Windows.Forms.Button();
            this.retour_accueil = new System.Windows.Forms.Button();
            this.barre_progression = new System.Windows.Forms.ProgressBar();
            this.titre = new System.Windows.Forms.Label();
            this.imagebox = new System.Windows.Forms.Panel();
            this.img_qvgdm = new System.Windows.Forms.PictureBox();
            this.panel_bonnechance = new System.Windows.Forms.Panel();
            this.bonnechance = new System.Windows.Forms.Label();
            this.rep1 = new System.Windows.Forms.DataGridView();
            this.rep2 = new System.Windows.Forms.DataGridView();
            this.rep3 = new System.Windows.Forms.DataGridView();
            this.rep4 = new System.Windows.Forms.DataGridView();
            this.question = new System.Windows.Forms.DataGridView();
            this.menu.SuspendLayout();
            this.fermer_aide.SuspendLayout();
            this.aide.SuspendLayout();
            this.jeu.SuspendLayout();
            this.imagebox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.img_qvgdm)).BeginInit();
            this.panel_bonnechance.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.rep1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rep2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rep3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rep4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.question)).BeginInit();
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
            this.aide.Location = new System.Drawing.Point(12, 118);
            this.aide.Name = "aide";
            this.aide.Size = new System.Drawing.Size(351, 147);
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
            this.aidebox.Size = new System.Drawing.Size(351, 144);
            this.aidebox.TabIndex = 0;
            this.aidebox.Text = resources.GetString("aidebox.Text");
            this.aidebox.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // jeu
            // 
            this.jeu.Controls.Add(this.question);
            this.jeu.Controls.Add(this.rep4);
            this.jeu.Controls.Add(this.rep3);
            this.jeu.Controls.Add(this.rep2);
            this.jeu.Controls.Add(this.rep1);
            this.jeu.Controls.Add(this.quitter_appli);
            this.jeu.Controls.Add(this.retour_accueil);
            this.jeu.Controls.Add(this.barre_progression);
            this.jeu.Location = new System.Drawing.Point(12, 86);
            this.jeu.Name = "jeu";
            this.jeu.Size = new System.Drawing.Size(776, 340);
            this.jeu.TabIndex = 6;
            this.jeu.Visible = false;
            // 
            // quitter_appli
            // 
            this.quitter_appli.BackColor = System.Drawing.Color.DarkRed;
            this.quitter_appli.FlatAppearance.BorderSize = 0;
            this.quitter_appli.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.quitter_appli.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.quitter_appli.Location = new System.Drawing.Point(655, 15);
            this.quitter_appli.Margin = new System.Windows.Forms.Padding(0);
            this.quitter_appli.Name = "quitter_appli";
            this.quitter_appli.Size = new System.Drawing.Size(121, 31);
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
            this.retour_accueil.Location = new System.Drawing.Point(528, 15);
            this.retour_accueil.Margin = new System.Windows.Forms.Padding(0);
            this.retour_accueil.Name = "retour_accueil";
            this.retour_accueil.Size = new System.Drawing.Size(121, 31);
            this.retour_accueil.TabIndex = 6;
            this.retour_accueil.Text = "Retour au menu";
            this.retour_accueil.UseVisualStyleBackColor = false;
            this.retour_accueil.Click += new System.EventHandler(this.button7_Click);
            // 
            // barre_progression
            // 
            this.barre_progression.Location = new System.Drawing.Point(3, 314);
            this.barre_progression.Maximum = 15;
            this.barre_progression.Minimum = 1;
            this.barre_progression.Name = "barre_progression";
            this.barre_progression.Size = new System.Drawing.Size(770, 23);
            this.barre_progression.Step = 14;
            this.barre_progression.Style = System.Windows.Forms.ProgressBarStyle.Continuous;
            this.barre_progression.TabIndex = 5;
            this.barre_progression.Value = 1;
            // 
            // titre
            // 
            this.titre.BackColor = System.Drawing.Color.SteelBlue;
            this.titre.Font = new System.Drawing.Font("Segoe Print", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.titre.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.titre.Location = new System.Drawing.Point(12, 9);
            this.titre.Margin = new System.Windows.Forms.Padding(3, 0, 0, 0);
            this.titre.Name = "titre";
            this.titre.Size = new System.Drawing.Size(779, 52);
            this.titre.TabIndex = 7;
            this.titre.Text = "Qui veut gagner des millions ?";
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
            this.panel_bonnechance.Location = new System.Drawing.Point(1, 2);
            this.panel_bonnechance.Name = "panel_bonnechance";
            this.panel_bonnechance.Size = new System.Drawing.Size(800, 437);
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
            // rep1
            // 
            this.rep1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.rep1.Location = new System.Drawing.Point(3, 179);
            this.rep1.Name = "rep1";
            this.rep1.Size = new System.Drawing.Size(372, 34);
            this.rep1.TabIndex = 8;
            // 
            // rep2
            // 
            this.rep2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.rep2.Location = new System.Drawing.Point(401, 179);
            this.rep2.Name = "rep2";
            this.rep2.Size = new System.Drawing.Size(372, 34);
            this.rep2.TabIndex = 9;
            // 
            // rep3
            // 
            this.rep3.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.rep3.Location = new System.Drawing.Point(3, 242);
            this.rep3.Name = "rep3";
            this.rep3.Size = new System.Drawing.Size(372, 34);
            this.rep3.TabIndex = 10;
            // 
            // rep4
            // 
            this.rep4.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.rep4.Location = new System.Drawing.Point(401, 242);
            this.rep4.Name = "rep4";
            this.rep4.Size = new System.Drawing.Size(372, 34);
            this.rep4.TabIndex = 11;
            // 
            // question
            // 
            this.question.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.question.Location = new System.Drawing.Point(6, 68);
            this.question.Name = "question";
            this.question.Size = new System.Drawing.Size(767, 82);
            this.question.TabIndex = 12;
            this.question.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.question_CellContentClick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(83)))), ((int)(((byte)(132)))));
            this.ClientSize = new System.Drawing.Size(800, 438);
            this.Controls.Add(this.jeu);
            this.Controls.Add(this.imagebox);
            this.Controls.Add(this.menu);
            this.Controls.Add(this.titre);
            this.Controls.Add(this.aide);
            this.Controls.Add(this.panel_bonnechance);
            this.Name = "Form1";
            this.Text = "Projet C#";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menu.ResumeLayout(false);
            this.fermer_aide.ResumeLayout(false);
            this.aide.ResumeLayout(false);
            this.jeu.ResumeLayout(false);
            this.imagebox.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.img_qvgdm)).EndInit();
            this.panel_bonnechance.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.rep1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rep2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rep3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rep4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.question)).EndInit();
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
        private System.Windows.Forms.DataGridView rep4;
        private System.Windows.Forms.DataGridView rep3;
        private System.Windows.Forms.DataGridView rep2;
        private System.Windows.Forms.DataGridView rep1;
    }
}

