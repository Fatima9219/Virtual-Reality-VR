using System.Windows;

namespace BDGL
{
    public partial class CWindow : Window
    {
        public CWindow() { }
        public void OnMinimizeButtonClick(object sender, RoutedEventArgs e) => WindowState = WindowState.Minimized;
        public void OnMaximizeRestoreButtonClick(object sender, RoutedEventArgs e) => WindowState = (WindowState == WindowState.Normal) ? WindowState.Maximized : WindowState.Normal;
        public void OnCloseButtonClick(object sender, RoutedEventArgs e)
        {
            Application.Current.MainWindow.Visibility = Visibility.Visible;
            Close();
        }
    }
}