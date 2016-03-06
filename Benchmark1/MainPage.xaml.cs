using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Navigation;
using Microsoft.Phone.Controls;
using Microsoft.Phone.Shell;
using Benchmark1.Resources;
using System.Diagnostics;

using System.ComponentModel;
namespace Benchmark1
{
    public partial class MainPage : PhoneApplicationPage
    {
       
               // Constructor
        public MainPage()
        {
            InitializeComponent();

            // Sample code to localize the ApplicationBar
            
        }
       
        private void StartTest(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new Uri("/SystemInfo.xaml", UriKind.Relative));
        }

        private void DeviceTest_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new Uri("/DeviceInfo.xaml", UriKind.Relative));
        }

        private void NetworkTest_Click(object sender, RoutedEventArgs e)
        {
           NavigationService.Navigate(new Uri("/NetworkInfo.xaml", UriKind.Relative));
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new Uri("/floattest.xaml", UriKind.Relative));
        
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new Uri("/Performance.xaml", UriKind.Relative));
        }

        //Process[] processlist = Process.GetProcesses();

    }
}