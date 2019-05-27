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
using System.Windows.Threading;

namespace SimpleWPFApp
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private delegate void ProgressBarDelegate(DependencyProperty dp, Object value);
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Button1_Click(object sender, RoutedEventArgs e)
        {
            var progress = 0d;
            var updatePbDelegate = new ProgressBarDelegate(progressBar1.SetValue);

            do
            {
                progress++;

                Dispatcher.Invoke(updatePbDelegate,
                    DispatcherPriority.Background,
                    new object[] { ProgressBar.ValueProperty, progress });
                progressBar1.Value = progress;
            }
            while (progressBar1.Value != progressBar1.Maximum);

            checkBox1.IsEnabled = true;
        }
    }
}