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
    /// Логика взаимодействия для MoreInfoCharacterWindow.xaml
    /// </summary>
    public partial class MoreInfoCharacterWindow : Window
    {
        public MoreInfoCharacterWindow()
        {
            InitializeComponent();
            this.DataContext = new MoreInfoCharactersViewModel();
        }
        public MoreInfoCharacterWindow(string name)
        {
            InitializeComponent();
            this.DataContext = new MoreInfoCharactersViewModel(name);
            CharacterCardUserControl characterCardUserControl = new CharacterCardUserControl(name);
            characterCardUserControl.Width = 400;
            characterCardUserControl.Height = 800;
            this.gridCh.Children.Add(characterCardUserControl);
            Grid.SetRow(characterCardUserControl, 3);
            Grid.SetColumn(characterCardUserControl, 1);
        }
    }
}
