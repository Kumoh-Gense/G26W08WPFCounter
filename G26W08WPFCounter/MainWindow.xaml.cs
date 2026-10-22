using System.Configuration;
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

namespace G26W08WPFCounter
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        protected int count = 0;
        public MainWindow()
        {
            InitializeComponent();
            TxtCount.Text = "0";
        }

        private void OnAdd(object sender, RoutedEventArgs e)
        {
            //BtnAdd.Content = "눌렸습니다";
            TxtCount.Text = $"{++count}";
        }

        private void TxtCount_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void OnSub(object sender, RoutedEventArgs e)
        {
            TxtCount.Text = $"{--count}";
        }
    }
}