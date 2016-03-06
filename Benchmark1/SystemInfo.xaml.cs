using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Navigation;
using Microsoft.Phone.Controls;
using Microsoft.Phone.Shell;
using System.Globalization;

namespace Benchmark1
{
    public partial class SystemInfo : PhoneApplicationPage
    {
        public SystemInfo()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
                this.Osversion.Text = Environment.OSVersion.ToString();
                this.CLRversion.Text = Environment.Version.ToString();
                this.sytemTime.Text = System.DateTime.Now.ToString();
                this.TimeZone.Text = System.TimeZoneInfo.Local.ToString();

                this.Lastboottime.Text = TimeSpan.FromMilliseconds(System.Environment.TickCount).ToString();
               // CultureInfo ci = new CultureInfo(Windows.System.UserProfile.GlobalizationPreferences.Languages[0]);

                this.Language.Text = CultureInfo.CurrentCulture.EnglishName.ToString() ;
                var color = (System.Windows.Media.Color)Application.Current.Resources["PhoneAccentColor"];
                this.Acentcolor.Text = color.ToString();
                Visibility Visible = (Visibility)Application.Current.Resources["PhoneDarkThemeVisibility"];
                if (Visible == Visibility.Visible)
                {
                    this.color.Text = "dark";
                }
                else
                {
                    this.color.Text = "light";
                }
              //  var colr = System.Windows.Media.Color.FromArgb(); this.color.Text = colr.ToString();

        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new Uri("/MainPage.xaml", UriKind.Relative));
        }
    }
}