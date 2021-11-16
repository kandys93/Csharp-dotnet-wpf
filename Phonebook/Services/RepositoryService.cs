using Phonebook.Models;
using Phonebook.Providers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Phonebook.Services
{
    public class RepositoryService
    {
        // juste en lecture , n'est pas modifié
        private readonly IEnumerable<IDataProvider> _providers;
  
        public RepositoryService(IEnumerable<IDataProvider> providers)
        {
            // _providers = private
            _providers = providers;
        }

        public IEnumerable<Entity> List()
        {
            //pour creer une nouvelle liste vide (generique), le type Entity doit être renseigné 
            IEnumerable<Entity> results = new List<Entity>();
            //creer une boucle; pour recuperer les données dans IDataProvider
            foreach (IDataProvider P in _providers)
            {
                //declarer le type pour une nouvelle variable
                results = results.Concat(P.List());
            }
            return results;
        }

        public IEnumerable<Entity> Search(string text)
        {
            IEnumerable<Entity> results = new List<Entity>();
            foreach (IDataProvider P in _providers)
            {
                results = results.Concat(P.Search(text));
            }
            return results;
        }

    }

   
}
