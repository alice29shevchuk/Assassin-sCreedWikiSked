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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Assassin_sCreedWikiSked.View.Controls
{
    /// <summary>
    /// Логика взаимодействия для WeaponUserControl.xaml
    /// </summary>
    public partial class WeaponUserControl : UserControl
    {
        public WeaponUserControl()
        {
            InitializeComponent();
        }
        public void MoreInfoBTN(object sender, MouseButtonEventArgs e)
        {
            var grid = sender as Grid;
            if (grid != null)
            {
                MoreInfoWeaponWindow moreInfoWeaponWindow = new MoreInfoWeaponWindow(this.Title.Text);
                moreInfoWeaponWindow.ShowDialog();
            }
        }
    }
}
