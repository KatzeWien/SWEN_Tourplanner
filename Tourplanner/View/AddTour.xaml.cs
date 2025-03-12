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
using System.Windows.Shapes;
using Tourplanner.Model;

namespace Tourplanner.View
{
    /// <summary>
    /// Interaktionslogik für AddTour.xaml
    /// </summary>
    public partial class AddTour : Window
    {
        private TourManagement management;
        public AddTour()
        {
            InitializeComponent();
            this.management = new TourManagement();
        }

        private void addValuesBtn_Click(object sender, RoutedEventArgs e)
        {
            string name = Name.Text;
            string description = Description.Text;
            string from = From.Text;
            string to = To.Text;
            string transportType = TransportType.Text;
            string inputTourDistance = TourDistance.Text;
            string inputEstimatedTime = EstimatedTime.Text;
            int tourDistance;
            TimeSpan estimatedTime;
            if (!int.TryParse(inputTourDistance, out tourDistance))
            {
                MessageBox.Show("Only numbers are valid");
            }
            if(!TimeSpan.TryParse(inputEstimatedTime, out estimatedTime))
            {
                MessageBox.Show("Only valid time hh:mm");
            }
            Tour tour = new Tour(name, description, from, to, transportType, tourDistance, estimatedTime);
            this.management.Add(tour);
            this.Close();
        }
    }
}
