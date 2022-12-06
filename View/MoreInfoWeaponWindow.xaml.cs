using Assassin_sCreedWikiSked.ViewModel;
using System;
using System.Collections.Generic;
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

namespace Assassin_sCreedWikiSked.View
{
    /// <summary>
    /// Логика взаимодействия для MoreInfoWeaponWindow.xaml
    /// </summary>
    public partial class MoreInfoWeaponWindow : Window
    {
        public MoreInfoWeaponWindow()
        {
            InitializeComponent();
        }
        public MoreInfoWeaponWindow(string name)
        {
            InitializeComponent();
            this.DataContext = new MoreInfoWeaponViewModel(name);
        }
    }
}
