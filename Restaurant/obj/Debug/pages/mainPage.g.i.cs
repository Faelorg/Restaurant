﻿#pragma checksum "..\..\..\pages\mainPage.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "4164BA4840F8965142E49102078E63E19F10348A6EB5D679571138E13E6DCA39"
//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан программой.
//     Исполняемая версия:4.0.30319.42000
//
//     Изменения в этом файле могут привести к неправильной работе и будут потеряны в случае
//     повторной генерации кода.
// </auto-generated>
//------------------------------------------------------------------------------

using Restaurant.pages;
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


namespace Restaurant.pages {
    
    
    /// <summary>
    /// mainPage
    /// </summary>
    public partial class mainPage : System.Windows.Controls.Page, System.Windows.Markup.IComponentConnector {
        
        
        #line 21 "..\..\..\pages\mainPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btnSale;
        
        #line default
        #line hidden
        
        
        #line 37 "..\..\..\pages\mainPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btnStock;
        
        #line default
        #line hidden
        
        
        #line 53 "..\..\..\pages\mainPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btnReports;
        
        #line default
        #line hidden
        
        
        #line 69 "..\..\..\pages\mainPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btnEmpoloyee;
        
        #line default
        #line hidden
        
        
        #line 86 "..\..\..\pages\mainPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btnCustomer;
        
        #line default
        #line hidden
        
        
        #line 103 "..\..\..\pages\mainPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btnLogOut;
        
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
            System.Uri resourceLocater = new System.Uri("/Restaurant;component/pages/mainpage.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\pages\mainPage.xaml"
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
            this.btnSale = ((System.Windows.Controls.Button)(target));
            
            #line 21 "..\..\..\pages\mainPage.xaml"
            this.btnSale.Click += new System.Windows.RoutedEventHandler(this.btnSale_Click);
            
            #line default
            #line hidden
            return;
            case 2:
            this.btnStock = ((System.Windows.Controls.Button)(target));
            
            #line 37 "..\..\..\pages\mainPage.xaml"
            this.btnStock.Click += new System.Windows.RoutedEventHandler(this.btnStock_Click);
            
            #line default
            #line hidden
            return;
            case 3:
            this.btnReports = ((System.Windows.Controls.Button)(target));
            
            #line 53 "..\..\..\pages\mainPage.xaml"
            this.btnReports.Click += new System.Windows.RoutedEventHandler(this.btnReports_Click);
            
            #line default
            #line hidden
            return;
            case 4:
            this.btnEmpoloyee = ((System.Windows.Controls.Button)(target));
            
            #line 69 "..\..\..\pages\mainPage.xaml"
            this.btnEmpoloyee.Click += new System.Windows.RoutedEventHandler(this.btnEmpoloyee_Click);
            
            #line default
            #line hidden
            return;
            case 5:
            this.btnCustomer = ((System.Windows.Controls.Button)(target));
            
            #line 86 "..\..\..\pages\mainPage.xaml"
            this.btnCustomer.Click += new System.Windows.RoutedEventHandler(this.btnCustomer_Click);
            
            #line default
            #line hidden
            return;
            case 6:
            this.btnLogOut = ((System.Windows.Controls.Button)(target));
            
            #line 103 "..\..\..\pages\mainPage.xaml"
            this.btnLogOut.Click += new System.Windows.RoutedEventHandler(this.btnLogOut_Click);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}
