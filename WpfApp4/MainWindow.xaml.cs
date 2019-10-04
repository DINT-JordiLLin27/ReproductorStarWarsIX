using System;
using System.Collections.Generic;
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

namespace WpfApp4
{
    /// <summary>
    /// Lógica de interacción para MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void ClicksBotonesMultimedia(object sender, RoutedEventArgs e)
        {
            if ((sender as Button).Name == PlayButton.Name)
                ReproductorMediaElement.Play();
            else if ((sender as Button).Name == PauseButton.Name)
                ReproductorMediaElement.Pause();
            else if ((sender as Button).Name == StopButton.Name)
                ReproductorMediaElement.Stop();
        }

        private void RadioButtons_Checked(object sender, RoutedEventArgs e)
        {
            if ((sender as RadioButton).Name == Trailer1RadioButton.Name)
                ReproductorMediaElement.Source = new Uri(@"E:\DAMLocal\2_DAM\DINT\Programas\WpfApp4\vids\trailer1.mp4");
            if ((sender as RadioButton).Name == Trailer2RadioButton.Name)
                ReproductorMediaElement.Source = new Uri(@"E:\DAMLocal\2_DAM\DINT\Programas\WpfApp4\vids\trailer2.mp4");
        }

        private void SilencioCheckBox_Click(object sender, RoutedEventArgs e)
        {
            if (SilencioCheckBox.IsChecked == true)
                ReproductorMediaElement.IsMuted = true;
            else
                ReproductorMediaElement.IsMuted = false;
        }
    }
}
