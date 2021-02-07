using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GestionEtudiant
{
    public partial class FrmMenu : Form
    {
        public FrmMenu()
        {
            InitializeComponent();
        }

        private void atribueToolStripMenuItem_Click(object sender, EventArgs e)
        {
            EffacerFormFils();
            FrmProfesseur frm = new FrmProfesseur();
            frm.MdiParent = this;
            frm.Show();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            FrmConnexion frmConnexion = new FrmConnexion();
            frmConnexion.Show();
            this.Hide();
        }

        private void FrmMenu_Load(object sender, EventArgs e)
        {

        }

        

        private void crreClasseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LoadFormcrreClasse();
        }

        private void LoadFormcrreClasse()
        {
            EffacerFormFils();
            Form1 frmcrreClasse = new Form1();
            frmcrreClasse.MdiParent = this;
            frmcrreClasse.Show();
        }

        private void EffacerFormFils()
        {
            foreach(Form form in this.MdiChildren)
            {
                form.Close();
            }
        }


        private void FrmMenu_FormClosed(object sender, FormClosedEventArgs e)
        {
            OvrirFenetreConnexion();
        }

        public void OvrirFenetreConnexion()
        {
            FrmConnexion frmConnexion = new FrmConnexion();
            frmConnexion.Show();
            this.Hide();
        }

        private void inscriptionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            EffacerFormFils();
            FrmInscription frm = new FrmInscription();
            frm.MdiParent = this;
            frm.Show();
        }
    }

}
