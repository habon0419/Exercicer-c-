namespace GestionEtudiant
{
    partial class FrmProfesseur
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
            this.label1 = new System.Windows.Forms.Label();
            this.txtNomPrenom = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cboClasse = new System.Windows.Forms.ComboBox();
            this.txtMatricule = new System.Windows.Forms.TextBox();
            this.cboGrade = new System.Windows.Forms.ComboBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label4 = new System.Windows.Forms.Label();
            this.cboModule = new System.Windows.Forms.ComboBox();
            this.btnAdd = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.lboModulesEnsignes = new System.Windows.Forms.ListBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.lboClasseEnsignes = new System.Windows.Forms.ListBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textNomPrenom = new System.Windows.Forms.TextBox();
            this.btnAttribueClasse = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.btnAddClasse = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 43);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Matricule";
            // 
            // txtNomPrenom
            // 
            this.txtNomPrenom.AutoSize = true;
            this.txtNomPrenom.Location = new System.Drawing.Point(6, 108);
            this.txtNomPrenom.Name = "txtNomPrenom";
            this.txtNomPrenom.Size = new System.Drawing.Size(106, 17);
            this.txtNomPrenom.TabIndex = 1;
            this.txtNomPrenom.Text = "Nom et Prenom";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(408, 43);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(48, 17);
            this.label3.TabIndex = 2;
            this.label3.Text = "Grade";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnAddClasse);
            this.groupBox1.Controls.Add(this.textNomPrenom);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.cboGrade);
            this.groupBox1.Controls.Add(this.txtMatricule);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.cboClasse);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.txtNomPrenom);
            this.groupBox1.Location = new System.Drawing.Point(22, 25);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(829, 172);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "groupBox1";
            // 
            // cboClasse
            // 
            this.cboClasse.FormattingEnabled = true;
            this.cboClasse.Location = new System.Drawing.Point(488, 106);
            this.cboClasse.Name = "cboClasse";
            this.cboClasse.Size = new System.Drawing.Size(246, 24);
            this.cboClasse.TabIndex = 2;
            // 
            // txtMatricule
            // 
            this.txtMatricule.Location = new System.Drawing.Point(118, 38);
            this.txtMatricule.Name = "txtMatricule";
            this.txtMatricule.Size = new System.Drawing.Size(232, 22);
            this.txtMatricule.TabIndex = 3;
            this.txtMatricule.TextChanged += new System.EventHandler(this.txtMatricule_TextChanged);
            // 
            // cboGrade
            // 
            this.cboGrade.FormattingEnabled = true;
            this.cboGrade.Location = new System.Drawing.Point(488, 43);
            this.cboGrade.Name = "cboGrade";
            this.cboGrade.Size = new System.Drawing.Size(246, 24);
            this.cboGrade.TabIndex = 4;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.lboModulesEnsignes);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.btnAdd);
            this.groupBox2.Controls.Add(this.cboModule);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Location = new System.Drawing.Point(22, 214);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(456, 304);
            this.groupBox2.TabIndex = 4;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Modules";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 50);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(61, 17);
            this.label4.TabIndex = 0;
            this.label4.Text = "Modules";
            // 
            // cboModule
            // 
            this.cboModule.FormattingEnabled = true;
            this.cboModule.Location = new System.Drawing.Point(97, 43);
            this.cboModule.Name = "cboModule";
            this.cboModule.Size = new System.Drawing.Size(261, 24);
            this.cboModule.TabIndex = 1;
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(364, 43);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(77, 30);
            this.btnAdd.TabIndex = 2;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 114);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(131, 17);
            this.label5.TabIndex = 3;
            this.label5.Text = "Modules Ensignees";
            // 
            // lboModulesEnsignes
            // 
            this.lboModulesEnsignes.FormattingEnabled = true;
            this.lboModulesEnsignes.ItemHeight = 16;
            this.lboModulesEnsignes.Location = new System.Drawing.Point(97, 162);
            this.lboModulesEnsignes.Name = "lboModulesEnsignes";
            this.lboModulesEnsignes.Size = new System.Drawing.Size(223, 100);
            this.lboModulesEnsignes.TabIndex = 4;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.lboClasseEnsignes);
            this.groupBox3.Location = new System.Drawing.Point(484, 203);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(399, 286);
            this.groupBox3.TabIndex = 5;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Classe Enseignees";
            // 
            // lboClasseEnsignes
            // 
            this.lboClasseEnsignes.FormattingEnabled = true;
            this.lboClasseEnsignes.ItemHeight = 16;
            this.lboClasseEnsignes.Location = new System.Drawing.Point(26, 34);
            this.lboClasseEnsignes.Name = "lboClasseEnsignes";
            this.lboClasseEnsignes.Size = new System.Drawing.Size(294, 228);
            this.lboClasseEnsignes.TabIndex = 4;
            this.lboClasseEnsignes.SelectedIndexChanged += new System.EventHandler(this.lboClasseEnsignes_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(411, 105);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(50, 17);
            this.label2.TabIndex = 5;
            this.label2.Text = "Classe";
            // 
            // textNomPrenom
            // 
            this.textNomPrenom.Location = new System.Drawing.Point(118, 106);
            this.textNomPrenom.Name = "textNomPrenom";
            this.textNomPrenom.Size = new System.Drawing.Size(232, 22);
            this.textNomPrenom.TabIndex = 6;
            // 
            // btnAttribueClasse
            // 
            this.btnAttribueClasse.Location = new System.Drawing.Point(857, 69);
            this.btnAttribueClasse.Name = "btnAttribueClasse";
            this.btnAttribueClasse.Size = new System.Drawing.Size(75, 23);
            this.btnAttribueClasse.TabIndex = 7;
            this.btnAttribueClasse.Text = "Attribuer";
            this.btnAttribueClasse.UseVisualStyleBackColor = true;
            this.btnAttribueClasse.Click += new System.EventHandler(this.btnAttribueClasse_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(857, 133);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 8;
            this.button3.Text = "Annuler";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // btnAddClasse
            // 
            this.btnAddClasse.Location = new System.Drawing.Point(746, 100);
            this.btnAddClasse.Name = "btnAddClasse";
            this.btnAddClasse.Size = new System.Drawing.Size(77, 30);
            this.btnAddClasse.TabIndex = 5;
            this.btnAddClasse.Text = "Add";
            this.btnAddClasse.UseVisualStyleBackColor = true;
            this.btnAddClasse.Click += new System.EventHandler(this.btnAddClasse_Click);
            // 
            // FrmProfesseur
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(932, 530);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.btnAttribueClasse);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmProfesseur";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Gestion Etudiant";
            this.Load += new System.EventHandler(this.FrmProfesseur_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label txtNomPrenom;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox cboGrade;
        private System.Windows.Forms.TextBox txtMatricule;
        private System.Windows.Forms.ComboBox cboClasse;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ListBox lboModulesEnsignes;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.ComboBox cboModule;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.ListBox lboClasseEnsignes;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button btnAttribueClasse;
        private System.Windows.Forms.TextBox textNomPrenom;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnAddClasse;
    }
}