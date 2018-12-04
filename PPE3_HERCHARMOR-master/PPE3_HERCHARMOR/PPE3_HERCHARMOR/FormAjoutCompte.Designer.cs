namespace PPE3_HERCHARMOR
{
    partial class FormAjoutCompte
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblNomClient = new System.Windows.Forms.Label();
            this.lblPrenomClient = new System.Windows.Forms.Label();
            this.lblDateNaissanceClient = new System.Windows.Forms.Label();
            this.lblEmailClient = new System.Windows.Forms.Label();
            this.lblLoginClient = new System.Windows.Forms.Label();
            this.lblPWDClient = new System.Windows.Forms.Label();
            this.lblDateAboClient = new System.Windows.Forms.Label();
            this.lblActifClient = new System.Windows.Forms.Label();
            this.tbNomClient = new System.Windows.Forms.TextBox();
            this.tbEmailClient = new System.Windows.Forms.TextBox();
            this.tbPrenomClient = new System.Windows.Forms.TextBox();
            this.tbLoginClient = new System.Windows.Forms.TextBox();
            this.tbPWDClient = new System.Windows.Forms.TextBox();
            this.dtpDateNaissance = new System.Windows.Forms.DateTimePicker();
            this.dtpDateAbonnement = new System.Windows.Forms.DateTimePicker();
            this.numEtatClient = new System.Windows.Forms.NumericUpDown();
            this.btnAjoutCompte = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.numEtatClient)).BeginInit();
            this.SuspendLayout();
            // 
            // lblNomClient
            // 
            this.lblNomClient.AutoSize = true;
            this.lblNomClient.Location = new System.Drawing.Point(13, 13);
            this.lblNomClient.Name = "lblNomClient";
            this.lblNomClient.Size = new System.Drawing.Size(78, 13);
            this.lblNomClient.TabIndex = 0;
            this.lblNomClient.Text = "Nom du client :";
            // 
            // lblPrenomClient
            // 
            this.lblPrenomClient.AutoSize = true;
            this.lblPrenomClient.Location = new System.Drawing.Point(12, 37);
            this.lblPrenomClient.Name = "lblPrenomClient";
            this.lblPrenomClient.Size = new System.Drawing.Size(92, 13);
            this.lblPrenomClient.TabIndex = 1;
            this.lblPrenomClient.Text = "Prénom du client :";
            // 
            // lblDateNaissanceClient
            // 
            this.lblDateNaissanceClient.AutoSize = true;
            this.lblDateNaissanceClient.Location = new System.Drawing.Point(12, 62);
            this.lblDateNaissanceClient.Name = "lblDateNaissanceClient";
            this.lblDateNaissanceClient.Size = new System.Drawing.Size(102, 13);
            this.lblDateNaissanceClient.TabIndex = 2;
            this.lblDateNaissanceClient.Text = "Date de naissance :";
            this.lblDateNaissanceClient.Click += new System.EventHandler(this.label3_Click);
            // 
            // lblEmailClient
            // 
            this.lblEmailClient.AutoSize = true;
            this.lblEmailClient.Location = new System.Drawing.Point(12, 87);
            this.lblEmailClient.Name = "lblEmailClient";
            this.lblEmailClient.Size = new System.Drawing.Size(81, 13);
            this.lblEmailClient.TabIndex = 3;
            this.lblEmailClient.Text = "Email du client :";
            // 
            // lblLoginClient
            // 
            this.lblLoginClient.AutoSize = true;
            this.lblLoginClient.Location = new System.Drawing.Point(12, 113);
            this.lblLoginClient.Name = "lblLoginClient";
            this.lblLoginClient.Size = new System.Drawing.Size(82, 13);
            this.lblLoginClient.TabIndex = 4;
            this.lblLoginClient.Text = "Login du client :";
            // 
            // lblPWDClient
            // 
            this.lblPWDClient.AutoSize = true;
            this.lblPWDClient.Location = new System.Drawing.Point(12, 139);
            this.lblPWDClient.Name = "lblPWDClient";
            this.lblPWDClient.Size = new System.Drawing.Size(120, 13);
            this.lblPWDClient.TabIndex = 5;
            this.lblPWDClient.Text = "Mot de passe du client :";
            // 
            // lblDateAboClient
            // 
            this.lblDateAboClient.AutoSize = true;
            this.lblDateAboClient.Location = new System.Drawing.Point(247, 13);
            this.lblDateAboClient.Name = "lblDateAboClient";
            this.lblDateAboClient.Size = new System.Drawing.Size(106, 13);
            this.lblDateAboClient.TabIndex = 6;
            this.lblDateAboClient.Text = "Date d\'abonnement :";
            // 
            // lblActifClient
            // 
            this.lblActifClient.AutoSize = true;
            this.lblActifClient.Location = new System.Drawing.Point(247, 37);
            this.lblActifClient.Name = "lblActifClient";
            this.lblActifClient.Size = new System.Drawing.Size(113, 13);
            this.lblActifClient.TabIndex = 7;
            this.lblActifClient.Text = "Etat du compte client :";
            // 
            // tbNomClient
            // 
            this.tbNomClient.Location = new System.Drawing.Point(97, 10);
            this.tbNomClient.Name = "tbNomClient";
            this.tbNomClient.Size = new System.Drawing.Size(100, 20);
            this.tbNomClient.TabIndex = 8;
            // 
            // tbEmailClient
            // 
            this.tbEmailClient.Location = new System.Drawing.Point(99, 84);
            this.tbEmailClient.Name = "tbEmailClient";
            this.tbEmailClient.Size = new System.Drawing.Size(100, 20);
            this.tbEmailClient.TabIndex = 9;
            // 
            // tbPrenomClient
            // 
            this.tbPrenomClient.Location = new System.Drawing.Point(110, 34);
            this.tbPrenomClient.Name = "tbPrenomClient";
            this.tbPrenomClient.Size = new System.Drawing.Size(100, 20);
            this.tbPrenomClient.TabIndex = 10;
            // 
            // tbLoginClient
            // 
            this.tbLoginClient.Location = new System.Drawing.Point(100, 110);
            this.tbLoginClient.Name = "tbLoginClient";
            this.tbLoginClient.Size = new System.Drawing.Size(100, 20);
            this.tbLoginClient.TabIndex = 11;
            // 
            // tbPWDClient
            // 
            this.tbPWDClient.Location = new System.Drawing.Point(138, 136);
            this.tbPWDClient.Name = "tbPWDClient";
            this.tbPWDClient.Size = new System.Drawing.Size(100, 20);
            this.tbPWDClient.TabIndex = 12;
            // 
            // dtpDateNaissance
            // 
            this.dtpDateNaissance.Location = new System.Drawing.Point(121, 61);
            this.dtpDateNaissance.Name = "dtpDateNaissance";
            this.dtpDateNaissance.Size = new System.Drawing.Size(27, 20);
            this.dtpDateNaissance.TabIndex = 13;
            this.dtpDateNaissance.Value = new System.DateTime(1980, 1, 1, 0, 0, 0, 0);
            // 
            // dtpDateAbonnement
            // 
            this.dtpDateAbonnement.Location = new System.Drawing.Point(359, 10);
            this.dtpDateAbonnement.Name = "dtpDateAbonnement";
            this.dtpDateAbonnement.Size = new System.Drawing.Size(27, 20);
            this.dtpDateAbonnement.TabIndex = 14;
            // 
            // numEtatClient
            // 
            this.numEtatClient.Location = new System.Drawing.Point(367, 37);
            this.numEtatClient.Maximum = new decimal(new int[] {
            2,
            0,
            0,
            0});
            this.numEtatClient.Name = "numEtatClient";
            this.numEtatClient.Size = new System.Drawing.Size(40, 20);
            this.numEtatClient.TabIndex = 15;
            // 
            // btnAjoutCompte
            // 
            this.btnAjoutCompte.Location = new System.Drawing.Point(367, 136);
            this.btnAjoutCompte.Name = "btnAjoutCompte";
            this.btnAjoutCompte.Size = new System.Drawing.Size(109, 23);
            this.btnAjoutCompte.TabIndex = 16;
            this.btnAjoutCompte.Text = "Ajouter un compte";
            this.btnAjoutCompte.UseVisualStyleBackColor = true;
            this.btnAjoutCompte.Click += new System.EventHandler(this.btnAjoutCompte_Click);
            // 
            // FormAjoutCompte
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(488, 182);
            this.Controls.Add(this.btnAjoutCompte);
            this.Controls.Add(this.numEtatClient);
            this.Controls.Add(this.dtpDateAbonnement);
            this.Controls.Add(this.dtpDateNaissance);
            this.Controls.Add(this.tbPWDClient);
            this.Controls.Add(this.tbLoginClient);
            this.Controls.Add(this.tbPrenomClient);
            this.Controls.Add(this.tbEmailClient);
            this.Controls.Add(this.tbNomClient);
            this.Controls.Add(this.lblActifClient);
            this.Controls.Add(this.lblDateAboClient);
            this.Controls.Add(this.lblPWDClient);
            this.Controls.Add(this.lblLoginClient);
            this.Controls.Add(this.lblEmailClient);
            this.Controls.Add(this.lblDateNaissanceClient);
            this.Controls.Add(this.lblPrenomClient);
            this.Controls.Add(this.lblNomClient);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "FormAjoutCompte";
            this.Text = "FormAjoutCompte";
            this.Load += new System.EventHandler(this.FormAjoutCompte_Load);
            ((System.ComponentModel.ISupportInitialize)(this.numEtatClient)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblNomClient;
        private System.Windows.Forms.Label lblPrenomClient;
        private System.Windows.Forms.Label lblDateNaissanceClient;
        private System.Windows.Forms.Label lblEmailClient;
        private System.Windows.Forms.Label lblLoginClient;
        private System.Windows.Forms.Label lblPWDClient;
        private System.Windows.Forms.Label lblDateAboClient;
        private System.Windows.Forms.Label lblActifClient;
        private System.Windows.Forms.TextBox tbNomClient;
        private System.Windows.Forms.TextBox tbEmailClient;
        private System.Windows.Forms.TextBox tbPrenomClient;
        private System.Windows.Forms.TextBox tbLoginClient;
        private System.Windows.Forms.TextBox tbPWDClient;
        private System.Windows.Forms.DateTimePicker dtpDateNaissance;
        private System.Windows.Forms.DateTimePicker dtpDateAbonnement;
        private System.Windows.Forms.NumericUpDown numEtatClient;
        private System.Windows.Forms.Button btnAjoutCompte;
    }
}