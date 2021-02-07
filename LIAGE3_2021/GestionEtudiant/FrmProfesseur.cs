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
   
    public partial class FrmProfesseur : Form
    {
        ServiceEF metier = new ServiceEF();
        public FrmProfesseur()
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void FrmProfesseur_Load(object sender, EventArgs e)
        {
            //1-Changer le comboClasse
            cboClasse.DataSource = metier.ListerClasse();
            cboClasse.DisplayMember = "libelle";
            cboClasse.ValueMember = "id";

            //2-charger le comboGrade
            cboGrade.DataSource = metier.ListerGrade();
            //3-charge le comboModules
            cboModule.DataSource = metier.ListerModule();

        }
        personne prof;
        List<classe> classeEnseignes;
        private void txtMatricule_TextChanged(object sender, EventArgs e)
        {
           if(!string.IsNullOrEmpty(txtMatricule.Text))
           {
               personne prof= metier.ChercherProfesseurParMatricule(txtMatricule.Text.Trim());
                if (prof != null)
                { 
                    txtNomPrenom.Text = prof.nom_complet;
                    //Selectionner le Grade du Professeur
                    cboGrade.SelectedItem = prof.grade;
                    //charger les Classes enseignees par Professeur
                    lboClasseEnsignes.DataSource = metier.ClasseEnseignes(prof);
                    lboClasseEnsignes.DataSource = classeEnseignes;
                    lboClasseEnsignes.DisplayMember = "libelle";
                    //charge les Module Enseignes par un professeur dans une Classe
                    //Classe Seleclectionne
                     classe ClasseSelected =(classe) lboClasseEnsignes.SelectedItem;
                     lboClasseEnsignes.DataSource = metier.ListerModulesProfesseurParClasse(classeSelected,prof);
                }
                else
                {

                    txtNomPrenom.Clear();
                    //Selectionner le Grade du Professeur
                    cboGrade.SelectedIndex = 0;
                }
           }
        }

        private void lboClasseEnsignes_SelectedIndexChanged(object sender, EventArgs e)
        {
            //classe Select 

            lboClasseEnsignes
        }

        private void btnAttribueClasse_Click(object sender, EventArgs e)
        {

        }

        private void btnAddClasse_Click(object sender, EventArgs e)
        {
            /*
             classe classeSelected = (classe) cboClasse.SelectedItem;
            //Ajout une Nouvelle Classe dans la ListeBox de Classe
            ClasseEnsignes.Add(classeSelected);
            //vider DataSource List Box
            lboClasseEnsignes.DataSource = null;
            //charge ListeBox de Classe
            lboClasseEnsignes.DataSource = classeEnseignes;
            lboClasseEnsignes.DisplayMember = "libelle";
            //Selectionner par defaut la classe Ajoutee
            lboClasseEnsignes.SelectedItem = classeSelected;
            */
            //vider DataSource Liste Box Classe
            lboClasseEnsignes.
            //vider DataSource Liste Box Classe
            lboClasseEnsignes.Items.Clear();
            //vider DataSource Liste Box Midule
            lboClasseEnsignes.Items.Clear();

        }
    }
}
