﻿#pragma checksum "D:\SEM3\UWP\MyUniversalApp\MusicApp\MainPage.xaml" "{406ea660-64cf-4c82-b6f0-42d48172a799}" "6674A3DBE62CB2CB86AEEF9D9B1B0FF1"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace MusicApp
{
    partial class MainPage : 
        global::Windows.UI.Xaml.Controls.Page, 
        global::Windows.UI.Xaml.Markup.IComponentConnector,
        global::Windows.UI.Xaml.Markup.IComponentConnector2
    {
        /// <summary>
        /// Connect()
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Windows.UI.Xaml.Build.Tasks"," 10.0.17.0")]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        public void Connect(int connectionId, object target)
        {
            switch(connectionId)
            {
            case 2: // MainPage.xaml line 12
                {
                    this.ParentStackPanel = (global::Windows.UI.Xaml.Controls.StackPanel)(target);
                }
                break;
            case 3: // MainPage.xaml line 13
                {
                    this.Email = (global::Windows.UI.Xaml.Controls.TextBox)(target);
                }
                break;
            case 4: // MainPage.xaml line 14
                {
                    this.Password = (global::Windows.UI.Xaml.Controls.PasswordBox)(target);
                }
                break;
            case 5: // MainPage.xaml line 15
                {
                    this.FirstName = (global::Windows.UI.Xaml.Controls.TextBox)(target);
                }
                break;
            case 6: // MainPage.xaml line 16
                {
                    this.LastName = (global::Windows.UI.Xaml.Controls.TextBox)(target);
                }
                break;
            case 7: // MainPage.xaml line 17
                {
                    this.ImageUrl = (global::Windows.UI.Xaml.Controls.TextBox)(target);
                }
                break;
            case 8: // MainPage.xaml line 19
                {
                    this.MyAvatar = (global::Windows.UI.Xaml.Controls.Image)(target);
                }
                break;
            case 9: // MainPage.xaml line 21
                {
                    global::Windows.UI.Xaml.Controls.Button element9 = (global::Windows.UI.Xaml.Controls.Button)(target);
                    ((global::Windows.UI.Xaml.Controls.Button)element9).Click += this.Capture_Photo;
                }
                break;
            case 10: // MainPage.xaml line 22
                {
                    this.Phone = (global::Windows.UI.Xaml.Controls.TextBox)(target);
                }
                break;
            case 11: // MainPage.xaml line 23
                {
                    this.Address = (global::Windows.UI.Xaml.Controls.TextBox)(target);
                }
                break;
            case 12: // MainPage.xaml line 24
                {
                    this.Introduction = (global::Windows.UI.Xaml.Controls.TextBox)(target);
                }
                break;
            case 13: // MainPage.xaml line 32
                {
                    this.BirthDay = (global::Windows.UI.Xaml.Controls.CalendarDatePicker)(target);
                    ((global::Windows.UI.Xaml.Controls.CalendarDatePicker)this.BirthDay).DateChanged += this.Change_Birthday;
                }
                break;
            case 14: // MainPage.xaml line 33
                {
                    this.BtnSignup = (global::Windows.UI.Xaml.Controls.Button)(target);
                    ((global::Windows.UI.Xaml.Controls.Button)this.BtnSignup).Click += this.Handle_Signup;
                }
                break;
            case 15: // MainPage.xaml line 34
                {
                    this.BtnReset = (global::Windows.UI.Xaml.Controls.Button)(target);
                    ((global::Windows.UI.Xaml.Controls.Button)this.BtnReset).Click += this.BtnReset_Click;
                }
                break;
            case 16: // MainPage.xaml line 28
                {
                    global::Windows.UI.Xaml.Controls.RadioButton element16 = (global::Windows.UI.Xaml.Controls.RadioButton)(target);
                    ((global::Windows.UI.Xaml.Controls.RadioButton)element16).Checked += this.Select_Gender;
                }
                break;
            case 17: // MainPage.xaml line 29
                {
                    global::Windows.UI.Xaml.Controls.RadioButton element17 = (global::Windows.UI.Xaml.Controls.RadioButton)(target);
                    ((global::Windows.UI.Xaml.Controls.RadioButton)element17).Checked += this.Select_Gender;
                }
                break;
            case 18: // MainPage.xaml line 30
                {
                    global::Windows.UI.Xaml.Controls.RadioButton element18 = (global::Windows.UI.Xaml.Controls.RadioButton)(target);
                    ((global::Windows.UI.Xaml.Controls.RadioButton)element18).Checked += this.Select_Gender;
                }
                break;
            default:
                break;
            }
            this._contentLoaded = true;
        }

        /// <summary>
        /// GetBindingConnector(int connectionId, object target)
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Windows.UI.Xaml.Build.Tasks"," 10.0.17.0")]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        public global::Windows.UI.Xaml.Markup.IComponentConnector GetBindingConnector(int connectionId, object target)
        {
            global::Windows.UI.Xaml.Markup.IComponentConnector returnValue = null;
            return returnValue;
        }
    }
}

