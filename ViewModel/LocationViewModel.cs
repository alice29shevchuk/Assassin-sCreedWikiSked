using Assassin_sCreedWikiSked.Model;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Collections.Specialized;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Assassin_sCreedWikiSked.ViewModel
{
    public class LocationViewModel : INotifyCollectionChanged
    {
        public event NotifyCollectionChangedEventHandler CollectionChanged;
        public event PropertyChangedEventHandler PropertyChanged;
        private ObservableCollection<Location> locations;

        public ObservableCollection<Location> Locations
        {
            get { return locations; }
            set { locations = value; }
        }

        public LocationViewModel()
        {
            Locations = new ObservableCollection<Location>(new ModelContext().Locations);
        }
        public LocationViewModel(string name)
        {
            Locations = new ObservableCollection<Location>(new ModelContext().Locations.Where(x => x.Title == name));
        }
        public void OnPropertyChanged([CallerMemberName] string prop = "")
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(prop));
        }

    }
}
