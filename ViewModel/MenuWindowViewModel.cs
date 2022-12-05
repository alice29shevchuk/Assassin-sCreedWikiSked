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
		private Serie selectedCard;

		public Serie SelectedCard
        {
			get { return selectedCard; }
			set { selectedCard = value; }
		}

        public MenuWindowViewModel(string name)
		{
			//
			//		логика выбора категории
			//
			if(name == "series")
			Series = new ObservableCollection<Serie>(new ModelContext().Series);
		}
		public void OnPropertyChanged([CallerMemberName] string prop = "")
		{
			PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(prop));
		}
    }
}
