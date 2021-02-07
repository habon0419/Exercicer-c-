namespace GestionEtudiant
{
    partial class FrmMenu
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.classeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.crreClasseToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.atribueToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.etudianToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.inscriptionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.classeProfesseurToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.classeToolStripMenuItem,
            this.etudianToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 40);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // classeToolStripMenuItem
            // 
            this.classeToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.crreClasseToolStripMenuItem,
            this.atribueToolStripMenuItem});
            this.classeToolStripMenuItem.Name = "classeToolStripMenuItem";
            this.classeToolStripMenuItem.Size = new System.Drawing.Size(93, 36);
            this.classeToolStripMenuItem.Text = "Classe";
            // 
            // crreClasseToolStripMenuItem
            // 
            this.crreClasseToolStripMenuItem.Name = "crreClasseToolStripMenuItem";
            this.crreClasseToolStripMenuItem.Size = new System.Drawing.Size(255, 36);
            this.crreClasseToolStripMenuItem.Text = "Creer Classe";
            this.crreClasseToolStripMenuItem.Click += new System.EventHandler(this.crreClasseToolStripMenuItem_Click);
            // 
            // atribueToolStripMenuItem
            // 
            this.atribueToolStripMenuItem.Name = "atribueToolStripMenuItem";
            this.atribueToolStripMenuItem.Size = new System.Drawing.Size(255, 36);
            this.atribueToolStripMenuItem.Text = "Attribue Classe";
            this.atribueToolStripMenuItem.Click += new System.EventHandler(this.atribueToolStripMenuItem_Click);
            // 
            // etudianToolStripMenuItem
            // 
            this.etudianToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.inscriptionToolStripMenuItem,
            this.classeProfesseurToolStripMenuItem});
            this.etudianToolStripMenuItem.Name = "etudianToolStripMenuItem";
            this.etudianToolStripMenuItem.Size = new System.Drawing.Size(115, 36);
            this.etudianToolStripMenuItem.Text = "Etudiant";
            // 
            // inscriptionToolStripMenuItem
            // 
            this.inscriptionToolStripMenuItem.Name = "inscriptionToolStripMenuItem";
            this.inscriptionToolStripMenuItem.Size = new System.Drawing.Size(280, 36);
            this.inscriptionToolStripMenuItem.Text = "Inscription ";
            this.inscriptionToolStripMenuItem.Click += new System.EventHandler(this.inscriptionToolStripMenuItem_Click);
            // 
            // classeProfesseurToolStripMenuItem
            // 
            this.classeProfesseurToolStripMenuItem.Name = "classeProfesseurToolStripMenuItem";
            this.classeProfesseurToolStripMenuItem.Size = new System.Drawing.Size(280, 36);
            this.classeProfesseurToolStripMenuItem.Text = "Classe Professeur";
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.Dock = System.Windows.Forms.DockStyle.Right;
            this.linkLabel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.linkLabel1.Location = new System.Drawing.Point(646, 40);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(154, 29);
            this.linkLabel1.TabIndex = 1;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "Deconnexion";
            this.linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // FrmMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.linkLabel1);
            this.Controls.Add(this.menuStrip1);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "FrmMenu";
            this.Text = "Gestion Etudiant";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FrmMenu_FormClosed);
            this.Load += new System.EventHandler(this.FrmMenu_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem classeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem crreClasseToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem atribueToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem etudianToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem inscriptionToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem classeProfesseurToolStripMenuItem;
        private System.Windows.Forms.LinkLabel linkLabel1;
    }
}