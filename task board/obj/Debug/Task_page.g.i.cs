﻿#pragma checksum "..\..\Task_page.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "1B4C612C815C95235368928F8E48CCFACED5E165180ED1B343D6C5617822DE2E"
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
    /// Task_page
    /// </summary>
    public partial class Task_page : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 30 "..\..\Task_page.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TabControl Task_tab;
        
        #line default
        #line hidden
        
        
        #line 31 "..\..\Task_page.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TabItem Urgen_task;
        
        #line default
        #line hidden
        
        
        #line 38 "..\..\Task_page.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ListView Task_list_urgent;
        
        #line default
        #line hidden
        
        
        #line 54 "..\..\Task_page.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TabItem Common_task;
        
        #line default
        #line hidden
        
        
        #line 61 "..\..\Task_page.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ListView Task_list_coming_days;
        
        #line default
        #line hidden
        
        
        #line 77 "..\..\Task_page.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TabItem Next_month_task;
        
        #line default
        #line hidden
        
        
        #line 84 "..\..\Task_page.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ListView Task_list_next_month;
        
        #line default
        #line hidden
        
        
        #line 100 "..\..\Task_page.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox Content_task;
        
        #line default
        #line hidden
        
        
        #line 101 "..\..\Task_page.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox Date_task;
        
        #line default
        #line hidden
        
        
        #line 105 "..\..\Task_page.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button Edit_button;
        
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
            System.Uri resourceLocater = new System.Uri("/task board;component/task_page.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\Task_page.xaml"
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
            this.Task_tab = ((System.Windows.Controls.TabControl)(target));
            return;
            case 2:
            this.Urgen_task = ((System.Windows.Controls.TabItem)(target));
            return;
            case 3:
            this.Task_list_urgent = ((System.Windows.Controls.ListView)(target));
            
            #line 43 "..\..\Task_page.xaml"
            this.Task_list_urgent.SelectionChanged += new System.Windows.Controls.SelectionChangedEventHandler(this.Task_list_urgent_SelectionChanged);
            
            #line default
            #line hidden
            return;
            case 4:
            this.Common_task = ((System.Windows.Controls.TabItem)(target));
            return;
            case 5:
            this.Task_list_coming_days = ((System.Windows.Controls.ListView)(target));
            
            #line 64 "..\..\Task_page.xaml"
            this.Task_list_coming_days.SelectionChanged += new System.Windows.Controls.SelectionChangedEventHandler(this.Task_list_coming_days_SelectionChanged);
            
            #line default
            #line hidden
            return;
            case 6:
            this.Next_month_task = ((System.Windows.Controls.TabItem)(target));
            return;
            case 7:
            this.Task_list_next_month = ((System.Windows.Controls.ListView)(target));
            
            #line 87 "..\..\Task_page.xaml"
            this.Task_list_next_month.SelectionChanged += new System.Windows.Controls.SelectionChangedEventHandler(this.Task_list_next_month_SelectionChanged);
            
            #line default
            #line hidden
            return;
            case 8:
            this.Content_task = ((System.Windows.Controls.TextBox)(target));
            return;
            case 9:
            this.Date_task = ((System.Windows.Controls.TextBox)(target));
            return;
            case 10:
            this.Edit_button = ((System.Windows.Controls.Button)(target));
            
            #line 105 "..\..\Task_page.xaml"
            this.Edit_button.Click += new System.Windows.RoutedEventHandler(this.Edit_button_Click);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}

