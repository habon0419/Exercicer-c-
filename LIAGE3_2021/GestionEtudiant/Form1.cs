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
    public partial class Form1 : Form
    {
        private Service metier = new Service();

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            LoadDataGridview();
        }

        private void LoadDataGridview()
        {
            dtgvClasses.DataSource = metier.ListerClasse();
        }

        private void groupBox3_Enter(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
           
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void btnAjouter_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtLibelle.Text)
                || string.IsNullOrEmpty(txtNbreEtudiant.Text))
            {
                MessageBox.Show(
                    "Libelle ou Nbre Etudiant sont Obligatoires",
                    "Message Erreur",
                MessageBoxButtons.OKCancel,
                MessageBoxIcon.Error
                    );
            }
            else
            {
                Classe classe = new Classe()
                {
                    Libelle = txtLibelle.Text.Trim(),
                    NbreEtudiant = int.Parse(txtNbreEtudiant.Text.Trim())

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

        private void dtgvClasses_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            
            //e.RowIndex: index de la Ligne S electionnee
            //1-Recuper la Ligne Selectionnee
            DataGridViewRow row = dtgvClasses.Rows[e.RowIndex];
            //2-Selectionner Toute la Ligne
            row.Selected = true;
            //3-Recuperation de l'Id Classe
            //row.Cells:Recupere les Cellules de la Ligne
            int id = int.Parse(row.Cells[0].Value.ToString());
            Classe classe = new Classe()
            {
                Id = id
            };
            //charge le   dtgvEtudiant
            dtgvEtudiant.DataSource = metier.ListerEtudiantParClasse(classe);
        }
    }
}
