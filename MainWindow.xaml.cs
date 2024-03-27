using System.Windows;


namespace LanguageServiceTestApp
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

            MainWindowContent.Content = new LoginView();
        }
    }
}
