using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Navigation;
using Microsoft.Phone.Controls;
using Microsoft.Phone.Shell;
using Microsoft.Devices.Sensors;
//using Microsoft.Devices.Sensors;
using Microsoft.Xna.Framework;

namespace Benchmark1
{
    public partial class acceleromter_link : PhoneApplicationPage
    {
        Accelerometer accelerometer;
        public acceleromter_link()
        {
            InitializeComponent();
            if (!Accelerometer.IsSupported)
            {
                statusTextBlock.Text = "device does not support accelerometer";
                startButton.IsEnabled = false;
                stopButton.IsEnabled = false;
            }

        }

        
        private void startButton_Click(object sender, RoutedEventArgs e)
        {

            if (accelerometer == null)
            {
                // Instantiate the Accelerometer.
                accelerometer = new Accelerometer();
                accelerometer.TimeBetweenUpdates = TimeSpan.FromMilliseconds(20);
                accelerometer.CurrentValueChanged += new EventHandler<SensorReadingEventArgs<AccelerometerReading>>(accelerometer_CurrentValueChanged);
                accelerometer.Start();
                statusTextBlock.Text = "hello";
            }
        }
        void accelerometer_CurrentValueChanged(object sender, SensorReadingEventArgs<AccelerometerReading> e)
        {
            // Call UpdateUI on the UI thread and pass the AccelerometerReading.
           // statusTextBlock.Text = "he;llo";
           Dispatcher.BeginInvoke(() => UpdateUI(e.SensorReading));
        }
        private void UpdateUI(AccelerometerReading accelerometerReading)
        {
            statusTextBlock.Text = "getting data";

            Vector3 acceleration = accelerometerReading.Acceleration;

            // Show the numeric values.
            xTextBlock.Text = "X: " + acceleration.X.ToString("0.00");
            yTextBlock.Text = "Y: " + acceleration.Y.ToString("0.00");
            zTextBlock.Text = "Z: " + acceleration.Z.ToString("0.00");

            // Show the values graphically.
            xLine.X2 = xLine.X1 + acceleration.X * 200;
            yLine.Y2 = yLine.Y1 - acceleration.Y * 200;
            zLine.X2 = zLine.X1 - acceleration.Z * 100;
            zLine.Y2 = zLine.Y1 + acceleration.Z * 100;
        }

        private void stopButton_Click(object sender, RoutedEventArgs e)
        {
            if (accelerometer != null)
            {
                // Stop the accelerometer.
                accelerometer.Stop();
                statusTextBlock.Text = "accelerometer stopped.";
            }
        }

    }
}