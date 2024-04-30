using alcocalendar.View;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;
using System.Windows.Navigation;

namespace alcocalendar.ViewModel.Helpers
{
    public interface INavigationService
    {
        void NavigateTo(string pageKey, DateTime date);
    }

    public class NavigationHelper : INavigationService
    {
        private readonly Frame _frame;

        public NavigationHelper(Frame frame)
        {
            _frame = frame ?? throw new ArgumentNullException(nameof(frame));
        }

        public void NavigateTo(string pageKey, DateTime date)
        {
            switch (pageKey)
            {
                case "SelectAlcoPageView":
                    _frame.Navigate(new SelectAlcoPageView(date));
                    break;
                default:
                    break;
            }
        }
    }


}
