﻿namespace PPE3_HERCHARMOR
{
    partial class FormValidationCompte
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
            this.components = new System.ComponentModel.Container();
            this.cbCompteNonValide = new System.Windows.Forms.ComboBox();
            this.bsClient = new System.Windows.Forms.BindingSource(this.components);
            this.lblNomClient = new System.Windows.Forms.Label();
            this.lblPrenomClient = new System.Windows.Forms.Label();
            this.lblEmailClient = new System.Windows.Forms.Label();
            this.lblDateNaissanceClient = new System.Windows.Forms.Label();
            this.lblDateAboClient = new System.Windows.Forms.Label();
            this.lblLoginClient = new System.Windows.Forms.Label();
            this.lblMDPClient = new System.Windows.Forms.Label();
            this.lblActifClient = new System.Windows.Forms.Label();
            this.btnValidation = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.bsClient)).BeginInit();
            this.SuspendLayout();
            // 
            // cbCompteNonValide
            // 
            this.cbCompteNonValide.DataSource = this.bsClient;
            this.cbCompteNonValide.DisplayMember = "nomEntier";
            this.cbCompteNonValide.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbCompteNonValide.DropDownWidth = 150;
            this.cbCompteNonValide.FormattingEnabled = true;
            this.cbCompteNonValide.Location = new System.Drawing.Point(13, 13);
            this.cbCompteNonValide.Name = "cbCompteNonValide";
            this.cbCompteNonValide.Size = new System.Drawing.Size(209, 21);
            this.cbCompteNonValide.TabIndex = 0;
            this.cbCompteNonValide.ValueMember = "idClient";
            this.cbCompteNonValide.SelectedIndexChanged += new System.EventHandler(this.cbCompteNonValide_SelectedIndexChanged);
            // 
            // bsClient
            // 
            this.bsClient.DataSource = typeof(PPE3_HERCHARMOR.client);
            // 
            // lblNomClient
            // 
            this.lblNomClient.AutoSize = true;
            this.lblNomClient.Location = new System.Drawing.Point(12, 51);
            this.lblNomClient.Name = "lblNomClient";
            this.lblNomClient.Size = new System.Drawing.Size(65, 13);
            this.lblNomClient.TabIndex = 1;
            this.lblNomClient.Text = "lblNomClient";
            // 
            // lblPrenomClient
            // 
            this.lblPrenomClient.AutoSize = true;
            this.lblPrenomClient.Location = new System.Drawing.Point(12, 78);
            this.lblPrenomClient.Name = "lblPrenomClient";
            this.lblPrenomClient.Size = new System.Drawing.Size(79, 13);
            this.lblPrenomClient.TabIndex = 2;
            this.lblPrenomClient.Text = "lblPrenomClient";
            // 
            // lblEmailClient
            // 
            this.lblEmailClient.AutoSize = true;
            this.lblEmailClient.Location = new System.Drawing.Point(12, 103);
            this.lblEmailClient.Name = "lblEmailClient";
            this.lblEmailClient.Size = new System.Drawing.Size(68, 13);
            this.lblEmailClient.TabIndex = 3;
            this.lblEmailClient.Text = "lblEmailClient";
            // 
            // lblDateNaissanceClient
            // 
            this.lblDateNaissanceClient.AutoSize = true;
            this.lblDateNaissanceClient.Location = new System.Drawing.Point(12, 127);
            this.lblDateNaissanceClient.Name = "lblDateNaissanceClient";
            this.lblDateNaissanceClient.Size = new System.Drawing.Size(116, 13);
            this.lblDateNaissanceClient.TabIndex = 4;
            this.lblDateNaissanceClient.Text = "lblDateNaissanceClient";
            // 
            // lblDateAboClient
            // 
            this.lblDateAboClient.AutoSize = true;
            this.lblDateAboClient.Location = new System.Drawing.Point(224, 51);
            this.lblDateAboClient.Name = "lblDateAboClient";
            this.lblDateAboClient.Size = new System.Drawing.Size(85, 13);
            this.lblDateAboClient.TabIndex = 5;
            this.lblDateAboClient.Text = "lblDateAboClient";
            // 
            // lblLoginClient
            // 
            this.lblLoginClient.AutoSize = true;
            this.lblLoginClient.Location = new System.Drawing.Point(224, 78);
            this.lblLoginClient.Name = "lblLoginClient";
            this.lblLoginClient.Size = new System.Drawing.Size(69, 13);
            this.lblLoginClient.TabIndex = 6;
            this.lblLoginClient.Text = "lblLoginClient";
            // 
            // lblMDPClient
            // 
            this.lblMDPClient.AutoSize = true;
            this.lblMDPClient.Location = new System.Drawing.Point(224, 103);
            this.lblMDPClient.Name = "lblMDPClient";
            this.lblMDPClient.Size = new System.Drawing.Size(67, 13);
            this.lblMDPClient.TabIndex = 7;
            this.lblMDPClient.Text = "lblMDPClient";
            // 
            // lblActifClient
            // 
            this.lblActifClient.AutoSize = true;
            this.lblActifClient.Location = new System.Drawing.Point(224, 127);
            this.lblActifClient.Name = "lblActifClient";
            this.lblActifClient.Size = new System.Drawing.Size(64, 13);
            this.lblActifClient.TabIndex = 8;
            this.lblActifClient.Text = "lblActifClient";
            // 
            // btnValidation
            // 
            this.btnValidation.Location = new System.Drawing.Point(312, 151);
            this.btnValidation.Name = "btnValidation";
            this.btnValidation.Size = new System.Drawing.Size(108, 23);
            this.btnValidation.TabIndex = 9;
            this.btnValidation.Text = "Valider le compte";
            this.btnValidation.UseVisualStyleBackColor = true;
            this.btnValidation.Click += new System.EventHandler(this.btnValidation_Click);
            // 
            // FormValidationCompte
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(488, 186);
            this.Controls.Add(this.btnValidation);
            this.Controls.Add(this.lblActifClient);
            this.Controls.Add(this.lblMDPClient);
            this.Controls.Add(this.lblLoginClient);
            this.Controls.Add(this.lblDateAboClient);
            this.Controls.Add(this.lblDateNaissanceClient);
            this.Controls.Add(this.lblEmailClient);
            this.Controls.Add(this.lblPrenomClient);
            this.Controls.Add(this.lblNomClient);
            this.Controls.Add(this.cbCompteNonValide);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "FormValidationCompte";
            this.Text = "FormValidationCompte";
            this.Load += new System.EventHandler(this.FormValidationCompte_Load);
            ((System.ComponentModel.ISupportInitialize)(this.bsClient)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cbCompteNonValide;
        private System.Windows.Forms.BindingSource bsClient;
        private System.Windows.Forms.Label lblNomClient;
        private System.Windows.Forms.Label lblPrenomClient;
        private System.Windows.Forms.Label lblEmailClient;
        private System.Windows.Forms.Label lblDateNaissanceClient;
        private System.Windows.Forms.Label lblDateAboClient;
        private System.Windows.Forms.Label lblLoginClient;
        private System.Windows.Forms.Label lblMDPClient;
        private System.Windows.Forms.Label lblActifClient;
        private System.Windows.Forms.Button btnValidation;
    }
}