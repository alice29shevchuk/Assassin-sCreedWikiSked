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
    public class MoreInfoCharactersViewModel : INotifyCollectionChanged
    {
        public event NotifyCollectionChangedEventHandler CollectionChanged;

        public event PropertyChangedEventHandler PropertyChanged;
        private ObservableCollection<Character> character;

        public ObservableCollection<Character> Character
        {
            get { return character; }
            set { character = value; }
        }

        public MoreInfoCharactersViewModel()
        {
            Character = new ObservableCollection<Character>(new ModelContext().Characters);
        }
        public MoreInfoCharactersViewModel(string name)
        {
            Character = new ObservableCollection<Character>(new ModelContext().Characters.Where(x => x.Name == name));
        }
        public void OnPropertyChanged([CallerMemberName] string prop = "")
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(prop));
        }
    }
}
