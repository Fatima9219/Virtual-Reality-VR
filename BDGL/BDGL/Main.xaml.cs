/** BIBA - DidiLab Game Launcher  -> BDGL
 *  Small launcher application for simple creation of User-Accounts and passing the generated profiles to the targeted main program.
 *  @author Dima M.Boger
 *  @date   2022
*/

using System;
using System.Diagnostics;
using System.IO;
using System.Text.Json;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Animation;
using System.Windows.Media.Imaging;
using System.Windows.Threading;

namespace BDGL
{
    public partial class Main : CWindow
    {
        public Main()
        {
            InitializeComponent();
            _ = usernameTXTbox.Focus();
        }
        private void TextChangedEventHandler(object sender, TextChangedEventArgs args)
        {
            loginBtn.IsEnabled = !usernameTXTbox.Text.Equals("") && !passwordTXTbox.Text.Equals("");
        }
        private void UnhidePasswordClick(object sender, RoutedEventArgs e)
        {
            passwordTXTbox.FontFamily = new FontFamily(new Uri("pack://application:,,,/"), "./Resources/Fonts/#Agency FB");
        }
        private void HidePasswordClick(object sender, RoutedEventArgs e)
        {
            passwordTXTbox.FontFamily = new FontFamily(new Uri("pack://application:,,,/"), "./Resources/Fonts/#Password");
        }

        private void NewUser_Click(object sender, RoutedEventArgs e)
        {
            NewUser w = new NewUser();
            w.Show();
        }
        private void CantLogin_Click(object sender, RoutedEventArgs e)
        {
            AccountRecoveryMenu();
        }
        private void AccountRecoveryMenu()
        {
            loginGrid.Visibility = Visibility.Hidden;
            AccountRecoveryGrid.Visibility = Visibility.Visible;
            _ = sendRecoveryCodeEmailTXTbox.Focus();
        }
        private UProfile uprofile;
        private string pathBase = @"C:\Program Files\BDGL\Data\apps\common\VRhouse\";

        // Here an Interface to BDGLS or external Platforms like Moodle could be created if it needs to
        public void Login_Click(object sender, RoutedEventArgs e)
        {
            if (loginBtn.Content.Equals("LOGIN"))
            {
                msgLabel.Content = "";

                string folderPath = pathBase + @"\user\";
                DirectoryInfo dir = new DirectoryInfo(folderPath);
                FileInfo[] files = dir.GetFiles(usernameTXTbox.Text + "*", SearchOption.TopDirectoryOnly);

                bool foundProfile = false;

                foreach (var item in files) foundProfile = true;

                if (foundProfile)
                {
                    uprofile = JsonSerializer.Deserialize<UProfile>(File.ReadAllText(pathBase + @"\user\" + usernameTXTbox.Text + "_profile_db.json"));

                    if (usernameTXTbox.Text.Equals(Utils.Decode(uprofile.Username)) && passwordTXTbox.Text.Equals(Utils.Decode(uprofile.Password)))
                        LogInOutMenuAsync("0", true);
                    else msgLabel.Content = "Incorrect Credentials. Please check the input";
                }
                else msgLabel.Content = "Incorrect Credentials. Please check the input";
            }
            else LogedoutMenu();
        }
        private class UProfile
        {
            public string Firstname { get; set; }
            public string Lastname { get; set; }
            public string Username { get; set; }
            public string Password { get; set; }
            public byte[] Image { get; set; }
        }
        private void ConfirmationMenu(bool active)
        {
            if (active)
            {
                confirmationGrid.Visibility = Visibility.Visible;
                MovingPImage.Visibility = Visibility.Hidden;
            }
            else
            {
                confirmationGrid.Visibility = Visibility.Hidden;
                MovingPImage.Visibility = Visibility.Visible;
                mainMenuGrid.Visibility = Visibility.Visible;
                AvatarImage.Visibility = Visibility.Visible;
                msgLabel.Content = "";
            }
        }
        private async void LogInOutMenuAsync(string mode, bool accountConfirmed)
        {
            loginGrid.Visibility = Visibility.Hidden;

            ((Storyboard)FindResource("UnlockAnimation")).Begin();
            await Task.Delay(600);
            ((Storyboard)FindResource("FadeOutAnimation")).Begin();
            File.WriteAllBytes(pathBase + @"\VRhouse_Data\uimg", uprofile.Image);
            if (accountConfirmed)
            {
                mainMenuGrid.Visibility = Visibility.Visible;
                AvatarImage.Source = BitmapFromUri(pathBase + @"\VRhouse_Data\uimg");
                AvatarImage.Visibility = Visibility.Visible;
            }
            else ConfirmationMenu(true);
            loginBtn.Content = "LOGOUT";
        }
        public static ImageSource BitmapFromUri(string source)
        {
            var bmp = new BitmapImage();
            bmp.BeginInit();
            bmp.UriSource = new Uri(source);
            bmp.CacheOption = BitmapCacheOption.OnLoad;
            bmp.CreateOptions = BitmapCreateOptions.IgnoreImageCache;
            bmp.EndInit();
            return bmp;
        }
        private void LogedoutMenu()
        {
            AvatarImage.Visibility = Visibility.Hidden;
            AvatarImage.Source = null;
            passwordTXTbox.Text = string.Empty;
            mainMenuGrid.Visibility = Visibility.Hidden;
            ((Storyboard)FindResource("LockAnimation")).Begin();
            loginGrid.Visibility = Visibility.Visible;
            loginBtn.Content = "LOGIN";
            File.Delete(pathBase + @"\VRhouse_Data\uimg");
            passwordTXTbox.Focus();
        }
        private void Window_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Key == Key.Enter && loginBtn.IsEnabled) Login_Click(null, null);
        }
        private void AppsAndGamesDashboard_Click(object sender, RoutedEventArgs e)
        {
            StartAppChildProcess(pathBase);
        }
        private void StartAppChildProcess(string appBasePath)
        {
            // NOTE: Here you can deside what arguments you want to submit to the application
            Process p = new Process();
            p.StartInfo.FileName = pathBase + @"\VRhouse.exe";
            p.StartInfo.Arguments = uprofile.Username;
            p.EnableRaisingEvents = true;
            p.Exited += new EventHandler(AppExited);
            p.Start();
            ProcessManagement.AddProcess(p);
        }
        private void AppExited(object sender, EventArgs e)
        {
            Dispatcher.Invoke(new Action(() => { }), DispatcherPriority.Normal);
        }
    }
}