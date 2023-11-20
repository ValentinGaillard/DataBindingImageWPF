using System.IO;
using System.Windows;

namespace CineFile
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

            // Create an instance of MainViewModel and set it as the DataContext
            MainViewModel viewModel = new MainViewModel();
            DataContext = viewModel;
        }
    }
}