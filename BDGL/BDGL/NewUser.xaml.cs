/** NewUser Frame */

using Microsoft.Win32;
using System;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Text.Json;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;

namespace BDGL
{
    public partial class NewUser : CWindow
    {
        public object Sender { get; set; }
        bool registered = false;
        public string[] logininput = new string[2];
        public NewUser()
        {
            InitializeComponent();
            Application.Current.MainWindow.Visibility = Visibility.Hidden;
            Sender = registered;
        }
        private string imgPath = "";
        private void AddImage_Click(object sender, RoutedEventArgs e)
        {
            OpenFileDialog op = new OpenFileDialog()
            {
                Title = "Select a picture",
                Filter = "All supported graphics|*.jpg;*.jpeg;*.png|" +
                            "JPEG (*.jpg;*.jpeg)|*.jpg;*.jpeg|" +
                            "Portable Network Graphic (*.png)|*.png"
            };
            if (op.ShowDialog() == true)
            {
                userImage.Source = new BitmapImage(new Uri(op.FileName));
                if (userImage.ActualHeight != userImage.ActualWidth)
                    Debug.WriteLine("Image is not quadratic size");  // TODO
                imgPath = op.FileName;
            }
        }
        private void Cancel_Click(object sender, RoutedEventArgs e)
        {
            CloseWindow();
        }
        private async void Register_Click(object sender, RoutedEventArgs e)
        {
            msgLabel.Content = "";

            if (!CheckPInput().Equals("OK"))
                msgLabel.Content = CheckProfileInputPolicy();
            else
            {
                Profile profileHandover = new Profile()
                {
                    Firstname = Utils.Encode(firstnameTXTbox.Text),
                    Lastname = Utils.Encode(lastnameTXTbox.Text),
                    Username = Utils.Encode(usernameTXTbox.Text),
                    Password = Utils.Encode(passwordTXTbox.Text),
                    Image = Utils.ImageToBYTEA(imgPath)
                };
                if (!File.Exists(@"C:\Program Files\BDGL\Data\apps\common\VRhouse\user\" + usernameTXTbox.Text + "_profile_db.json"))
                {
                    File.WriteAllText(@"C:\Program Files\BDGL\Data\apps\common\VRhouse\user\" + usernameTXTbox.Text + "_profile_db.json", JsonSerializer.Serialize(profileHandover));
                    Sender = registered = true;
                    msgLabel.Content = "Registered!";
                    await Task.Delay(2000);
                    msgLabel.Content = "";
                    await Task.Delay(1000);
                    CloseWindow();
                }
                else
                {
                    msgLabel.Content = "Account with this Username already exist";
                    await Task.Delay(3000);
                    msgLabel.Content = "";
                }
            }
        }
        public class Profile
        {
            public string Firstname { get; set; }
            public string Lastname { get; set; }
            public string Username { get; set; }
            public string Password { get; set; }
            public byte[] Image { get; set; }
        }
        private string CheckPInput()
        {
            if (usernameTXTbox.Text.Equals(""))
                return "Username is not allowed to be empty!";
            if (!CheckPasswordPolicy().Equals("OK"))
                return CheckPasswordPolicy();
            return "OK";
        }
        private string CheckProfileInputPolicy()
        {
            if (firstnameTXTbox.Text.Equals(""))
                return "Firstname is not allowed to be empty!";
            if (lastnameTXTbox.Text.Equals(""))
                return "Lastname is not allowed to be empty!";
            if (usernameTXTbox.Text.Equals(""))
                return "Username is not allowed to be empty!";
            if (!CheckPasswordPolicy().Equals("OK"))
                return CheckPasswordPolicy();
            return "OK";
        }
        private string CheckPasswordPolicy()
        {
            string passwordInput = passwordTXTbox.Text;

            if (passwordInput.Length < 8)
                return "Password should have at least 8 signs";
            if (!passwordInput.Any(c => char.IsLower(c)))
                return "No Lowercase";
            if (!passwordInput.Any(c => char.IsUpper(c)))
                return "No Uppercase";
            if (!passwordInput.Any(c => char.IsDigit(c)))
                return "No Digit";
            if (passwordInput.IndexOfAny("\\|¬¦`!\"£$%^&*()_+-=[]{};:'@#~<>,./? ".ToCharArray()) <= 0)
                return "No Unique Chars";
            if (!passwordTXTbox.Text.Equals(repeatedPasswordTXTbox.Text))
                return "Password is not equal";
            return "OK";
        }
        private void TextChangedEventHandler(object sender, TextChangedEventArgs args) {
            aSign.Foreground = Regex.Match(passwordTXTbox.Text, @"[a-z]", RegexOptions.ECMAScript).Success ? Brushes.Green : Brushes.Black;
            ASign.Foreground = Regex.Match(passwordTXTbox.Text, @"[A-Z]", RegexOptions.ECMAScript).Success ? Brushes.Green : Brushes.Black;
            SSign.Foreground = Regex.Match(passwordTXTbox.Text, @"[!,@,#,$,%,^,&,*,?,_,~,-,£,(,)]", RegexOptions.ECMAScript).Success ? Brushes.Green : Brushes.Black;
            lengthSign.Foreground = passwordTXTbox.Text.Length < 8 ? Brushes.Black : Brushes.Green;
        }
        private void Window_Drag(object sender, MouseButtonEventArgs e) {
            if (e.LeftButton == MouseButtonState.Pressed) DragMove();
        }
        private void Minimize_Application(object sender, MouseButtonEventArgs e) {
            WindowState = WindowState.Minimized;
        }
        private void Close_Application(object sender, MouseButtonEventArgs e) {
            CloseWindow();
        }
        private void CloseWindow() {
            Application.Current.MainWindow.Visibility = Visibility.Visible;
            Close();
        }
    }
}