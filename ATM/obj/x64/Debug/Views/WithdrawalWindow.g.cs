#pragma checksum "..\..\..\..\Views\WithdrawalWindow.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "DB416C5D87FB57C9F194588E5586937C1DE1A44FBCC0410B9C877EFD684BDC9D"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using ATM;
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


namespace ATM {
    
    
    /// <summary>
    /// WithdrawalWindow
    /// </summary>
    public partial class WithdrawalWindow : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 39 "..\..\..\..\Views\WithdrawalWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox WithdrawalAmount;
        
        #line default
        #line hidden
        
        
        #line 60 "..\..\..\..\Views\WithdrawalWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button ButtonWithdraw;
        
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
            System.Uri resourceLocater = new System.Uri("/ATM;component/views/withdrawalwindow.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\..\Views\WithdrawalWindow.xaml"
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
            
            #line 14 "..\..\..\..\Views\WithdrawalWindow.xaml"
            ((ATM.WithdrawalWindow)(target)).MouseDown += new System.Windows.Input.MouseButtonEventHandler(this.WithdrawalWindow_MouseDown);
            
            #line default
            #line hidden
            return;
            case 2:
            this.WithdrawalAmount = ((System.Windows.Controls.TextBox)(target));
            
            #line 50 "..\..\..\..\Views\WithdrawalWindow.xaml"
            this.WithdrawalAmount.GotFocus += new System.Windows.RoutedEventHandler(this.TextBox_GotFocus);
            
            #line default
            #line hidden
            
            #line 51 "..\..\..\..\Views\WithdrawalWindow.xaml"
            this.WithdrawalAmount.PreviewTextInput += new System.Windows.Input.TextCompositionEventHandler(this.WithdrawalAmount_PreviewTextInput);
            
            #line default
            #line hidden
            
            #line 52 "..\..\..\..\Views\WithdrawalWindow.xaml"
            this.WithdrawalAmount.TextChanged += new System.Windows.Controls.TextChangedEventHandler(this.WithdrawalAmount_TextChanged);
            
            #line default
            #line hidden
            return;
            case 3:
            this.ButtonWithdraw = ((System.Windows.Controls.Button)(target));
            
            #line 60 "..\..\..\..\Views\WithdrawalWindow.xaml"
            this.ButtonWithdraw.Click += new System.Windows.RoutedEventHandler(this.ButtonWithdraw_Click);
            
            #line default
            #line hidden
            return;
            case 4:
            
            #line 64 "..\..\..\..\Views\WithdrawalWindow.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.Button50_Click);
            
            #line default
            #line hidden
            return;
            case 5:
            
            #line 65 "..\..\..\..\Views\WithdrawalWindow.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.Button100_Click);
            
            #line default
            #line hidden
            return;
            case 6:
            
            #line 66 "..\..\..\..\Views\WithdrawalWindow.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.Button150_Click);
            
            #line default
            #line hidden
            return;
            case 7:
            
            #line 70 "..\..\..\..\Views\WithdrawalWindow.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.Button200_Click);
            
            #line default
            #line hidden
            return;
            case 8:
            
            #line 71 "..\..\..\..\Views\WithdrawalWindow.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.Button250_Click);
            
            #line default
            #line hidden
            return;
            case 9:
            
            #line 72 "..\..\..\..\Views\WithdrawalWindow.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.Button300_Click);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}

