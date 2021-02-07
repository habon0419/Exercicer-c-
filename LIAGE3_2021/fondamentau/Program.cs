using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GestionEtudiant.dao;
using GestionEtudiant.models;

namespace Fondamentaux
{
    class Program
    {
        static void Main(string[] args)
        {


            #region  Fondamentaux      


            /*
             * Varaible

            int id = 1;
            double qte = 4.5;
            bool result = true;
            String Chaine = "Bonjour";
            String Chaine2 = "Bonjour";

            Console.WriteLine("id:" + id);
            Console.WriteLine("qqte:" + qte);
            //chaine formate
            Console.WriteLine(string.Format("String.FormatResult : {0}", result, Chaine));
            //Fonctions sur les chaines
            //string.IsNullOrEmpty(chaine) return true si chaine est vide
            if (string.IsNullOrEmpty(Chaine))
            {
                Console.WriteLine("Chaine est Vide ou Nulle");
            }
            else
            {
                //string.IsNullOrEmpty(chaine)
                Console.WriteLine("Chaine n'est Vide pas et Nulle");
            }
            //trim():enlever les espaces en debut et fin de chaine
            Console.WriteLine(Chaine2.Trim())
            Console.ReadKey();
            */
            #endregion
            #region Test DaoClasse
            // 1-Creer un objet  DaoClasse
            DaoClasse dao = new DaoClasse();
            Classe classe = new Classe()
            {
                Libelle = "LIAGE3",
                NbreEtudiant = 30
            };

            //2-insert()
            dao.Insert(classe);
            //3-findAllClasse() et Afficher
            List<Classe> classes = dao.FindAll();
            foreach (var cl in classes)
            {
                Console.WriteLine(cl);
            }


            #endregion

        }
    }

}
