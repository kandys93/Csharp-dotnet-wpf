using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Phonebook.Models
{
    public abstract class Entity
    {
        //propriete getter et setter obligatoire
        public int Id { get; set; }

        //le constructor a le même nom que la classe
        public Entity(int id)
        {
            Id = id;
        }
    }
}
