﻿#pragma checksum "..\..\..\Pages\Quest1Page.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "738971765DD744947CD25057C66908BF184A8932AC805F95098A10BB4EE30DA4"
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
using YoxaStudy.Pages;


namespace YoxaStudy.Pages {
    
    
    /// <summary>
    /// Quest1Page
    /// </summary>
    public partial class Quest1Page : System.Windows.Controls.Page, System.Windows.Markup.IComponentConnector {
        
        
        #line 45 "..\..\..\Pages\Quest1Page.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.CheckBox RightCb;
        
        #line default
        #line hidden
        
        
        #line 59 "..\..\..\Pages\Quest1Page.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.CheckBox UnRightCb;
        
        #line default
        #line hidden
        
        
        #line 73 "..\..\..\Pages\Quest1Page.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.CheckBox UnRightCb2;
        
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
            System.Uri resourceLocater = new System.Uri("/YoxaStudy;component/pages/quest1page.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\Pages\Quest1Page.xaml"
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
            this.RightCb = ((System.Windows.Controls.CheckBox)(target));
            
            #line 49 "..\..\..\Pages\Quest1Page.xaml"
            this.RightCb.Checked += new System.Windows.RoutedEventHandler(this.RightCb_Checked);
            
            #line default
            #line hidden
            return;
            case 2:
            this.UnRightCb = ((System.Windows.Controls.CheckBox)(target));
            
            #line 62 "..\..\..\Pages\Quest1Page.xaml"
            this.UnRightCb.Checked += new System.Windows.RoutedEventHandler(this.UnRightCb_Checked);
            
            #line default
            #line hidden
            return;
            case 3:
            this.UnRightCb2 = ((System.Windows.Controls.CheckBox)(target));
            
            #line 76 "..\..\..\Pages\Quest1Page.xaml"
            this.UnRightCb2.Checked += new System.Windows.RoutedEventHandler(this.UnRightCb2_Checked);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}
