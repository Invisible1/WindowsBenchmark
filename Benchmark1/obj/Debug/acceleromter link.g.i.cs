﻿#pragma checksum "C:\Users\mypc\documents\visual studio 2012\Projects\Benchmark1\Benchmark1\acceleromter link.xaml" "{406ea660-64cf-4c82-b6f0-42d48172a799}" "2D62BE3C8A3471561709B21F42843A39"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.34209
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using Microsoft.Phone.Controls;
using System;
using System.Windows;
using System.Windows.Automation;
using System.Windows.Automation.Peers;
using System.Windows.Automation.Provider;
using System.Windows.Controls;
using System.Windows.Controls.Primitives;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Ink;
using System.Windows.Input;
using System.Windows.Interop;
using System.Windows.Markup;
using System.Windows.Media;
using System.Windows.Media.Animation;
using System.Windows.Media.Imaging;
using System.Windows.Resources;
using System.Windows.Shapes;
using System.Windows.Threading;


namespace Benchmark1 {
    
    
    public partial class acceleromter_link : Microsoft.Phone.Controls.PhoneApplicationPage {
        
        internal System.Windows.Controls.Grid LayoutRoot;
        
        internal System.Windows.Controls.Grid ContentPanel;
        
        internal System.Windows.Controls.Button startButton;
        
        internal System.Windows.Controls.Button stopButton;
        
        internal System.Windows.Controls.TextBlock xTextBlock;
        
        internal System.Windows.Controls.TextBlock yTextBlock;
        
        internal System.Windows.Controls.TextBlock zTextBlock;
        
        internal System.Windows.Shapes.Line xLine;
        
        internal System.Windows.Shapes.Line yLine;
        
        internal System.Windows.Shapes.Line zLine;
        
        internal System.Windows.Controls.TextBlock statusTextBlock;
        
        private bool _contentLoaded;
        
        /// <summary>
        /// InitializeComponent
        /// </summary>
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        public void InitializeComponent() {
            if (_contentLoaded) {
                return;
            }
            _contentLoaded = true;
            System.Windows.Application.LoadComponent(this, new System.Uri("/Benchmark1;component/acceleromter%20link.xaml", System.UriKind.Relative));
            this.LayoutRoot = ((System.Windows.Controls.Grid)(this.FindName("LayoutRoot")));
            this.ContentPanel = ((System.Windows.Controls.Grid)(this.FindName("ContentPanel")));
            this.startButton = ((System.Windows.Controls.Button)(this.FindName("startButton")));
            this.stopButton = ((System.Windows.Controls.Button)(this.FindName("stopButton")));
            this.xTextBlock = ((System.Windows.Controls.TextBlock)(this.FindName("xTextBlock")));
            this.yTextBlock = ((System.Windows.Controls.TextBlock)(this.FindName("yTextBlock")));
            this.zTextBlock = ((System.Windows.Controls.TextBlock)(this.FindName("zTextBlock")));
            this.xLine = ((System.Windows.Shapes.Line)(this.FindName("xLine")));
            this.yLine = ((System.Windows.Shapes.Line)(this.FindName("yLine")));
            this.zLine = ((System.Windows.Shapes.Line)(this.FindName("zLine")));
            this.statusTextBlock = ((System.Windows.Controls.TextBlock)(this.FindName("statusTextBlock")));
        }
    }
}

