﻿using Assassin_sCreedWikiSked.Model;
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
    public class MoreInfoViewModel : INotifyCollectionChanged
    {
        public event NotifyCollectionChangedEventHandler CollectionChanged;
        public event PropertyChangedEventHandler PropertyChanged;
        private ObservableCollection<Serie> series;

        public ObservableCollection<Serie> Series
        {
            get { return series; }
            set { series = value; }
        }
       
        public MoreInfoViewModel()
        {
            Series = new ObservableCollection<Serie>(new ModelContext().Series);
        }
        public MoreInfoViewModel(string title)
        {
            Series = new ObservableCollection<Serie>(new ModelContext().Series.Where(x=> x.Title == title));
        }
        public void OnPropertyChanged([CallerMemberName] string prop = "")
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(prop));
        }

    }
}
