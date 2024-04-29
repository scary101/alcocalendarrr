using alcocalendar.ViewModel;
using alcocalendar.ViewModel.Helpers;
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

namespace alcocalendar.View
{
    public partial class SelectDatePage : Page
    {
        public SelectDatePage(Frame frame)
        {
            InitializeComponent();
            var navigationService = new NavigationHelper(frame); 

            DataContext = new SelectDateViewModel(navigationService);
        }
    }
}
