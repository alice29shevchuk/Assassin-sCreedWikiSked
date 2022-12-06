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
            //var audio = new MediaElement();
            //audio.LoadedBehavior = MediaState.Manual;
            //audio.Source =new Uri("https://static.wikia.nocookie.net/assassinscreed/images/f/f9/%D0%AD%D0%B4%D0%B2%D0%B0%D1%80%D0%B4.ogg/revision/latest?cb=20200505184500&path-prefix=ru", UriKind.RelativeOrAbsolute);
            //audio.Play();
            //this.grid.Children.Add(audio);
            //Grid.SetColumn(audio, 1);
            //audio.Source = new Uri("https://static.wikia.nocookie.net/assassinscreed/images/f/f9/%D0%AD%D0%B4%D0%B2%D0%B0%D1%80%D0%B4.ogg/revision/latest?cb=20200505184500&path-prefix=ru",UriKind.Absolute);
            //this.audio.LoadedBehavior = MediaState.Manual;
            //this.audio.Play();
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
                if(tabItem.Name == "characters")
                {
                    this.listSerie.Visibility = Visibility.Hidden;
                    this.listWeapon.Visibility = Visibility.Hidden;
                    this.listCharacter.Visibility = Visibility.Visible;
                }
                if(tabItem.Name == "series")
                {
                    this.listWeapon.Visibility = Visibility.Hidden;
                    this.listCharacter.Visibility = Visibility.Hidden;
                    this.listSerie.Visibility = Visibility.Visible;
                }
                if(tabItem.Name == "weapons")
                {
                    this.listWeapon.Visibility = Visibility.Visible;
                    this.listCharacter.Visibility = Visibility.Hidden;
                    this.listSerie.Visibility = Visibility.Hidden;
                }
                this.DataContext = new MenuWindowViewModel(tabItem.Name);
                //await TaskAsync();
            }
        }
    }
}
