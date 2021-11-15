using Phonebook.Models;
using Phonebook.Providers;
using Phonebook.Services;
using Phonebook.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Phonebook
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    
    public partial class MainWindow : Window
    {
        // on instancie une propriete à l'interieur d'une classe
        private readonly AboutViewModel _aboutViewModel;
        private readonly ContactsViewModel _contactsViewModel;

        public MainWindow()

        {
            IDataProvider jose = new PersonProvider();
            IDataProvider sophie = new CompanyProvider();
            IEnumerable<IDataProvider> providers = new List<IDataProvider>() { jose, sophie };

            RepositoryService bertrand = new RepositoryService(providers);
            //je les alimente dans le constructor
            // on reconnait le constructor car il y a les mêmes elements que la classe
            _aboutViewModel = new AboutViewModel();
            _contactsViewModel = new ContactsViewModel(bertrand); 
            
            InitializeComponent();
        }
        public void ExecuterPrg(object sender, RoutedEventArgs e)
        {
            //instancier (creer les objets)
            IDataProvider jose = new PersonProvider();
            IDataProvider sophie = new CompanyProvider();
            IEnumerable<IDataProvider> providers = new List<IDataProvider>() { jose, sophie };
            RepositoryService bertrand = new RepositoryService(providers);
            //IEnumerable<Entity> results = bertrand.Search("so");


            // possibilité d'afficher directement ma fonction sur MessageBox
            //MessageBox.Show(JsonSerializer.Serialize(bertrand.Search("so")));
            MessageBox.Show(JsonSerializer.Serialize(bertrand.List()));

        }

        //lié au bouton Click sur la partie XAML
        //DataContext est lié au {Binding} de ma partie XAML
        //pourra être lu sur XAML via WindowsTemplate et via son DataType
        public void About_Click(object sender, RoutedEventArgs e)
        {
            //on instancie un objet au Click
            //_aboutViewModel = convention de nommage Quand une propriété est privée, on doit la nommer avec un _nomDePropriete
            DataContext = _aboutViewModel;
        }

        public void Contacts_Click(object sender, RoutedEventArgs e)
        {
            //_contactsViewModel = convention de nommage Quand une propriété est privée, on doit la nommer avec un _nomDePropriete
            DataContext = _contactsViewModel;
        }
    }
}
