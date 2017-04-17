using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Forms;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Framerater
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        int pathCount;
        int on;

        public MainWindow()
        {
            InitializeComponent();
            pathCount = 0;
        }
        
        private void loadButton_Click(object sender, RoutedEventArgs e)
        {
            OpenFileDialog openDiag = new OpenFileDialog();
            //openDiag.InitialDirectory = "c:\\";
            openDiag.Filter = "img files (*.jpg)|*.jpg|All files (*.*)|*.*";
            openDiag.FilterIndex = 2;
            openDiag.RestoreDirectory = true;
            try
            {
                openDiag.ShowDialog();
                openDiag.OpenFile();
                listBox.Items.Add(openDiag.FileName);
                pathCount++;
            }
            catch
            {
                Console.Write("Fail");
            }
        }

        private void goButton_Click(object sender, RoutedEventArgs e)
        {
            string[] pathArray = new string[pathCount];
            int index = 0;
            while (index < pathCount)
            {
                pathArray[index] = listBox.Items.GetItemAt(index).ToString();
                index++;
            }
            on = 1;
            
            while (on == 1)
            {
                index = 0;
                while (index < pathCount)
                {
                    BitmapImage img = new BitmapImage(new Uri(pathArray[index], UriKind.Relative));
                    picBox.Source.
                    System.Threading.Thread.Sleep(500);
                    index++;
                }
            }

        }

        private void playButton_Click(object sender, RoutedEventArgs e)
        {
            picBox.Source = new BitmapImage(new Uri(@"/1.jpg", UriKind.Relative));
        }

        private void stopButton_Click(object sender, RoutedEventArgs e)
        {

        }

        private void revButton_Click(object sender, RoutedEventArgs e)
        {

        }

        private void frmFwdButton_Click(object sender, RoutedEventArgs e)
        {

        }

        private void frmBackButton_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}
