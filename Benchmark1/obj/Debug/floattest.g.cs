﻿#pragma checksum "C:\Users\mypc\documents\visual studio 2012\Projects\Benchmark1\Benchmark1\floattest.xaml" "{406ea660-64cf-4c82-b6f0-42d48172a799}" "24105AEAD30A8719341C64A995691C4D"
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
    
    
    public partial class floattest : Microsoft.Phone.Controls.PhoneApplicationPage {
        
        internal System.Windows.Controls.Grid LayoutRoot;
        
        internal System.Windows.Controls.Grid ContentPanel;
        
        internal System.Windows.Controls.TextBlock cpufloat;
        
        internal System.Windows.Controls.TextBlock cpuinteger;
        
        internal System.Windows.Controls.TextBlock memory;
        
        internal System.Windows.Controls.TextBlock score;
        
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
            System.Windows.Application.LoadComponent(this, new System.Uri("/Benchmark1;component/floattest.xaml", System.UriKind.Relative));
            this.LayoutRoot = ((System.Windows.Controls.Grid)(this.FindName("LayoutRoot")));
            this.ContentPanel = ((System.Windows.Controls.Grid)(this.FindName("ContentPanel")));
            this.cpufloat = ((System.Windows.Controls.TextBlock)(this.FindName("cpufloat")));
            this.cpuinteger = ((System.Windows.Controls.TextBlock)(this.FindName("cpuinteger")));
            this.memory = ((System.Windows.Controls.TextBlock)(this.FindName("memory")));
            this.score = ((System.Windows.Controls.TextBlock)(this.FindName("score")));
        }
    }
}

