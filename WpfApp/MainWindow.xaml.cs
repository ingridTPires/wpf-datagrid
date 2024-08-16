using System.Windows;

namespace WpfApp
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            Xceed.Wpf.DataGrid.Licenser.LicenseKey = "DGP72DUAAA7UWWACJLA";
            InitializeComponent();

            DataContext = new MainViewModel();
        }
    }
}
