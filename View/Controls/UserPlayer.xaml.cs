using CefSharp;
using CefSharp.Wpf;
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
        public UserPlayer()
        {
            InitializeComponent();
            Play();
        }

        public async void Play()
        {
            Match match = YouTubeURELIDRegex.Match("https://www.youtube.com/watch?v=eSjCeWcCtjY");
            String id = match.Groups["v"].Value;
            string url1 = "https://www.youtube.com/embed/" + id;
            string page = "<html>" +
                "<head><meta http-equiv='X-UA-Compatible' content='IE=11'/>" +
                "<body>" + "\r\n" +
                "<iframe src=\"" + url1 + "\" width=\"260\" height=\"115\" frameborder=\"0\" allowfullscreen></iframe>" +
                "</body></html>";
            this.web.NavigateToString(page);


            //this.media = new MediaElement();
            //this.media.Source = new Uri("https://www.youtube.com/embed/v2fDTOdWuQQ?rel=0&amp;showinfo=0",UriKind.RelativeOrAbsolute);
            //this.media.LoadedBehavior = MediaState.Manual;
            //this.media.Play();

            //this.webBrowser = new ChromiumWebBrowser();
            //CefSettings settings = new CefSettings();
            //Cef.Initialize(settings);
            //this.webBrowser = new ChromiumWebBrowser("https://www.youtube.com/embed/v2fDTOdWuQQ?rel=0&amp;showinfo=0");
            ////this.list.Items.Add(this.webBrowser);
            //this.media = new MediaElement();
            //HttpClient http = new HttpClient();
            //Uri uri = new Uri("https://www.youtube.com/embed/v2fDTOdWuQQ?rel=0&amp;showinfo=0");
            //HttpRandomAccessStream
            //this.web = new WebBrowser();
            //this.web.Navigate(new Uri("https://youtu.be/_xkCPNECud8"));
            //this.web.InvokeScript()

            //this.player.Source.
            ////var client = new YoutubeClient();
            ////var streamManifest = await client.Videos.Streams.GetManifestAsync("https://youtu.be/_xkCPNECud8");
            ////var streamInfo = (MuxedStreamInfo)streamManifest.GetMuxedStreams().GetWithHighestVideoQuality();

            //this.media = new MediaElement();
            ////this.media.Source = new Uri(@"https://dl8.webmfiles.org/big-buck-bunny_trailer.webm");
            //this.media.Source = new Uri("https://youtu.be/_xkCPNECud8");
            //this.media.Stretch = Stretch.Fill;
            //this.media.Volume = 100;
            //this.media.Visibility = Visibility.Collapsed;
            //this.media.UnloadedBehavior = MediaState.Manual;
            //this.media.Play();
            ////this.media.Source = new Uri(streamInfo.Url,UriKind.RelativeOrAbsolute);
            ////this.media = new MediaElement();
            ////this.media.Source = new Uri(@"https://youtu.be/_xkCPNECud8", UriKind.RelativeOrAbsolute);
            ////this.media.LoadedBehavior = MediaState.Manual;
            ////this.media.Play();
            //////this.media.Play();


        }
    }
}
