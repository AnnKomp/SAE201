using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
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

namespace Principal
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();




            // Populate list

            //ObservableCollection<Categorie> LesCategories = new ObservableCollection<Categorie>();
            //ObservableCollection<Materiel> LesMateriaux = new ObservableCollection<Materiel>();



            lv_materiel.Items.Add(new Materiel { NomM = "OR123542"});
            lv_materiel.Items.Add(new Materiel { NomM = "OR145672" });
            lv_materiel.Items.Add(new Materiel { NomM = "OR178549" });

            lv_materiel.Items.Add(new Materiel { NomM = "IMP123542" });
            lv_materiel.Items.Add(new Materiel { NomM = "IMP975264" });
            lv_materiel.Items.Add(new Materiel { NomM = "IMP123587" });

            lv_materiel.Items.Add(new Materiel { NomM = "SC7895241" });
            lv_materiel.Items.Add(new Materiel { NomM = "SC7825148" });
            lv_materiel.Items.Add(new Materiel { NomM = "SC6548122" });

            lv_categorie.Items.Add(new Categorie { NomC = "Imprimante" });
            lv_categorie.Items.Add(new Categorie { NomC = "Scaner" });
            lv_categorie.Items.Add(new Categorie { NomC = "Ordinateur portable" });

        }


        public class Categorie
        {

            public string NomC { get; set; }
        }

        public class Materiel
        {

            public string NomM { get; set; }
        }

        private void bt_materiel_Click(object sender, RoutedEventArgs e)
        {
            FenMat fenetreMateriel = new FenMat();
            fenetreMateriel.ShowDialog();

            

        }
    }
}
