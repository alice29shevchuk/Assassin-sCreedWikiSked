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
            InitializeComponent();
            this.DataContext = new LocationViewModel(name);
            MoreInfoLocationUserControl moreInfoLocationUserControl = new MoreInfoLocationUserControl(name);
            moreInfoLocationUserControl.Margin = new Thickness(30, 30, 30, 30);
            //moreInfoLocationUserControl.Width = 200;
            //moreInfoLocationUserControl.Height = 400;
            this.gridLoc.Children.Add(moreInfoLocationUserControl);
            //Grid.SetRow(moreInfoLocationUserControl, 0);
            Grid.SetColumn(moreInfoLocationUserControl, 1);
            Grid.SetRowSpan(moreInfoLocationUserControl, 3);
        }
    }
}
