﻿using Assassin_sCreedWikiSked.View.Controls;
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
    /// Логика взаимодействия для MoreInfoWindow.xaml
    /// </summary>
    public partial class MoreInfoWindow : Window
    {
        public MoreInfoWindow()
        {
            InitializeComponent();
            this.DataContext = new MoreInfoViewModel();
        }
        public MoreInfoWindow(string title,string ID)
        {
            InitializeComponent();
            this.DataContext = new MoreInfoViewModel(title);
            UserPlayer userPlayer = new UserPlayer(ID);
            this.gridd.Children.Add(userPlayer);
            Grid.SetRow(userPlayer, 3);
            Grid.SetColumnSpan(userPlayer, 2);
        }
    }
}
