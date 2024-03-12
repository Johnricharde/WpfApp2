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

namespace WpfApp1
{
    public partial class MainWindow : Window
    {
        bool running = false;
        public MainWindow()
        {
            InitializeComponent();
        }

        private void runButtonToggle_Click(object sender, RoutedEventArgs e)
        {
            if (running)
            {
                textBlockTest.Text = "Test running";
                runButtonToggle.Content = "RUN";
            }
            else
            {
                textBlockTest.Text = "Test stopped";
                runButtonToggle.Content = "STOP";
            }
            running = !running;
        }
    }
}