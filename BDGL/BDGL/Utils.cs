/** Encode/Decode Utils */

using System;
using System.IO;
using System.Text;
using System.Windows.Media.Imaging;

namespace BDGL
{
    internal class Utils
    {
        public static byte[] ImageToBYTEA(string imgPath)
        {
            byte[] data;
            BitmapEncoder encoder = new JpegBitmapEncoder();
            encoder.Frames.Add(BitmapFrame.Create(!imgPath.Equals("")
                ? new BitmapImage(new Uri(imgPath))
                : new BitmapImage(new Uri("pack://application:,,,/Resources/Icons/profile_dummy.png"))));
            using (MemoryStream ms = new MemoryStream())
            {
                encoder.Save(ms);
                data = ms.ToArray();
            }
            return data;
        }
        public static BitmapImage ConvertByteArrayToBitmapImage(string bytea)
        {
            MemoryStream stream = new MemoryStream(Convert.FromBase64String(bytea));
            stream.Seek(0, SeekOrigin.Begin);
            BitmapImage image = new BitmapImage() { };
            image.BeginInit();
            image.StreamSource = stream;
            image.EndInit();
            return image;
        }
        public static byte[] ConvertByteArrayStringToArray(string bytea)
        {
            MemoryStream stream = new MemoryStream(Convert.FromBase64String(bytea));
            return stream.ToArray();
        }
        public static string Encode(string plainText)
        {
            return Convert.ToBase64String(Encoding.UTF8.GetBytes(plainText));
        }
        public static string Decode(string EncodedInput)
        {
            return Encoding.UTF8.GetString(Convert.FromBase64String(EncodedInput));
        }
    }
}