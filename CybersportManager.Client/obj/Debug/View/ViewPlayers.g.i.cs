﻿#pragma checksum "..\..\..\View\ViewPlayers.xaml" "{406ea660-64cf-4c82-b6f0-42d48172a799}" "63DB6F0ACD9F869FAB82BE65BABB8542"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using CybersportManager.Client;
using System;
using System.Diagnostics;
using System.Windows;
using System.Windows.Automation;
using System.Windows.Controls;
using System.Windows.Controls.Primitives;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Ink;
using System.Windows.Input;
using System.Windows.Markup;
using System.Windows.Media;
using System.Windows.Media.Animation;
using System.Windows.Media.Effects;
using System.Windows.Media.Imaging;
using System.Windows.Media.Media3D;
using System.Windows.Media.TextFormatting;
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.Windows.Shell;


namespace CybersportManager.Client {
    
    
    /// <summary>
    /// ViewPlayers
    /// </summary>
    public partial class ViewPlayers : System.Windows.Controls.UserControl, System.Windows.Markup.IComponentConnector {
        
        
        #line 13 "..\..\..\View\ViewPlayers.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button PlayerPageBtn;
        
        #line default
        #line hidden
        
        
        #line 14 "..\..\..\View\ViewPlayers.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button TeamPageBtn;
        
        #line default
        #line hidden
        
        
        #line 15 "..\..\..\View\ViewPlayers.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button TournamentPageBtn;
        
        #line default
        #line hidden
        
        
        #line 16 "..\..\..\View\ViewPlayers.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button HeroesPageBtn;
        
        #line default
        #line hidden
        
        
        #line 28 "..\..\..\View\ViewPlayers.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button AddBtn;
        
        #line default
        #line hidden
        
        
        #line 29 "..\..\..\View\ViewPlayers.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button ViewBtn;
        
        #line default
        #line hidden
        
        
        #line 30 "..\..\..\View\ViewPlayers.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.DataGrid playerTable1;
        
        #line default
        #line hidden
        
        private bool _contentLoaded;
        
        /// <summary>
        /// InitializeComponent
        /// </summary>
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "4.0.0.0")]
        public void InitializeComponent() {
            if (_contentLoaded) {
                return;
            }
            _contentLoaded = true;
            System.Uri resourceLocater = new System.Uri("/CybersportManager.Client;component/view/viewplayers.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\View\ViewPlayers.xaml"
            System.Windows.Application.LoadComponent(this, resourceLocater);
            
            #line default
            #line hidden
        }
        
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "4.0.0.0")]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Design", "CA1033:InterfaceMethodsShouldBeCallableByChildTypes")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Maintainability", "CA1502:AvoidExcessiveComplexity")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1800:DoNotCastUnnecessarily")]
        void System.Windows.Markup.IComponentConnector.Connect(int connectionId, object target) {
            switch (connectionId)
            {
            case 1:
            this.PlayerPageBtn = ((System.Windows.Controls.Button)(target));
            
            #line 13 "..\..\..\View\ViewPlayers.xaml"
            this.PlayerPageBtn.Click += new System.Windows.RoutedEventHandler(this.PlayerPageBtn_Click);
            
            #line default
            #line hidden
            return;
            case 2:
            this.TeamPageBtn = ((System.Windows.Controls.Button)(target));
            
            #line 14 "..\..\..\View\ViewPlayers.xaml"
            this.TeamPageBtn.Click += new System.Windows.RoutedEventHandler(this.TeamPageBtn_Click);
            
            #line default
            #line hidden
            return;
            case 3:
            this.TournamentPageBtn = ((System.Windows.Controls.Button)(target));
            
            #line 15 "..\..\..\View\ViewPlayers.xaml"
            this.TournamentPageBtn.Click += new System.Windows.RoutedEventHandler(this.TournamentPageBtn_Click);
            
            #line default
            #line hidden
            return;
            case 4:
            this.HeroesPageBtn = ((System.Windows.Controls.Button)(target));
            
            #line 16 "..\..\..\View\ViewPlayers.xaml"
            this.HeroesPageBtn.Click += new System.Windows.RoutedEventHandler(this.HeroesPageBtn_Click);
            
            #line default
            #line hidden
            return;
            case 5:
            this.AddBtn = ((System.Windows.Controls.Button)(target));
            
            #line 28 "..\..\..\View\ViewPlayers.xaml"
            this.AddBtn.Click += new System.Windows.RoutedEventHandler(this.AddBtn_Click);
            
            #line default
            #line hidden
            return;
            case 6:
            this.ViewBtn = ((System.Windows.Controls.Button)(target));
            
            #line 29 "..\..\..\View\ViewPlayers.xaml"
            this.ViewBtn.Click += new System.Windows.RoutedEventHandler(this.ViewBtn_Click);
            
            #line default
            #line hidden
            return;
            case 7:
            this.playerTable1 = ((System.Windows.Controls.DataGrid)(target));
            return;
            }
            this._contentLoaded = true;
        }
    }
}

