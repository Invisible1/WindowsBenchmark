﻿#pragma checksum "C:\Users\mypc\documents\visual studio 2012\Projects\Benchmark1\Benchmark1\NextPage.xaml" "{406ea660-64cf-4c82-b6f0-42d48172a799}" "D2A0EB2BD62A99B3FBF70B56B619F5D7"
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
    
    
    public partial class NextPage : Microsoft.Phone.Controls.PhoneApplicationPage {
        
        internal System.Windows.Controls.Grid LayoutRoot;
        
        internal System.Windows.Controls.TextBlock Osversion;
        
        internal System.Windows.Controls.TextBlock CLRversion;
        
        internal System.Windows.Controls.TextBlock sytemTime;
        
        internal System.Windows.Controls.TextBlock TimeZone;
        
        internal System.Windows.Controls.TextBlock Lastboottime;
        
        internal System.Windows.Controls.TextBlock Language;
        
        internal System.Windows.Controls.TextBlock color;
        
        internal System.Windows.Controls.TextBlock Acentcolor;
        
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
            System.Windows.Application.LoadComponent(this, new System.Uri("/Benchmark1;component/NextPage.xaml", System.UriKind.Relative));
            this.LayoutRoot = ((System.Windows.Controls.Grid)(this.FindName("LayoutRoot")));
            this.Osversion = ((System.Windows.Controls.TextBlock)(this.FindName("Osversion")));
            this.CLRversion = ((System.Windows.Controls.TextBlock)(this.FindName("CLRversion")));
            this.sytemTime = ((System.Windows.Controls.TextBlock)(this.FindName("sytemTime")));
            this.TimeZone = ((System.Windows.Controls.TextBlock)(this.FindName("TimeZone")));
            this.Lastboottime = ((System.Windows.Controls.TextBlock)(this.FindName("Lastboottime")));
            this.Language = ((System.Windows.Controls.TextBlock)(this.FindName("Language")));
            this.color = ((System.Windows.Controls.TextBlock)(this.FindName("color")));
            this.Acentcolor = ((System.Windows.Controls.TextBlock)(this.FindName("Acentcolor")));
        }
    }
}

