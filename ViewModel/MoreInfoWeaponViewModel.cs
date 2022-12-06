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
    internal class MoreInfoWeaponViewModel : INotifyCollectionChanged
    {
        public event NotifyCollectionChangedEventHandler CollectionChanged;
        public event PropertyChangedEventHandler PropertyChanged;
        private ObservableCollection<Weapon> weapons;

        public ObservableCollection<Weapon> Weapons
        {
            get { return weapons; }
            set { weapons = value; }
        }

        public MoreInfoWeaponViewModel()
        {
            Weapons = new ObservableCollection<Weapon>(new ModelContext().Weapons);
        }
        public MoreInfoWeaponViewModel(string name)
        {
            Weapons = new ObservableCollection<Weapon>(new ModelContext().Weapons.Where(x => x.Name == name));
        }
        public void OnPropertyChanged([CallerMemberName] string prop = "")
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(prop));
        }
    }
}
