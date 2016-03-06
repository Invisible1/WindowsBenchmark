using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Navigation;
using Microsoft.Phone.Controls;
using Microsoft.Phone.Shell;
using System.Windows.Threading;
using System.Diagnostics;
using System.IO;
using Windows.Storage;
using System.Threading.Tasks;


namespace Benchmark1
{
    
    public partial class Performance : PhoneApplicationPage
    {
       
        DispatcherTimer timer;
        public Performance()
        {
            InitializeComponent();
            

           }
        void timer_Tick(object sender, EventArgs e)
        {
            try
            {
                // These are TextBlock controls that are created in the page’s XAML file.       
                this.appmem.Text = Microsoft.Phone.Info.DeviceStatus.ApplicationCurrentMemoryUsage.ToString()+"  Kb";
                this.peakMem.Text = Microsoft.Phone.Info.DeviceStatus.ApplicationPeakMemoryUsage.ToString()+"  Kb";
            }
            catch (Exception ex)
            {
               //MemoryTextBlock.Text = ex.Message;
            }
        }
        private async Task readprocess()
        {
            Stopwatch stop= Stopwatch.StartNew();

            StorageFolder local = Windows.Storage.ApplicationData.Current.LocalFolder;

            //if (local != null)
            {
                // Get the DataFolder folder.
                var dataFolder = await local.CreateFolderAsync("DataFolder",
                CreationCollisionOption.OpenIfExists);

                // Create a new file named DataFile.txt.
                var file = await dataFolder.CreateFileAsync("DataFile.txt",
                CreationCollisionOption.ReplaceExisting); // Read the data.
                using (var s = await file.OpenStreamForReadAsync())
                {
                  //  this.textBlock1.Text = streamReader.ReadToEnd();
                }

            }

    // Update UI.
    //this.btnWrite.IsEnabled = true;
    //this.btnRead.IsEnabled = false;
    stop.Stop();
    this.cpu.Text= stop.ElapsedMilliseconds.ToString();
        
    }
        private async Task WriteToFile()
        {
            Stopwatch stop = Stopwatch.StartNew();
            string a = "123459qwererertertertasd";
            // Get the text data from the textbox. 
            byte[] fileBytes = System.Text.Encoding.UTF8.GetBytes(a.ToCharArray());

            // Get the local folder.
            StorageFolder local = Windows.Storage.ApplicationData.Current.LocalFolder;

            // Create a new folder name DataFolder.
            var dataFolder = await local.CreateFolderAsync("DataFolder",
                CreationCollisionOption.OpenIfExists);

            // Create a new file named DataFile.txt.
            var file = await dataFolder.CreateFileAsync("DataFile.txt",
            CreationCollisionOption.ReplaceExisting);

            // Write the data from the textbox.
            using (var s = await file.OpenStreamForWriteAsync())
            {
                s.Write(fileBytes, 0, fileBytes.Length);
            }
            stop.Stop();
            this.writetest.Text = stop.ElapsedMilliseconds.ToString();
        }

        private async void Button_Click(object sender, RoutedEventArgs e)
        {
            timer = new DispatcherTimer();
            timer.Interval = new TimeSpan(0, 0, 10);
            timer.Tick += new EventHandler(timer_Tick);
            timer.Start();
            Stopwatch stopwatch = Stopwatch.StartNew();
            await WriteToFile();
           await readprocess();
           
            // this.btnWrite.IsEnabled = false;
           // this.btnRead.IsEnabled = true;
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new Uri("/MainPage.xaml", UriKind.Relative));
        }
        
    }
}