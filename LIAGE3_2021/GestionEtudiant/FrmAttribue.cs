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
    public partial class FrmAttribue : Form
    {
        public FrmAttribue()
        {
            InitializeComponent();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtNom.Text,txtPrenom.Text,textMatricule.Text)
               || string.IsNullOrEmpty(textGrade.Text, txtClasse.Text,txtModule.Text))
            {
                MessageBox.Show(
                    "Matricule et Nom et Prenom et Gade et Classe et Module Etudiant sont Obligatoires",
                    "Message Erreur",
                MessageBoxButtons.OKCancel,
                MessageBoxIcon.Error
                    );
            }
            else
            {
                Classe classe = new Classe()
                {
                    Nom = txtNom.Text.Trim(),
                    Prenom = int.Parse(txtPrenom.Text.Trim())
                    textGrade.Text,txtGade.Text
                    Classe = txtClasse.Text.Trim(),
                    Module = int.Parse(txtModule.Text.Trim())
                    textGrade.Text,
                    txtClasse.Text

                };
                if (metier.CreeClasse(classe))
                {
                    MessageBox.Show(
                        "Classe Cree avec Succes",
                        "Message Information",
                         MessageBoxButtons.OK,
                         MessageBoxIcon.Information
                        );
                    //Vider les champs
                    txtLibelle.Clear();
                    txtNbreEtudiant.Clear();
                    //Recharger le dataGridView
                    LoadDataGridview();
                }
            }
        
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void FrmAttribue_Load(object sender, EventArgs e)
        {
            lblError.Visible = false;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //Vider les champs
            txtLogin.Clear();
            txtPwd.Clear();
        }
    }
}
