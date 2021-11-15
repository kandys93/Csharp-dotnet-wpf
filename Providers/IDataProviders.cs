using Phonebook.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Phonebook.Providers
{
    public interface IDataProvider
    {
        // type de retour/methode c'est un IEnumerable d'Entity qu'on va appeler List()
        IEnumerable<Entity> List();
        //type de retour/methode c'est un IEnumerable d'Entity qu'on va appeler Search(string text)
        IEnumerable<Entity> Search(string text);
    }
}
