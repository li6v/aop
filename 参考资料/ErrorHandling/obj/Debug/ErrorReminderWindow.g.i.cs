// Updated by XamlIntelliSenseFileGenerator 2020/4/6 9:14:36
#pragma checksum "..\..\ErrorReminderWindow.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "4EAB80A40A144472D9411698D15EABF3EC80C4D1EDD41AE475DE754953EE7E2C"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using Gocool.Error;
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


namespace Gocool.Error
{


    internal partial class ErrorWindow : System.Windows.Window, System.Windows.Markup.IComponentConnector
    {


#line 17 "..\..\ErrorReminderWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBlock tbkErrorContent;

#line default
#line hidden


#line 20 "..\..\ErrorReminderWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.StackPanel spOption;

#line default
#line hidden


#line 33 "..\..\ErrorReminderWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btnIgnore;

#line default
#line hidden


#line 34 "..\..\ErrorReminderWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btnRetry;

#line default
#line hidden


#line 35 "..\..\ErrorReminderWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btnAbort;

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
            System.Uri resourceLocater = new System.Uri("/ErrorHandling;component/errorreminderwindow.xaml", System.UriKind.Relative);

#line 1 "..\..\ErrorReminderWindow.xaml"
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

#line 9 "..\..\ErrorReminderWindow.xaml"
                    ((Gocool.Error.ErrorWindow)(target)).Closing += new System.ComponentModel.CancelEventHandler(this.Window_Closing);

#line default
#line hidden
                    return;
                case 2:
                    this.tbkErrorContent = ((System.Windows.Controls.TextBlock)(target));
                    return;
                case 3:
                    this.spOption = ((System.Windows.Controls.StackPanel)(target));
                    return;
                case 4:
                    this.btnWarn = ((System.Windows.Controls.Button)(target));

#line 32 "..\..\ErrorReminderWindow.xaml"
                    this.btnWarn.Click += new System.Windows.RoutedEventHandler(this.btnWarn_Click);

#line default
#line hidden
                    return;
                case 5:
                    this.btnIgnore = ((System.Windows.Controls.Button)(target));

#line 33 "..\..\ErrorReminderWindow.xaml"
                    this.btnIgnore.Click += new System.Windows.RoutedEventHandler(this.btnIgnore_Click);

#line default
#line hidden
                    return;
                case 6:
                    this.btnRetry = ((System.Windows.Controls.Button)(target));

#line 34 "..\..\ErrorReminderWindow.xaml"
                    this.btnRetry.Click += new System.Windows.RoutedEventHandler(this.btnRetry_Click);

#line default
#line hidden
                    return;
                case 7:
                    this.btnAbort = ((System.Windows.Controls.Button)(target));

#line 35 "..\..\ErrorReminderWindow.xaml"
                    this.btnAbort.Click += new System.Windows.RoutedEventHandler(this.btnAbort_Click);

#line default
#line hidden
                    return;
            }
            this._contentLoaded = true;
        }

        internal System.Windows.Controls.Button btnShowWarn;
        internal System.Windows.Controls.Button btnShowAbort;
    }
}

