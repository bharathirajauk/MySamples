using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace ImageEditorSample
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            BitmapImage BitmapImage = new BitmapImage();
            BitmapImage.BeginInit();
      
            // Loading 10MB size image to the Image control.
            BitmapImage.UriSource = new Uri(@"Assets/image.jpg", UriKind.Relative);
            
            // To load 50KB size image to the Image control.
           // BitmapImage.UriSource = new Uri(@"Assets/Image1.jpeg", UriKind.Relative);

            BitmapImage.EndInit();
            image.Source = BitmapImage;
            TestBitmap2ByteArray(new BitmapImage(new Uri(image.Source.ToString())));
        }

        public static void TestBitmap2ByteArray(BitmapImage bitmap)
        {
            JpegBitmapEncoder encoder = new JpegBitmapEncoder();
            MemoryStream memstream = new MemoryStream();
            encoder.Frames.Add(BitmapFrame.Create(bitmap));
            encoder.Save(memstream);

            memstream.Close();
        }
    }
}
