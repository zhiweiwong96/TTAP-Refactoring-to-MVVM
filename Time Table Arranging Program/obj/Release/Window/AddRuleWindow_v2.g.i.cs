﻿#pragma checksum "..\..\..\Window\AddRuleWindow_v2.xaml" "{406ea660-64cf-4c82-b6f0-42d48172a799}" "A06DFA9628AEA3BB5ABB91F09CB8FF5C"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

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
using Time_Table_Arranging_Program;


namespace Time_Table_Arranging_Program {
    
    
    /// <summary>
    /// AddRuleWindow_v2
    /// </summary>
    public partial class AddRuleWindow_v2 : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 10 "..\..\..\Window\AddRuleWindow_v2.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button AddRuleButton;
        
        #line default
        #line hidden
        
        
        #line 12 "..\..\..\Window\AddRuleWindow_v2.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.StackPanel innerSp;
        
        #line default
        #line hidden
        
        
        #line 14 "..\..\..\Window\AddRuleWindow_v2.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button OkButton;
        
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
            System.Uri resourceLocater = new System.Uri("/Time Table Arranging Program;component/window/addrulewindow_v2.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\Window\AddRuleWindow_v2.xaml"
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
            
            #line 8 "..\..\..\Window\AddRuleWindow_v2.xaml"
            ((Time_Table_Arranging_Program.AddRuleWindow_v2)(target)).Closing += new System.ComponentModel.CancelEventHandler(this.AddRuleWindow_v2_OnClosing);
            
            #line default
            #line hidden
            return;
            case 2:
            this.AddRuleButton = ((System.Windows.Controls.Button)(target));
            
            #line 10 "..\..\..\Window\AddRuleWindow_v2.xaml"
            this.AddRuleButton.Click += new System.Windows.RoutedEventHandler(this.AddRuleButton_OnClick);
            
            #line default
            #line hidden
            return;
            case 3:
            this.innerSp = ((System.Windows.Controls.StackPanel)(target));
            return;
            case 4:
            this.OkButton = ((System.Windows.Controls.Button)(target));
            
            #line 14 "..\..\..\Window\AddRuleWindow_v2.xaml"
            this.OkButton.Click += new System.Windows.RoutedEventHandler(this.OkButton_OnClick);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}

