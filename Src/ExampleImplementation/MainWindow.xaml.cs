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

namespace ExampleImplementation
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        ToastViewModel ToastViewModel;

        public MainWindow()
        {
            InitializeComponent();

            ToastViewModel = new ToastViewModel();
        }

        private void SuccessButton_Click(object sender, RoutedEventArgs e)
        {
            ToastViewModel.ShowSuccess("Success message");
        }

        private void WarningButton_Click(object sender, RoutedEventArgs e)
        {
            ToastViewModel.ShowWarning("Warning message");
        }

        private void ErrorButton_Click(object sender, RoutedEventArgs e)
        {
            ToastViewModel.ShowError("Error message");
        }

        private void InformationButton_Click(object sender, RoutedEventArgs e)
        {
            ToastViewModel.ShowInformation("Information message");
        }
    }
}