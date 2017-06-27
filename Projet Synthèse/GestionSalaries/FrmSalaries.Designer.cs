namespace GestionSalaraies
{
    partial class FrmSalaries
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
            this.gbDetailsSalaries = new System.Windows.Forms.GroupBox();
            this.gbTypeSalarie = new System.Windows.Forms.GroupBox();
            this.ckbCommercial = new System.Windows.Forms.CheckBox();
            this.ckbSalarie = new System.Windows.Forms.CheckBox();
            this.label4 = new System.Windows.Forms.Label();
            this.gbDetailsCommercial = new System.Windows.Forms.GroupBox();
            this.txtComission = new System.Windows.Forms.TextBox();
            this.lblComission = new System.Windows.Forms.Label();
            this.txtChiffreAffaire = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.panelBT = new System.Windows.Forms.Panel();
            this.btnValider = new System.Windows.Forms.Button();
            this.btnAnnuler = new System.Windows.Forms.Button();
            this.btnModifier = new System.Windows.Forms.Button();
            this.txtTaux = new System.Windows.Forms.TextBox();
            this.txtSalaireBrut = new System.Windows.Forms.TextBox();
            this.txtDateNaissance = new System.Windows.Forms.TextBox();
            this.txtPrenom = new System.Windows.Forms.TextBox();
            this.txtNom = new System.Windows.Forms.TextBox();
            this.lblTauxCS = new System.Windows.Forms.Label();
            this.lblSalaireBrut = new System.Windows.Forms.Label();
            this.lblDateNaissance = new System.Windows.Forms.Label();
            this.lblPrenom = new System.Windows.Forms.Label();
            this.lblNom = new System.Windows.Forms.Label();
            this.txtMatricule = new System.Windows.Forms.TextBox();
            this.lblMatricule = new System.Windows.Forms.Label();
            this.btNouveau = new System.Windows.Forms.Button();
            this.cbSalaries = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.epSalarie = new System.Windows.Forms.ErrorProvider(this.components);
            this.gbDetailsSalaries.SuspendLayout();
            this.gbTypeSalarie.SuspendLayout();
            this.gbDetailsCommercial.SuspendLayout();
            this.panelBT.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.epSalarie)).BeginInit();
            this.SuspendLayout();
            // 
            // gbDetailsSalaries
            // 
            this.gbDetailsSalaries.Controls.Add(this.gbTypeSalarie);
            this.gbDetailsSalaries.Controls.Add(this.label4);
            this.gbDetailsSalaries.Controls.Add(this.gbDetailsCommercial);
            this.gbDetailsSalaries.Controls.Add(this.panelBT);
            this.gbDetailsSalaries.Controls.Add(this.txtTaux);
            this.gbDetailsSalaries.Controls.Add(this.txtSalaireBrut);
            this.gbDetailsSalaries.Controls.Add(this.txtDateNaissance);
            this.gbDetailsSalaries.Controls.Add(this.txtPrenom);
            this.gbDetailsSalaries.Controls.Add(this.txtNom);
            this.gbDetailsSalaries.Controls.Add(this.lblTauxCS);
            this.gbDetailsSalaries.Controls.Add(this.lblSalaireBrut);
            this.gbDetailsSalaries.Controls.Add(this.lblDateNaissance);
            this.gbDetailsSalaries.Controls.Add(this.lblPrenom);
            this.gbDetailsSalaries.Controls.Add(this.lblNom);
            this.gbDetailsSalaries.Controls.Add(this.txtMatricule);
            this.gbDetailsSalaries.Controls.Add(this.lblMatricule);
            this.gbDetailsSalaries.Location = new System.Drawing.Point(37, 67);
            this.gbDetailsSalaries.Name = "gbDetailsSalaries";
            this.gbDetailsSalaries.Size = new System.Drawing.Size(409, 474);
            this.gbDetailsSalaries.TabIndex = 7;
            this.gbDetailsSalaries.TabStop = false;
            this.gbDetailsSalaries.Text = "Details salaries";
            // 
            // gbTypeSalarie
            // 
            this.gbTypeSalarie.Controls.Add(this.ckbCommercial);
            this.gbTypeSalarie.Controls.Add(this.ckbSalarie);
            this.gbTypeSalarie.Location = new System.Drawing.Point(111, 19);
            this.gbTypeSalarie.Name = "gbTypeSalarie";
            this.gbTypeSalarie.Size = new System.Drawing.Size(269, 58);
            this.gbTypeSalarie.TabIndex = 17;
            this.gbTypeSalarie.TabStop = false;
            this.gbTypeSalarie.Text = "Type salarié";
            // 
            // ckbCommercial
            // 
            this.ckbCommercial.AutoSize = true;
            this.ckbCommercial.Location = new System.Drawing.Point(120, 29);
            this.ckbCommercial.Name = "ckbCommercial";
            this.ckbCommercial.Size = new System.Drawing.Size(80, 17);
            this.ckbCommercial.TabIndex = 1;
            this.ckbCommercial.Text = "Commercial";
            this.ckbCommercial.UseVisualStyleBackColor = true;
            // 
            // ckbSalarie
            // 
            this.ckbSalarie.AutoSize = true;
            this.ckbSalarie.Location = new System.Drawing.Point(17, 29);
            this.ckbSalarie.Name = "ckbSalarie";
            this.ckbSalarie.Size = new System.Drawing.Size(58, 17);
            this.ckbSalarie.TabIndex = 0;
            this.ckbSalarie.Text = "Salarié";
            this.ckbSalarie.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(22, 52);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(70, 13);
            this.label4.TabIndex = 16;
            this.label4.Text = "Type salarié :";
            // 
            // gbDetailsCommercial
            // 
            this.gbDetailsCommercial.Controls.Add(this.txtComission);
            this.gbDetailsCommercial.Controls.Add(this.lblComission);
            this.gbDetailsCommercial.Controls.Add(this.txtChiffreAffaire);
            this.gbDetailsCommercial.Controls.Add(this.label3);
            this.gbDetailsCommercial.Location = new System.Drawing.Point(0, 291);
            this.gbDetailsCommercial.Name = "gbDetailsCommercial";
            this.gbDetailsCommercial.Size = new System.Drawing.Size(409, 89);
            this.gbDetailsCommercial.TabIndex = 13;
            this.gbDetailsCommercial.TabStop = false;
            this.gbDetailsCommercial.Text = "Details commercial";
            // 
            // txtComission
            // 
            this.txtComission.Location = new System.Drawing.Point(108, 57);
            this.txtComission.Name = "txtComission";
            this.txtComission.Size = new System.Drawing.Size(180, 20);
            this.txtComission.TabIndex = 11;
            // 
            // lblComission
            // 
            this.lblComission.AutoSize = true;
            this.lblComission.Location = new System.Drawing.Point(19, 57);
            this.lblComission.Name = "lblComission";
            this.lblComission.Size = new System.Drawing.Size(60, 13);
            this.lblComission.TabIndex = 10;
            this.lblComission.Text = "Comission :";
            // 
            // txtChiffreAffaire
            // 
            this.txtChiffreAffaire.Location = new System.Drawing.Point(108, 27);
            this.txtChiffreAffaire.Name = "txtChiffreAffaire";
            this.txtChiffreAffaire.Size = new System.Drawing.Size(180, 20);
            this.txtChiffreAffaire.TabIndex = 9;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(19, 30);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(83, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "Chiffre d\'affaire :";
            // 
            // panelBT
            // 
            this.panelBT.Controls.Add(this.btnValider);
            this.panelBT.Controls.Add(this.btnAnnuler);
            this.panelBT.Controls.Add(this.btnModifier);
            this.panelBT.Location = new System.Drawing.Point(22, 389);
            this.panelBT.Name = "panelBT";
            this.panelBT.Size = new System.Drawing.Size(358, 70);
            this.panelBT.TabIndex = 12;
            // 
            // btnValider
            // 
            this.btnValider.Location = new System.Drawing.Point(236, 24);
            this.btnValider.Name = "btnValider";
            this.btnValider.Size = new System.Drawing.Size(75, 23);
            this.btnValider.TabIndex = 2;
            this.btnValider.Text = "Valider";
            this.btnValider.UseVisualStyleBackColor = true;
            this.btnValider.Click += new System.EventHandler(this.btnValider_Click);
            // 
            // btnAnnuler
            // 
            this.btnAnnuler.Location = new System.Drawing.Point(129, 24);
            this.btnAnnuler.Name = "btnAnnuler";
            this.btnAnnuler.Size = new System.Drawing.Size(75, 23);
            this.btnAnnuler.TabIndex = 1;
            this.btnAnnuler.Text = "Annuler";
            this.btnAnnuler.UseVisualStyleBackColor = true;
            this.btnAnnuler.Click += new System.EventHandler(this.btnAnnuler_Click);
            // 
            // btnModifier
            // 
            this.btnModifier.Location = new System.Drawing.Point(25, 23);
            this.btnModifier.Name = "btnModifier";
            this.btnModifier.Size = new System.Drawing.Size(75, 23);
            this.btnModifier.TabIndex = 0;
            this.btnModifier.Text = "Modifier";
            this.btnModifier.UseVisualStyleBackColor = true;
            this.btnModifier.Click += new System.EventHandler(this.btnModifier_Click);
            // 
            // txtTaux
            // 
            this.txtTaux.Location = new System.Drawing.Point(111, 255);
            this.txtTaux.Name = "txtTaux";
            this.txtTaux.Size = new System.Drawing.Size(180, 20);
            this.txtTaux.TabIndex = 11;
            // 
            // txtSalaireBrut
            // 
            this.txtSalaireBrut.Location = new System.Drawing.Point(111, 223);
            this.txtSalaireBrut.Name = "txtSalaireBrut";
            this.txtSalaireBrut.Size = new System.Drawing.Size(180, 20);
            this.txtSalaireBrut.TabIndex = 10;
            // 
            // txtDateNaissance
            // 
            this.txtDateNaissance.Location = new System.Drawing.Point(111, 187);
            this.txtDateNaissance.Name = "txtDateNaissance";
            this.txtDateNaissance.Size = new System.Drawing.Size(180, 20);
            this.txtDateNaissance.TabIndex = 9;
            // 
            // txtPrenom
            // 
            this.txtPrenom.Location = new System.Drawing.Point(111, 157);
            this.txtPrenom.Name = "txtPrenom";
            this.txtPrenom.Size = new System.Drawing.Size(180, 20);
            this.txtPrenom.TabIndex = 8;
            // 
            // txtNom
            // 
            this.txtNom.Location = new System.Drawing.Point(111, 127);
            this.txtNom.Name = "txtNom";
            this.txtNom.Size = new System.Drawing.Size(180, 20);
            this.txtNom.TabIndex = 7;
            // 
            // lblTauxCS
            // 
            this.lblTauxCS.AutoSize = true;
            this.lblTauxCS.Location = new System.Drawing.Point(22, 257);
            this.lblTauxCS.Name = "lblTauxCS";
            this.lblTauxCS.Size = new System.Drawing.Size(82, 13);
            this.lblTauxCS.TabIndex = 6;
            this.lblTauxCS.Text = "Taux Charges  :";
            // 
            // lblSalaireBrut
            // 
            this.lblSalaireBrut.AutoSize = true;
            this.lblSalaireBrut.Location = new System.Drawing.Point(22, 223);
            this.lblSalaireBrut.Name = "lblSalaireBrut";
            this.lblSalaireBrut.Size = new System.Drawing.Size(66, 13);
            this.lblSalaireBrut.TabIndex = 5;
            this.lblSalaireBrut.Text = "Salaire brut :";
            // 
            // lblDateNaissance
            // 
            this.lblDateNaissance.AutoSize = true;
            this.lblDateNaissance.Location = new System.Drawing.Point(22, 190);
            this.lblDateNaissance.Name = "lblDateNaissance";
            this.lblDateNaissance.Size = new System.Drawing.Size(89, 13);
            this.lblDateNaissance.TabIndex = 4;
            this.lblDateNaissance.Text = "Date Naissance :";
            // 
            // lblPrenom
            // 
            this.lblPrenom.AutoSize = true;
            this.lblPrenom.Location = new System.Drawing.Point(22, 157);
            this.lblPrenom.Name = "lblPrenom";
            this.lblPrenom.Size = new System.Drawing.Size(49, 13);
            this.lblPrenom.TabIndex = 3;
            this.lblPrenom.Text = "Prenom :";
            // 
            // lblNom
            // 
            this.lblNom.AutoSize = true;
            this.lblNom.Location = new System.Drawing.Point(22, 127);
            this.lblNom.Name = "lblNom";
            this.lblNom.Size = new System.Drawing.Size(35, 13);
            this.lblNom.TabIndex = 2;
            this.lblNom.Text = "Nom :";
            // 
            // txtMatricule
            // 
            this.txtMatricule.Location = new System.Drawing.Point(111, 97);
            this.txtMatricule.Name = "txtMatricule";
            this.txtMatricule.Size = new System.Drawing.Size(180, 20);
            this.txtMatricule.TabIndex = 1;
            // 
            // lblMatricule
            // 
            this.lblMatricule.AutoSize = true;
            this.lblMatricule.Location = new System.Drawing.Point(22, 100);
            this.lblMatricule.Name = "lblMatricule";
            this.lblMatricule.Size = new System.Drawing.Size(56, 13);
            this.lblMatricule.TabIndex = 0;
            this.lblMatricule.Text = "Matricule :";
            // 
            // btNouveau
            // 
            this.btNouveau.Location = new System.Drawing.Point(355, 22);
            this.btNouveau.Name = "btNouveau";
            this.btNouveau.Size = new System.Drawing.Size(91, 26);
            this.btNouveau.TabIndex = 6;
            this.btNouveau.Text = "Nouveau";
            this.btNouveau.UseVisualStyleBackColor = true;
            this.btNouveau.Click += new System.EventHandler(this.btNouveau_Click);
            // 
            // cbSalaries
            // 
            this.cbSalaries.FormattingEnabled = true;
            this.cbSalaries.Location = new System.Drawing.Point(145, 22);
            this.cbSalaries.Name = "cbSalaries";
            this.cbSalaries.Size = new System.Drawing.Size(183, 21);
            this.cbSalaries.TabIndex = 5;
            this.cbSalaries.SelectedIndexChanged += new System.EventHandler(this.cbSalaries_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(34, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(86, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Choisir un salarie";
            // 
            // epSalarie
            // 
            this.epSalarie.ContainerControl = this;
            // 
            // FrmSalaries
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(517, 621);
            this.Controls.Add(this.gbDetailsSalaries);
            this.Controls.Add(this.btNouveau);
            this.Controls.Add(this.cbSalaries);
            this.Controls.Add(this.label1);
            this.Name = "FrmSalaries";
            this.Text = "Gestion salaries";
            this.Load += new System.EventHandler(this.FrmSalaries_Load);
            this.gbDetailsSalaries.ResumeLayout(false);
            this.gbDetailsSalaries.PerformLayout();
            this.gbTypeSalarie.ResumeLayout(false);
            this.gbTypeSalarie.PerformLayout();
            this.gbDetailsCommercial.ResumeLayout(false);
            this.gbDetailsCommercial.PerformLayout();
            this.panelBT.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.epSalarie)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox gbDetailsSalaries;
        private System.Windows.Forms.Panel panelBT;
        private System.Windows.Forms.Button btnValider;
        private System.Windows.Forms.Button btnAnnuler;
        private System.Windows.Forms.Button btnModifier;
        private System.Windows.Forms.TextBox txtTaux;
        private System.Windows.Forms.TextBox txtSalaireBrut;
        private System.Windows.Forms.TextBox txtDateNaissance;
        private System.Windows.Forms.TextBox txtPrenom;
        private System.Windows.Forms.TextBox txtNom;
        private System.Windows.Forms.Label lblTauxCS;
        private System.Windows.Forms.Label lblSalaireBrut;
        private System.Windows.Forms.Label lblDateNaissance;
        private System.Windows.Forms.Label lblPrenom;
        private System.Windows.Forms.Label lblNom;
        private System.Windows.Forms.Button btNouveau;
        private System.Windows.Forms.ComboBox cbSalaries;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtMatricule;
        private System.Windows.Forms.Label lblMatricule;
        private System.Windows.Forms.ErrorProvider epSalarie;
        private System.Windows.Forms.GroupBox gbDetailsCommercial;
        private System.Windows.Forms.TextBox txtComission;
        private System.Windows.Forms.Label lblComission;
        private System.Windows.Forms.TextBox txtChiffreAffaire;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.CheckBox ckbCommercial;
        private System.Windows.Forms.CheckBox ckbSalarie;
        private System.Windows.Forms.GroupBox gbTypeSalarie;
    }
}