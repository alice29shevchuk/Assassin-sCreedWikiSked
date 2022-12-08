﻿using Assassin_sCreedWikiSked.ViewModel;
using CefSharp;
using CefSharp.Wpf;
using LiveCharts.Wpf;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Numerics;
using System.Runtime.CompilerServices;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Media.TextFormatting;
using System.Windows.Navigation;
using System.Windows.Shapes;
using YoutubeExplode;
using YoutubeExplode.Videos.Streams;

namespace Assassin_sCreedWikiSked.View.Controls
{
    /// <summary>
    /// Логика взаимодействия для UserPlayer.xaml
    /// </summary>
    public partial class UserPlayer : UserControl
    {
        public Regex YouTubeURELIDRegex = new Regex(@"[\?&]v=(?<v>[^&]+)");
        public UserPlayer(string Id)
        {
            InitializeComponent();
            PlayVideo(Id);
        }

        public void PlayVideo(string ID)
        {

            MenuWindowViewModel menuWindowViewModel = new MenuWindowViewModel("series");
            try
            {
                Match match = YouTubeURELIDRegex.Match(menuWindowViewModel.Series[Convert.ToInt32(ID) - 1].VideoPath);
                String id = match.Groups["v"].Value;
                string url1 = "https://www.youtube.com/embed/" + id;
                string page = "<html>" +
                    "<head><meta http-equiv='X-UA-Compatible' content='IE=11'/>" +
                    "<body style=\"background: #1e1f26\">" + "\r\n" +
                    "<iframe src=\"" + url1 + "\" width=\"950\" height=\"250\" frameborder=\"0\" allowfullscreen></iframe>" +
                    "</body></html>";
                this.web.NavigateToString(page);
            }
            catch(Exception e)
            {
                MessageBox.Show(e.Message);
            }
           
        }
    }
}
