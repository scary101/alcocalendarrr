using alcocalendar.View;
using alcocalendar.ViewModel;
using alcocalendar.ViewModel.Helpers;
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

namespace alcocalendar
{

    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            DataContext = new MainWindowViewModel(pageFrame);
            pageFrame.Content = new SelectDatePage(pageFrame);
        }

    }
}