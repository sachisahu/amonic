﻿#pragma checksum "..\..\AutomationSystem.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "786FE4C8DA0466AD5E38224816FC268D92BC0B11B98B3D87BB64BE2B0DD68FA1"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using AMONIC;
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


namespace AMONIC {
    
    
    /// <summary>
    /// AutomationSystem
    /// </summary>
    public partial class AutomationSystem : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 22 "..\..\AutomationSystem.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ComboBox cbOffice;
        
        #line default
        #line hidden
        
        
        #line 24 "..\..\AutomationSystem.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.DataGrid dtgGrid;
        
        #line default
        #line hidden
        
        
        #line 26 "..\..\AutomationSystem.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button changeRoll;
        
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
            System.Uri resourceLocater = new System.Uri("/AMONIC;component/automationsystem.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\AutomationSystem.xaml"
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
            
            #line 17 "..\..\AutomationSystem.xaml"
            ((System.Windows.Controls.MenuItem)(target)).Click += new System.Windows.RoutedEventHandler(this.MenuItem_Click);
            
            #line default
            #line hidden
            return;
            case 2:
            
            #line 18 "..\..\AutomationSystem.xaml"
            ((System.Windows.Controls.MenuItem)(target)).Click += new System.Windows.RoutedEventHandler(this.MenuItem_Click_2);
            
            #line default
            #line hidden
            return;
            case 3:
            this.cbOffice = ((System.Windows.Controls.ComboBox)(target));
            return;
            case 4:
            this.dtgGrid = ((System.Windows.Controls.DataGrid)(target));
            
            #line 24 "..\..\AutomationSystem.xaml"
            this.dtgGrid.SelectedCellsChanged += new System.Windows.Controls.SelectedCellsChangedEventHandler(this.dtgGrid_SelectedCellsChanged);
            
            #line default
            #line hidden
            return;
            case 5:
            this.changeRoll = ((System.Windows.Controls.Button)(target));
            
            #line 26 "..\..\AutomationSystem.xaml"
            this.changeRoll.Click += new System.Windows.RoutedEventHandler(this.changeRoll_Click);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}

