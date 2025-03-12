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
using Tourplanner.Model;

namespace Tourplanner.View
{
    /// <summary>
    /// Interaktionslogik für TourManagment.xaml
    /// </summary>
    public partial class TourManagment : UserControl
    {
        private ObservableCollection<Tour> tours;
        public TourManagment()
        {
            InitializeComponent();
            this.tours = new ObservableCollection<Tour>();
        }
        private void btnAddTour_click(object sender, RoutedEventArgs e)
        {
            AddTour addTour = new AddTour();
            addTour.ShowDialog();
        }
    }
}
