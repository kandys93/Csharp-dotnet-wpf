using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Phonebook.Models
{
    // : = extends en Ts/Js; herite d'Entity
    public class Person : Entity
    {
        //propriété getter et setter obligatoire
        public string FirstName { get; set; }

        public string LastName { get; set; }

        // apelle directement id d'Entity via base(id) qui se met à côté du constructor avec ':'[super() sur Ts]
        //constructor
        public Person (int id, string firstname, string lastname) : base(id)
        {
           //Id est appelé via Entity
           FirstName = firstname;
           LastName = lastname;
        }

        //redifinir ToString
        //override (polymorphisme de methode)
        public override string ToString()
        {
            return Id + " : " + FirstName + " : " + LastName ;
        }
    }
}
