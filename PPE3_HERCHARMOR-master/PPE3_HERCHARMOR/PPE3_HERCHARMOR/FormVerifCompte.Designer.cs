namespace PPE3_HERCHARMOR
{
    partial class FormVerifCompte
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormVerifCompte));
            this.bnVerifCompte = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
            this.lblNomClient = new System.Windows.Forms.Label();
            this.lblPrenomClient = new System.Windows.Forms.Label();
            this.lblEmailClient = new System.Windows.Forms.Label();
            this.lblDateNaissanceClient = new System.Windows.Forms.Label();
            this.lblDateAboClient = new System.Windows.Forms.Label();
            this.lblLoginClient = new System.Windows.Forms.Label();
            this.lblMDPClient = new System.Windows.Forms.Label();
            this.lblActifClient = new System.Windows.Forms.Label();
            this.bsClient = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.bnVerifCompte)).BeginInit();
            this.bnVerifCompte.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bsClient)).BeginInit();
            this.SuspendLayout();
            // 
            // bnVerifCompte
            // 
            this.bnVerifCompte.AddNewItem = this.bindingNavigatorAddNewItem;
            this.bnVerifCompte.BindingSource = this.bsClient;
            this.bnVerifCompte.CountItem = this.bindingNavigatorCountItem;
            this.bnVerifCompte.DeleteItem = this.bindingNavigatorDeleteItem;
            this.bnVerifCompte.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorMoveFirstItem,
            this.bindingNavigatorMovePreviousItem,
            this.bindingNavigatorSeparator,
            this.bindingNavigatorPositionItem,
            this.bindingNavigatorCountItem,
            this.bindingNavigatorSeparator1,
            this.bindingNavigatorMoveNextItem,
            this.bindingNavigatorMoveLastItem,
            this.bindingNavigatorSeparator2,
            this.bindingNavigatorAddNewItem,
            this.bindingNavigatorDeleteItem});
            this.bnVerifCompte.Location = new System.Drawing.Point(0, 0);
            this.bnVerifCompte.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.bnVerifCompte.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.bnVerifCompte.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.bnVerifCompte.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.bnVerifCompte.Name = "bnVerifCompte";
            this.bnVerifCompte.PositionItem = this.bindingNavigatorPositionItem;
            this.bnVerifCompte.Size = new System.Drawing.Size(488, 25);
            this.bnVerifCompte.TabIndex = 0;
            this.bnVerifCompte.Text = "bindingNavigator1";
            // 
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveFirstItem.Text = "Placer en premier";
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMovePreviousItem.Text = "Déplacer vers le haut";
            // 
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorPositionItem
            // 
            this.bindingNavigatorPositionItem.AccessibleName = "Position";
            this.bindingNavigatorPositionItem.AutoSize = false;
            this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(50, 23);
            this.bindingNavigatorPositionItem.Text = "0";
            this.bindingNavigatorPositionItem.ToolTipText = "Position actuelle";
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(37, 22);
            this.bindingNavigatorCountItem.Text = "de {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Nombre total d\'éléments";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveNextItem.Text = "Déplacer vers le bas";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveLastItem.Text = "Placer en dernier";
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorAddNewItem
            // 
            this.bindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorAddNewItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorAddNewItem.Image")));
            this.bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
            this.bindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorAddNewItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorAddNewItem.Text = "Ajouter nouveau";
            // 
            // bindingNavigatorDeleteItem
            // 
            this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorDeleteItem.Text = "Supprimer";
            // 
            // lblNomClient
            // 
            this.lblNomClient.AutoSize = true;
            this.lblNomClient.Location = new System.Drawing.Point(12, 51);
            this.lblNomClient.Name = "lblNomClient";
            this.lblNomClient.Size = new System.Drawing.Size(65, 13);
            this.lblNomClient.TabIndex = 2;
            this.lblNomClient.Text = "lblNomClient";
            // 
            // lblPrenomClient
            // 
            this.lblPrenomClient.AutoSize = true;
            this.lblPrenomClient.Location = new System.Drawing.Point(12, 78);
            this.lblPrenomClient.Name = "lblPrenomClient";
            this.lblPrenomClient.Size = new System.Drawing.Size(79, 13);
            this.lblPrenomClient.TabIndex = 3;
            this.lblPrenomClient.Text = "lblPrenomClient";
            // 
            // lblEmailClient
            // 
            this.lblEmailClient.AutoSize = true;
            this.lblEmailClient.Location = new System.Drawing.Point(12, 103);
            this.lblEmailClient.Name = "lblEmailClient";
            this.lblEmailClient.Size = new System.Drawing.Size(68, 13);
            this.lblEmailClient.TabIndex = 4;
            this.lblEmailClient.Text = "lblEmailClient";
            // 
            // lblDateNaissanceClient
            // 
            this.lblDateNaissanceClient.AutoSize = true;
            this.lblDateNaissanceClient.Location = new System.Drawing.Point(12, 127);
            this.lblDateNaissanceClient.Name = "lblDateNaissanceClient";
            this.lblDateNaissanceClient.Size = new System.Drawing.Size(116, 13);
            this.lblDateNaissanceClient.TabIndex = 5;
            this.lblDateNaissanceClient.Text = "lblDateNaissanceClient";
            // 
            // lblDateAboClient
            // 
            this.lblDateAboClient.AutoSize = true;
            this.lblDateAboClient.Location = new System.Drawing.Point(224, 51);
            this.lblDateAboClient.Name = "lblDateAboClient";
            this.lblDateAboClient.Size = new System.Drawing.Size(85, 13);
            this.lblDateAboClient.TabIndex = 6;
            this.lblDateAboClient.Text = "lblDateAboClient";
            // 
            // lblLoginClient
            // 
            this.lblLoginClient.AutoSize = true;
            this.lblLoginClient.Location = new System.Drawing.Point(224, 78);
            this.lblLoginClient.Name = "lblLoginClient";
            this.lblLoginClient.Size = new System.Drawing.Size(69, 13);
            this.lblLoginClient.TabIndex = 7;
            this.lblLoginClient.Text = "lblLoginClient";
            // 
            // lblMDPClient
            // 
            this.lblMDPClient.AutoSize = true;
            this.lblMDPClient.Location = new System.Drawing.Point(224, 103);
            this.lblMDPClient.Name = "lblMDPClient";
            this.lblMDPClient.Size = new System.Drawing.Size(67, 13);
            this.lblMDPClient.TabIndex = 8;
            this.lblMDPClient.Text = "lblMDPClient";
            // 
            // lblActifClient
            // 
            this.lblActifClient.AutoSize = true;
            this.lblActifClient.Location = new System.Drawing.Point(224, 127);
            this.lblActifClient.Name = "lblActifClient";
            this.lblActifClient.Size = new System.Drawing.Size(64, 13);
            this.lblActifClient.TabIndex = 9;
            this.lblActifClient.Text = "lblActifClient";
            // 
            // bsClient
            // 
            this.bsClient.DataSource = typeof(PPE3_HERCHARMOR.client);
            this.bsClient.CurrentChanged += new System.EventHandler(this.bsClient_CurrentChanged);
            // 
            // FormVerifCompte
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(488, 186);
            this.Controls.Add(this.lblActifClient);
            this.Controls.Add(this.lblMDPClient);
            this.Controls.Add(this.lblLoginClient);
            this.Controls.Add(this.lblDateAboClient);
            this.Controls.Add(this.lblDateNaissanceClient);
            this.Controls.Add(this.lblEmailClient);
            this.Controls.Add(this.lblPrenomClient);
            this.Controls.Add(this.lblNomClient);
            this.Controls.Add(this.bnVerifCompte);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "FormVerifCompte";
            this.Text = "FormVerifCompte";
            this.Load += new System.EventHandler(this.FormVerifCompte_Load);
            ((System.ComponentModel.ISupportInitialize)(this.bnVerifCompte)).EndInit();
            this.bnVerifCompte.ResumeLayout(false);
            this.bnVerifCompte.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bsClient)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.BindingNavigator bnVerifCompte;
        private System.Windows.Forms.ToolStripButton bindingNavigatorAddNewItem;
        private System.Windows.Forms.BindingSource bsClient;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorDeleteItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
        private System.Windows.Forms.Label lblNomClient;
        private System.Windows.Forms.Label lblPrenomClient;
        private System.Windows.Forms.Label lblEmailClient;
        private System.Windows.Forms.Label lblDateNaissanceClient;
        private System.Windows.Forms.Label lblDateAboClient;
        private System.Windows.Forms.Label lblLoginClient;
        private System.Windows.Forms.Label lblMDPClient;
        private System.Windows.Forms.Label lblActifClient;
    }
}