using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Navigation;
using Microsoft.Phone.Controls;
using Microsoft.Phone.Shell;
using Microsoft.Devices;
using Windows.Storage.Streams;

namespace Benchmark1
{
    public partial class DeviceInfo : PhoneApplicationPage
    {
        VibrateController testVibrateController = VibrateController.Default;
        
        public DeviceInfo()
        {
            InitializeComponent();
            this.Manufacturer.Text = Microsoft.Phone.Info.DeviceStatus.DeviceManufacturer.ToString();
            this.Hardwareversion.Text = Microsoft.Phone.Info.DeviceStatus.DeviceHardwareVersion.ToString();
            this.Devicename.Text = Microsoft.Phone.Info.DeviceStatus.DeviceName.ToString();
            this.totalmemory.Text = Microsoft.Phone.Info.DeviceStatus.DeviceTotalMemory.ToString();
            this.availablespace.Text = Microsoft.Phone.Info.DeviceStatus.ApplicationCurrentMemoryUsage.ToString();
            this.powersource.Text = Microsoft.Phone.Info.DeviceStatus.PowerSource.ToString();
            this.firmwareversion.Text=Microsoft.Phone.Info.DeviceStatus.DeviceFirmwareVersion.ToString(); //Error
            }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new Uri("/acceleromter link.xaml", UriKind.Relative));
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            testVibrateController.Start(TimeSpan.FromSeconds(1));
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new Uri("/MainPage.xaml", UriKind.Relative));
        }
      
    }
}