using Assassin_sCreedWikiSked.Model;
using GalaSoft.MvvmLight.CommandWpf;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Collections.Specialized;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace Assassin_sCreedWikiSked.ViewModel
{
    public class MenuWindowViewModel : INotifyCollectionChanged
    {
        public event NotifyCollectionChangedEventHandler CollectionChanged;
		public event PropertyChangedEventHandler PropertyChanged;
		private ObservableCollection<Serie> series;

		public ObservableCollection<Serie> Series
		{
			get { return series; }
			set { series = value; }
		}
        private ObservableCollection<Character> characters;
        public ObservableCollection<Character> Characters
        {
            get { return characters; }
            set { characters = value; }
        }
        private ObservableCollection<Weapon> weapons;
        public ObservableCollection<Weapon> Weapons
        {
            get { return weapons; }
            set { weapons = value; }
        }
        private ObservableCollection<Location> locations;
        public ObservableCollection<Location> Locations
        {
            get { return locations; }
            set { locations = value; }
        }
        public MenuWindowViewModel(string name)
		{
			//
			//		логика выбора категории
			//
			if(name == "series") Series = new ObservableCollection<Serie>(new ModelContext().Series);
            if(name == "characters") Characters = new ObservableCollection<Character>(new ModelContext().Characters);
            if (name == "weapons") Weapons = new ObservableCollection<Weapon>(new ModelContext().Weapons);
            if (name == "locations") Locations = new ObservableCollection<Location>(new ModelContext().Locations);


        }
        public void OnPropertyChanged([CallerMemberName] string prop = "")
		{
			PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(prop));
		}
    }
}
