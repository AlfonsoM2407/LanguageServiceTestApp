using Azure.AI.TextAnalytics;
using System;
using System.Windows;
using System.Windows.Controls;

namespace LanguageServiceTestApp
{
    public partial class QueryView : UserControl
    {
        private TextAnalyticsClient _client;

        public QueryView(TextAnalyticsClient client)
        {
            InitializeComponent();

            _client = client;
        }

        private void OnQueryButtonPress(object sender, RoutedEventArgs e)
        {
            try
            {
                double confidence;
                string language = GetLanguage(TextToQueryBox.Text, out confidence);

                string confidencePercent = (confidence * 100) + "%";

                MessageBox.Show($"Language: {language}\nConfidence: {confidencePercent}");
            }
            catch (Exception ex)
            {
                MessageBox.Show($"{ex}");
            }
        }

        private string GetLanguage(string text, out double confidence)
        {
            DetectedLanguage detectedLanguage = _client.DetectLanguage(text);

            confidence = detectedLanguage.ConfidenceScore;

            return detectedLanguage.Name;
        }
    }
}
