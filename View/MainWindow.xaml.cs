using Assassin_sCreedWikiSked.View;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.Windows.Threading;

namespace Assassin_sCreedWikiSked
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public DispatcherTimer timer { get; set; }
        public MainWindow()
        {
            InitializeComponent();
            timer = new DispatcherTimer();
            timer.Tick += Progressbar;
            timer.Interval = new TimeSpan(0, 0, 0,0,60);
            timer.Start();
        }

        private void Progressbar(object sender, EventArgs e)
        {
            if(this.bar.Value == 100)
            {
                timer.Stop();
                MenuWindow menuWindow = new MenuWindow();
                this.Close();
                menuWindow.ShowDialog();
            }
            else {this.bar.Value += 5;}
        }
    }
}
