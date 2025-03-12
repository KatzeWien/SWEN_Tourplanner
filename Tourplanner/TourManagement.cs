using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tourplanner.Model;

namespace Tourplanner
{
    internal class TourManagement
    {
        ObservableCollection<Tour> tours;
        public TourManagement()
        {
            this.tours = new ObservableCollection<Tour>();
        }

        public void Add(Tour tour)
        {
            tours.Add(tour);
        }
    }
}
