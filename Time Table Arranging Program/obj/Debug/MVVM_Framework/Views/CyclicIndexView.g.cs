﻿#pragma checksum "..\..\..\..\MVVM_Framework\Views\CyclicIndexView.xaml" "{406ea660-64cf-4c82-b6f0-42d48172a799}" "09552FCFD512F6EF36836AD870D2C78D"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using MaterialDesignThemes.Wpf;
using MaterialDesignThemes.Wpf.Transitions;
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
using Time_Table_Arranging_Program.IValueConverter;
using Time_Table_Arranging_Program.MVVM_Framework.ViewModels;
using Time_Table_Arranging_Program.MVVM_Framework.Views;
using Time_Table_Arranging_Program.User_Control;


namespace Time_Table_Arranging_Program.MVVM_Framework.Views {
    
    
    /// <summary>
    /// CyclicIndexView
    /// </summary>
    public partial class CyclicIndexView : System.Windows.Controls.UserControl, System.Windows.Markup.IComponentConnector {
        
        
        #line 49 "..\..\..\..\MVVM_Framework\Views\CyclicIndexView.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button PreviousButton;
        
        #line default
        #line hidden
        
        
        #line 55 "..\..\..\..\MVVM_Framework\Views\CyclicIndexView.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox CurrentIndexLabel;
        
        #line default
        #line hidden
        
        
        #line 60 "..\..\..\..\MVVM_Framework\Views\CyclicIndexView.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBlock MaxIndexLabel;
        
        #line default
        #line hidden
        
        
        #line 66 "..\..\..\..\MVVM_Framework\Views\CyclicIndexView.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button NextButton;
        
        #line default
        #line hidden
        
        
        #line 73 "..\..\..\..\MVVM_Framework\Views\CyclicIndexView.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button RandomButton;
        
        #line default
        #line hidden
        
        
        #line 76 "..\..\..\..\MVVM_Framework\Views\CyclicIndexView.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Slider Slider;
        
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
            System.Uri resourceLocater = new System.Uri("/Time Table Arranging Program;component/mvvm_framework/views/cyclicindexview.xaml" +
                    "", System.UriKind.Relative);
            
            #line 1 "..\..\..\..\MVVM_Framework\Views\CyclicIndexView.xaml"
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
            this.PreviousButton = ((System.Windows.Controls.Button)(target));
            return;
            case 2:
            this.CurrentIndexLabel = ((System.Windows.Controls.TextBox)(target));
            return;
            case 3:
            this.MaxIndexLabel = ((System.Windows.Controls.TextBlock)(target));
            return;
            case 4:
            this.NextButton = ((System.Windows.Controls.Button)(target));
            return;
            case 5:
            this.RandomButton = ((System.Windows.Controls.Button)(target));
            return;
            case 6:
            this.Slider = ((System.Windows.Controls.Slider)(target));
            return;
            }
            this._contentLoaded = true;
        }
    }
}

