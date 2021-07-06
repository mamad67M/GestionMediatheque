using Business.Layer.DataAccess.BusinessObject;
using DataModel.DataAcces.Repository;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataModel.Services
{
   public class LivreService
    {
        // declaration de la propriete repository
        public Repository repository { get; set; }
        // constructeur de livreService
        public LivreService()
        {
            repository = new Repository();
        }

        // la metode getLivreService (lire)

        public List<Livre> GetLivres() 
        {
            return repository.GetAll<Livre>();
        }



        //methode getlivreByID********************
        public Livre GetLivreById(int id)
        {
           return  repository.GetById<Livre>(id);
        }




        // la methode insert
        public void Inserer(Livre livre) 
        {
            repository.Insert(livre);
        }

        // la methode update
        public void Update(Livre livre) 
        {
            repository.Update(livre);
        }
        //supprimer
        public void Delate (Livre livre) 
        {
            repository.Delete(livre);
        }
    }
}
