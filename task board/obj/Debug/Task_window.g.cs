﻿#pragma checksum "..\..\Task_window.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "D0FF01F167E5197357162DAAB946A3C386CB8E3F008E7311ECAC5525447BC45E"
//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан программой.
//     Исполняемая версия:4.0.30319.42000
//
//     Изменения в этом файле могут привести к неправильной работе и будут потеряны в случае
//     повторной генерации кода.
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
using task_board;


namespace task_board {
    
    
    /// <summary>
    /// Task_window
    /// </summary>
    public partial class Task_window : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 37 "..\..\Task_window.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBlock Title_task;
        
        #line default
        #line hidden
        
        
        #line 42 "..\..\Task_window.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBlock Text;
        
        #line default
        #line hidden
        
        
        #line 47 "..\..\Task_window.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBlock Date;
        
        #line default
        #line hidden
        
        
        #line 52 "..\..\Task_window.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBlock Status_false;
        
        #line default
        #line hidden
        
        
        #line 58 "..\..\Task_window.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBlock Status_true;
        
        #line default
        #line hidden
        
        
        #line 65 "..\..\Task_window.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button Exit_button;
        
        #line default
        #line hidden
        
        
        #line 68 "..\..\Task_window.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button Conpleted_button;
        
        #line default
        #line hidden
        
        
        #line 71 "..\..\Task_window.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button Delete_button;
        
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
            System.Uri resourceLocater = new System.Uri("/task board;component/task_window.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\Task_window.xaml"
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
            this.Title_task = ((System.Windows.Controls.TextBlock)(target));
            return;
            case 2:
            this.Text = ((System.Windows.Controls.TextBlock)(target));
            return;
            case 3:
            this.Date = ((System.Windows.Controls.TextBlock)(target));
            return;
            case 4:
            this.Status_false = ((System.Windows.Controls.TextBlock)(target));
            return;
            case 5:
            this.Status_true = ((System.Windows.Controls.TextBlock)(target));
            return;
            case 6:
            this.Exit_button = ((System.Windows.Controls.Button)(target));
            
            #line 67 "..\..\Task_window.xaml"
            this.Exit_button.Click += new System.Windows.RoutedEventHandler(this.Exit_button_Click);
            
            #line default
            #line hidden
            return;
            case 7:
            this.Conpleted_button = ((System.Windows.Controls.Button)(target));
            
            #line 70 "..\..\Task_window.xaml"
            this.Conpleted_button.Click += new System.Windows.RoutedEventHandler(this.Conpleted_button_Click);
            
            #line default
            #line hidden
            return;
            case 8:
            this.Delete_button = ((System.Windows.Controls.Button)(target));
            
            #line 72 "..\..\Task_window.xaml"
            this.Delete_button.Click += new System.Windows.RoutedEventHandler(this.Delete_button_Click);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}

