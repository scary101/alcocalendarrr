using alcocalendar.View;
using alcocalendar.ViewModel.Helpers;
using System;
using System.Collections.Generic;
using System.IO.Packaging;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;
using System.Windows.Navigation;
using System.Xml.Serialization;

namespace alcocalendar.ViewModel
{
    public class SelectDateUCViewModel : BindHelper
    {
        private readonly INavigationService _navigationService;
        private int _dayNumber;

        public BindCommand OpenAlcoMenu { get; private set; }

        public int DayNumber
        {
            get { return _dayNumber; }
            set
            {
                _dayNumber = value;
                OnPropertyChanged();
            }
        }

        private string _image;
        public string Image
        {
            get { return _image; }
            set
            {
                _image = value;
                OnPropertyChanged();
            }
        }

        private DateTime _date;
        public DateTime Date
        {
            get { return _date; }
            set
            {
                _date = value;
                OnPropertyChanged();
            }
        }

        public SelectDateUCViewModel(INavigationService navigationService)
        {
            _navigationService = navigationService ?? throw new ArgumentNullException(nameof(navigationService));
            OpenAlcoMenu = new BindCommand(_ => Open());
        }

        public void Open()
        {
            _navigationService.NavigateTo("SelectAlcoPageView", Date);
        }
    }



}
