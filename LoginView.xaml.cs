using Azure;
using Azure.AI.TextAnalytics;
using System;
using System.Windows;
using System.Windows.Controls;

namespace LanguageServiceTestApp
{
    public partial class LoginView : UserControl
    {
        public LoginView()
        {
            InitializeComponent();
        }

        private void LoginButtonClick(object sender, RoutedEventArgs e)
        {
            SetMainWindowClient();
        }

        private void SetMainWindowClient()
        {
            try
            {
                Uri uri = new(EndpointBox.Text);
                AzureKeyCredential key = new(KeyBox.Password);

                TextAnalyticsClient client = new(uri, key);

                client.DetectLanguage("test");

                Window window = Window.GetWindow(this);
                window.Content = new QueryView(client); 
            }
            catch (Exception ex) 
            {
                MessageBox.Show($"{ex}"); 
            }
        }
    }
}
