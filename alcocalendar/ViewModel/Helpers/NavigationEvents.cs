using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace alcocalendar.ViewModel.Helpers
{
    public static class NavigationEvents
    {
        public static event EventHandler<string> NavigateToPageRequested;

        public static void OnNavigateToPage(string pageName)
        {
            NavigateToPageRequested?.Invoke(null, pageName);
        }
    }
}
