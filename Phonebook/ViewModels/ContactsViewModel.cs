using Phonebook.Models;
using Phonebook.Services;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Phonebook.ViewModels
{
    // INotifyPropertyChanged crée la ligne 27// vue d'une proprieté qui a changé
    public class ContactsViewModel : INotifyPropertyChanged
    {
        //  { get;} sans cette infos , on ne peut recuperer les données
        //  { set;} sans cette infos , on ne peut modifier les données
        public IEnumerable<string> Results { get; set; }
        //binder searchText
        public string SearchText { get; set; }
        //propriete
        private readonly RepositoryService _repositoryService;
        //c'est un event, une partie du design pattern observer// permet d'envoyer des evenements
        //PropertyChanged est une fonction// a considere comme un objet
        public event PropertyChangedEventHandler? PropertyChanged;

        //lui donner un parametre et un nom
        public ContactsViewModel(RepositoryService repositoryService)
        {
            //constructor
            _repositoryService = repositoryService;
            Results = new List<string>() { "Hello  What's Up ?" };
            //pr eviter qu'on renvoit null (une erreur) au second clic
            //SearchText = string.Empty;
        }

        // creer la methode
        public void ExecuteList()
        {
            //on appelle la liste du RepositoryService
            //_repositoryService = Bertrand
            IEnumerable<Entity> results = _repositoryService.List();
            Results = results.Select(x => x.ToString());

            //qui envoie l'evenement :this (contexte du modele)
            //PropertyChanged previent la vue d'un event
            //PropertyChangedEventArg c'est une classe qu'on instancie dans un objet avc results comme parametre
            PropertyChanged(this, new PropertyChangedEventArgs("Results"));

        }

        public void ExecuteSearch()
        {
            IEnumerable<Entity> results = _repositoryService.Search(SearchText);
            Results = results.Select(x => x.ToString());
            PropertyChanged(this, new PropertyChangedEventArgs("Results"));
            //reset le search
            SearchText = "";
            PropertyChanged(this, new PropertyChangedEventArgs("SearchText"));
        }
    }
}
