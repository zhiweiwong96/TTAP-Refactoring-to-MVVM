﻿#pragma checksum "..\..\..\..\Windows Control\SummaryWindow.xaml" "{406ea660-64cf-4c82-b6f0-42d48172a799}" "CF424983D96D51F0B09A8E09574EAA06"
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
using Time_Table_Arranging_Program.User_Control;
using Time_Table_Arranging_Program.Windows_Control;


namespace Time_Table_Arranging_Program.Windows_Control {
    
    
    /// <summary>
    /// SummaryWindow
    /// </summary>
    public partial class SummaryWindow : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 12 "..\..\..\..\Windows Control\SummaryWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button BackButton;
        
        #line default
        #line hidden
        
        
        #line 13 "..\..\..\..\Windows Control\SummaryWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal Time_Table_Arranging_Program.User_Control.PreviousNextButton PreviousNextButton;
        
        #line default
        #line hidden
        
        
        #line 15 "..\..\..\..\Windows Control\SummaryWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal Time_Table_Arranging_Program.User_Control.TimetableDescriptionViewer DescriptionViewer;
        
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
            System.Uri resourceLocater = new System.Uri("/Time Table Arranging Program;component/windows%20control/summarywindow.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\..\Windows Control\SummaryWindow.xaml"
            System.Windows.Application.LoadComponent(this, resourceLocater);
            
            #line default
            #line hidden
        }
        
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "4.0.0.0")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1811:AvoidUncalledPrivateCode")]
        internal System.Delegate _CreateDelegate(System.Type delegateType, string handler) {
            return System.Delegate.CreateDelegate(delegateType, this, handler);
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
            
            #line 9 "..\..\..\..\Windows Control\SummaryWindow.xaml"
            ((Time_Table_Arranging_Program.Windows_Control.SummaryWindow)(target)).Closing += new System.ComponentModel.CancelEventHandler(this.SummaryWindow_OnClosing);
            
            #line default
            #line hidden
            return;
            case 2:
            this.BackButton = ((System.Windows.Controls.Button)(target));
            
            #line 12 "..\..\..\..\Windows Control\SummaryWindow.xaml"
            this.BackButton.Click += new System.Windows.RoutedEventHandler(this.BackButton_OnClick);
            
            #line default
            #line hidden
            return;
            case 3:
            this.PreviousNextButton = ((Time_Table_Arranging_Program.User_Control.PreviousNextButton)(target));
            return;
            case 4:
            this.DescriptionViewer = ((Time_Table_Arranging_Program.User_Control.TimetableDescriptionViewer)(target));
            return;
            }
            this._contentLoaded = true;
        }
    }
}

