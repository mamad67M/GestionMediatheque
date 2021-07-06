using Business.Layer.DataAccess.BusinessObject;
using DataModel.DataAcces.Repository;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataModel.Services
{
    class ClientService
    {
        // declaration de la propriete repository
        public Repository repository { get; set; }
        // constructeur de clientService
        public ClientService()
        {
            repository = new Repository();
        }

        // la metode getClientService (lire)
        
        public List<Client> GetClientService() 
            {
               return repository.GetAll<Client>();
            }
      
      
        // la methode insert
        public void Inserer (Client client) 
        {
            repository.Insert(client);
        }

        // la methode update
        public void Update(Client client)
        {
            repository.Update(client);
        }
        //supprimer
        public void Delate (Client client)  
        {
            repository.Delete(client);
        }
    }
}
