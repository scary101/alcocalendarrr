using alcocalendar.View;
using alcocalendar.ViewModel.Helpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;

namespace alcocalendar.ViewModel
{
    public class MainWindowViewModel
    {
        private readonly INavigationService _navigationService;

        public MainWindowViewModel(Frame frame)
        {
            _navigationService = new NavigationHelper(frame);
        }

    }
}
