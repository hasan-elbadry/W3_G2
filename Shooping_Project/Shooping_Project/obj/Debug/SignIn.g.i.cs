// Updated by XamlIntelliSenseFileGenerator 11/28/2023 8:34:36 AM
#pragma checksum "..\..\SignIn.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "E956663F24102D5E73A22244118F45604B6AEBCBEBE3F920E6F8932427DB1CAD"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using Shooping_Project;
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


namespace Shooping_Project
{


    /// <summary>
    /// SignIn
    /// </summary>
    public partial class SignIn : System.Windows.Controls.Page, System.Windows.Markup.IComponentConnector
    {


#line 28 "..\..\SignIn.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.PasswordBox Password;

#line default
#line hidden


#line 31 "..\..\SignIn.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox UserName;

#line default
#line hidden


#line 32 "..\..\SignIn.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button BtnLogin;

#line default
#line hidden


#line 41 "..\..\SignIn.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button ForgetPassowrd;

#line default
#line hidden


#line 47 "..\..\SignIn.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button SignupBtn;

#line default
#line hidden

        private bool _contentLoaded;

        /// <summary>
        /// InitializeComponent
        /// </summary>
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "4.0.0.0")]
        public void InitializeComponent()
        {
            if (_contentLoaded)
            {
                return;
            }
            _contentLoaded = true;
            System.Uri resourceLocater = new System.Uri("/Shooping_Project;component/signin.xaml", System.UriKind.Relative);

#line 1 "..\..\SignIn.xaml"
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
        void System.Windows.Markup.IComponentConnector.Connect(int connectionId, object target)
        {
            switch (connectionId)
            {
                case 1:
                    this.Password = ((System.Windows.Controls.PasswordBox)(target));
                    return;
                case 2:
                    this.UserName = ((System.Windows.Controls.TextBox)(target));
                    return;
                case 3:
                    this.BtnLogin = ((System.Windows.Controls.Button)(target));

#line 32 "..\..\SignIn.xaml"
                    this.BtnLogin.Click += new System.Windows.RoutedEventHandler(this.BtnLogin_Click);

#line default
#line hidden
                    return;
                case 4:
                    this.ForgetPassowrd = ((System.Windows.Controls.Button)(target));

#line 41 "..\..\SignIn.xaml"
                    this.ForgetPassowrd.Click += new System.Windows.RoutedEventHandler(this.ForgetPassowrd_Click);

#line default
#line hidden
                    return;
                case 5:
                    this.Combo = ((System.Windows.Controls.ComboBox)(target));
                    return;
                case 6:
                    this.SignupBtn = ((System.Windows.Controls.Button)(target));

#line 47 "..\..\SignIn.xaml"
                    this.SignupBtn.Click += new System.Windows.RoutedEventHandler(this.BtnLogin_Click);

#line default
#line hidden
                    return;
            }
            this._contentLoaded = true;
        }
    }
}

