﻿using Assassin_sCreedWikiSked.ViewModel;
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
    /// Логика взаимодействия для CharactersCard.xaml
    /// </summary>
    public partial class CharactersCard : UserControl
    {
        public CharactersCard()
        {
            InitializeComponent();
        }
        public void MoreInfoBTN(object sender, MouseButtonEventArgs e)
        {
            var grid = sender as Grid;
            if (grid != null)
            {
                MoreInfoCharacterWindow moreInfoCharacterWindow = new MoreInfoCharacterWindow(this.Title.Text);
                moreInfoCharacterWindow.ShowDialog();
            }
        }
    }
}
