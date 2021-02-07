using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestionEtudiant.dao
{
    class DaoSql
    {
        //Gere la Connexion dans Base Donne sqlServer
        private SqlConnection conn;
        //Exection des Requetes
        private SqlCommand cmd;
        //Convertir les Enregistrement de la BD dans un DataSet
        //DataSet est une BD en Memoire Centrale
        //un DataSet est Forme de DataTable
        //DataTable est table(resultat d'une requete Select) de BD en Memoire Centrale
        private SqlDataAdapter da;

        public DaoSql()
        {
            conn = new SqlConnection();
            cmd = new SqlCommand();
            da = new SqlDataAdapter();
        }

        public void OuvrirConnexionBD()
        {
            if (conn.State == ConnectionState.Closed ||
                conn.State == ConnectionState.Broken)
            {
                conn.ConnectionString = @"Data Source=LAPTOP-6SSHAOG7 ; Initial Catalog=gestion_etudiant;Integrated Security=True ";
                conn.Open();
            }

        }

        public void FermerConnexionBD()
        {
            if (conn.State == ConnectionState.Open ||
                conn.State == ConnectionState.Connecting)

            {
                conn.Close();
            }
        }
        public int ExecuteUpdate(string sql)
        {
            int nbreLigne = 0;
            OuvrirConnexionBD();
            cmd.Connection = conn;
            cmd.CommandText = sql;
            nbreLigne = cmd.ExecuteNonQuery();


            FermerConnexionBD();

            return nbreLigne;

        }

        public DataTable ExecuteSelect(string sql)
        {
            OuvrirConnexionBD();
            cmd.Connection = conn;
            cmd.CommandText = sql;
            //DataSet => de Donnee en Memoire Centrale(RAM)
            //DataSet est Forme de DataTable => Table BD
            DataSet ds = new DataSet();
            // A Ajouter
            da.SelectCommand = cmd;
            da.Fill(ds, "result");
            FermerConnexionBD();

            return ds.Tables["result"];
        }

    }


}

