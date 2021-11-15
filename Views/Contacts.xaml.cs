using Phonebook.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
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

namespace Phonebook.Views
{
    /// <summary>
    /// Logique d'interaction pour Contacts.xaml
    /// </summary>
    public partial class Contacts : UserControl
    {
       

        public Contacts()
        {
            InitializeComponent();
        }

        //lié au bouton Click sur la partie XAML
        //DataContext est lié au {Binding} de ma partie XAML
        //pourra être lu sur XAML via WindowsTemplate et via son DataType
        public void List_Click(object sender, RoutedEventArgs e)
        {
            //on instancie un objet au Click
            //MessageBox.Show("List");
            //affichage fenêtre
            //(DataContext as ContactsViewModel) est ce qu'on appel "casting de data"
            (DataContext as ContactsViewModel).ExecuteList();
        }

        public void Search_Click(object sender, RoutedEventArgs e)
        {
            //equivalent de alert()
            //MessageBox.Show("Search");
            //affichage fenêtre
            (DataContext as ContactsViewModel).ExecuteSearch();
        }
    }
}
