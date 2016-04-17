using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Navigation;
using Microsoft.Phone.Controls;
using Microsoft.Phone.Shell;
using DoPliku.Resources;
using Windows.Storage;
using System.IO.IsolatedStorage; 

namespace DoPliku
{
    public partial class MainPage : PhoneApplicationPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private void btnSave_Click(object sender, RoutedEventArgs e)
        {
            IsolatedStorageSettings settings = IsolatedStorageSettings.ApplicationSettings;

            if (!settings.Contains(txtSettings.Text))
            {
                settings.Add(txtSettings.Text, txtValue.Text);
            }
            else
            {
                settings[txtSettings.Text] = txtValue.Text;
            }
            settings.Save(); 
        }

        private void btnRead_Click(object sender, RoutedEventArgs e)
        {
            if (IsolatedStorageSettings.ApplicationSettings.Contains(txtSettings.Text))
            {
                txtValue.Text = IsolatedStorageSettings.ApplicationSettings[txtSettings.Text].ToString();
            } 
        }
    }
}