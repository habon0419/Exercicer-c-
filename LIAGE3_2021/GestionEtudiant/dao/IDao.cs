using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestionEtudiant.dao
{
    // T peut etre une Personne,un Detail ou une Classe
   public interface IDao <T>
    {
        /*
        int insert(DaoPersonne pers);
        int insert(DaoDetail det);
        int insert(DaoClasse classe);
        */
         
        int Insert(T obj);
    }
}
