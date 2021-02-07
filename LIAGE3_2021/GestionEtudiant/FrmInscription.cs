using GestionEtudiant.models;
using GestionEtudiant.services;
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
    public partial class FrmInscription : Form
    {
        private ServiceEF metierEF = new ServiceEF();
        public FrmInscription()
        {
            InitializeComponent();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void FrmInscription_Load(object sender, EventArgs e)
        {
            //Changer le comboClasse
            cboClasse.DataSource = metier.ListerClasse();
            cboClasse.DisplayMember = "libelle";
            cboClasse.ValueMember = "id";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtNomPrenom.Text)
               || string.IsNullOrEmpty(txtTuteur.Text))
            {
                MessageBox.Show(
                    "Champs Obligatoires",
                    "Erreur",
                MessageBoxButtons.OKCancel,
                MessageBoxIcon.Error
                    );
            }
            else
            {
                Personne pers = new Personne()
                {
                    nom_complet = txtNomPrenom.Text.Trim(),
                    tuteur = txtTuteur.Text.Trim(),
                    type = "Etudiant",
                    classe_id = int.Parse(cboClasse.SelectedValue.ToString())

                };
                if (metierEF.CreerPersonne(pers))
                {
                    MessageBox.Show(
                        "Champs D'inscription",
                        "Erreur",
                         MessageBoxButtons.OK,
                         MessageBoxIcon.Error
                        );
                    
                }
            }
    }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
