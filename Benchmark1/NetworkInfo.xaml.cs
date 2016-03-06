using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Navigation;
using Microsoft.Phone.Controls;
using Microsoft.Phone.Shell;
using Microsoft.Phone.Net.NetworkInformation;

namespace Benchmark1.Resources
{
    public partial class NetworkInfo : PhoneApplicationPage
    {
        public NetworkInfo()
        {
         InitializeComponent();
         this.ipaddress.Text = GetIPaddress().ToString();
         this.mobileOp.Text = DeviceNetworkInformation.CellularMobileOperator.ToString();
         this.cellulardata.Text = DeviceNetworkInformation.IsCellularDataRoamingEnabled.ToString();
         this.wifi.Text = DeviceNetworkInformation.IsWiFiEnabled.ToString();
         this.networkavailable.Text = NetworkInterface.GetIsNetworkAvailable().ToString();
         
        }
        public IPAddress GetIPaddress()
        {
            List<string> Ipaddress=new List<string>();
            var Hosts = Windows.Networking.Connectivity.NetworkInformation.GetHostNames().ToList();
            foreach (var Host in Hosts)
            {
                string IP = Host.DisplayName;
                Ipaddress.Add(IP);
            }
            IPAddress address = IPAddress.Parse(Ipaddress.Last());
            return address;
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new Uri("/MainPage.xaml", UriKind.Relative));
        }


    }
}