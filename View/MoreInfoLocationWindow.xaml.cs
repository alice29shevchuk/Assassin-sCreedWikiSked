using Assassin_sCreedWikiSked.View.Controls;
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
    /// Логика взаимодействия для MoreInfoLocationWindow.xaml
    /// </summary>
    public partial class MoreInfoLocationWindow : Window
    {
        public MoreInfoLocationWindow()
        {
            InitializeComponent();
            this.DataContext = new LocationViewModel();
        }
        public MoreInfoLocationWindow(string name)
        {
            this.DataContext = new LocationViewModel();
            InitializeComponent();
            this.DataContext = new MoreInfoLocationWindow(name);
            CharacterCardUserControl characterCardUserControl = new CharacterCardUserControl(name);
            //characterCardUserControl.Width = 400;
            //characterCardUserControl.Height = 800;
            this.gridLoc.Children.Add(characterCardUserControl);
            Grid.SetRow(characterCardUserControl, 0);
            Grid.SetColumn(characterCardUserControl, 1);
            Grid.SetColumnSpan(characterCardUserControl,3);
        }
    }
}
