using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace prjStackBrowser
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private Browser browser;
        public MainWindow()
        {
            InitializeComponent();
            browser = new Browser(20);
        }
        private void VisitButton_Click(object sender, RoutedEventArgs e)
        {
            string url = UrlTextBox.Text;
            if (!string.IsNullOrEmpty(url))
            {
                browser.visitPage(url);
                UpdateUI();
            }

        }
        private void BackButton_Click(Object sender, RoutedEventArgs e)
        {
            browser.GoBAck();
            UpdateUI();
        }

        private void UpdateUI()
        {
            CurrentPageTextBlock.Text = browser.CurrentPage;
            HistoryListBox.Items.Clear();
            foreach(var page in browser.CurrentPage)
            {
                HistoryListBox.Items.Add(page);
            }
        }
    }
}