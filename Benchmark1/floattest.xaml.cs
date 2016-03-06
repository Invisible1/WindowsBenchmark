using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Navigation;
using Microsoft.Phone.Controls;
using Microsoft.Phone.Shell;
using System.IO.IsolatedStorage;

namespace Benchmark1
{
    public partial class floattest : PhoneApplicationPage
    {
    
        public floattest()
        {
            InitializeComponent();
             DateTime time = DateTime.Now;
          floatTest(5 * 1000000);
          this.cpufloat.Text = (DateTime.Now - time).TotalMilliseconds.ToString(); //      
          time = DateTime.Now;
            
          integerTest(5 * 1000000);

          this.cpuinteger.Text = (Convert.ToInt32((DateTime.Now - time).TotalMilliseconds)).ToString(); //      
          double a = Convert.ToDouble(Microsoft.Phone.Info.DeviceStatus.DeviceTotalMemory);

          a = (a / 1024)/1024;
          this.memory.Text = a.ToString();
          this.score.Text = (Convert.ToDouble(this.memory.Text) + Convert.ToDouble(this.cpuinteger.Text) + Convert.ToDouble(this.cpufloat.Text)).ToString();
        }
            

        public static void integerTest(int loop)
        {
            for (int i = 0; i < loop; i++)
            {
                double a = 1000, b = 45, c = 12000, d = 2, e = 7, f = 1024;
                a = Math.Sin(a);
                b = Math.Asin(b);
                c = Math.Sqrt(c);
                d = d + d - d + d;
                e = e * e + e * e;
                f = f / f / f / f / f;
            }
        }
        //MFLOPS
        public static void floatTest(int loop)
        {
            for (int i = 0; i < loop; i++)
            {
                float a = 1000, b = 45, c = 12000, d = 2, e = 7, f = 1024;
                a = (float)Math.Sin(a);
                b = (float)Math.Asin(b);
                c = (float)Math.Sqrt(c);
                d = d + d - d + d;
                e = e * e + e * e;
                f = f / f / f / f / f;
            }
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new Uri("/MainPage.xaml", UriKind.Relative));
        }

    }

}