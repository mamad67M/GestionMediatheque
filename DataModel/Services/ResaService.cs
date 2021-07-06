using DataModel.DataAcces.Repository;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataModel.Services
{
    class ResaService
    {
        // declaration de la propriete repository
        public Repository repository { get; set; }
        // constructeur de clientService
        public ResaService()
        {
            repository = new Repository();
        }

        // la metode getClientService (lire)

        public List<T> GetClientService<T>() where T : class
        {
            return repository.GetAll<T>();
        }


        // la methode insert
        public void Inserer<T>(T resa) where T : class
        {
            repository.Insert<T>(resa);
        }

        // la methode update
        public void Update<T>(T entity) where T : class
        {
            repository.Update<T>(entity);
        }
        //supprimer
        public void Delate<T>(T resa) where T : class
        {
            repository.Delete<T>(resa);
        }
    }
}
