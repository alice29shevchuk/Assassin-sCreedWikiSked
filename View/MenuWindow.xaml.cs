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
    /// Логика взаимодействия для MenuWindow.xaml
    /// </summary>
    public partial class MenuWindow : Window
    {
        public MenuWindow()
        {
            InitializeComponent();
            
        }
        //private Task TaskAsync()
        //{
        //    return Task.Run(() => this.DataContext = new MenuWindowViewModel());
        //}
        private  void clickSeriesBTN(object sender, MouseButtonEventArgs e)
        {
            var tabItem = sender as TabItem;
            if(tabItem!= null)
            {
                this.DataContext = new MenuWindowViewModel();
                //await TaskAsync();
            }
        }
    }
}
