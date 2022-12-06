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
    /// Логика взаимодействия для LocationUserControl.xaml
    /// </summary>
    public partial class LocationUserControl : UserControl
    {
        public LocationUserControl()
        {
            InitializeComponent();
        }
        public void MoreInfoBTN(object sender, MouseButtonEventArgs e)
        {
            var grid = sender as Grid;
            if (grid != null)
            {
                MoreInfoLocationWindow moreInfoLocationWindow = new MoreInfoLocationWindow(this.Title.Text);
                moreInfoLocationWindow.ShowDialog();
            }
        }
    }
}
