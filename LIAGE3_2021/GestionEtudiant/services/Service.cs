using GestionEtudiant.dao;
using GestionEtudiant.models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestionEtudiant.services
{


  //Implement les Uses Case
    class Service
    {
        //Dao(Data Acces object)
        //ORM(object Relationnel Mapping)
        //objet=>Enregistrement de la BD (insert,update,delete)
        //Enregistrement de la BD=> objet (select)
        private DaoClasse daoClasse;
        private DaoPersonne daoPersonne;
        private DaoDetail daoDetail;



        public Service()
        {
            daoClasse = new DaoClasse();
            daoPersonne = new DaoPersonne();
            daoDetail = new DaoDetail();

        }

        public DataTable ListerEtudiantParClasse(Classe classe)
          {
              return daoPersonne.FindByClasse(classe);
          }


        public bool CreeClasse(Classe classe)
        {
            return daoClasse.Insert(classe)!= 0;
        }

        public List<Classe> ListerClasse()
        {
            return daoClasse.FindAll();
        }

        public bool CreePersonne(Personne personne)

        {
            return daoPersonne.Insert(personne)!= 0;
        }


        public Personne SeConnecter(String login, String pwd)
        {
            return daoPersonne.FindUserConnect(login,pwd);
        }

        public List<string> ListerModulesProfesseurParClasse(Classe cl, Personne pers)
        {
            throw new NotImplementedException();

        }
        // chercherProfesseur
        //AttribuerClasse
        //ListerProfesseur
        //ListerModulesProfesseurParClasse


    }

    



 

}
