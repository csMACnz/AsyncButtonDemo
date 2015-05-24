using System;
using System.Threading;
using System.Threading.Tasks;
using System.Windows;

namespace AsyncButtonDemo
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void BadButtonOnClick(object sender, RoutedEventArgs e)
        {
            BuggyCode();
        }

        private async void CorrectButtonOnClick(object sender, RoutedEventArgs e)
        {
            await BuggyCode();
        }

        private async Task<bool> BuggyCode()
        {
            await Task.Factory.StartNew(() =>
            {
                Thread.Sleep(2000);
                throw new TimeoutException("Something bad happened.");
            });
            return false;
        }
    }
}
