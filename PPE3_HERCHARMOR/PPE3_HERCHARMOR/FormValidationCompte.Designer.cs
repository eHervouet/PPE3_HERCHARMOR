namespace PPE3_HERCHARMOR
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
            // FormValidationCompte
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(488, 186);
            this.Controls.Add(this.cbCompteNonValide);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "FormValidationCompte";
            this.Text = "FormValidationCompte";
            this.Load += new System.EventHandler(this.FormValidationCompte_Load);
            ((System.ComponentModel.ISupportInitialize)(this.bsClient)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ComboBox cbCompteNonValide;
        private System.Windows.Forms.BindingSource bsClient;
    }
}