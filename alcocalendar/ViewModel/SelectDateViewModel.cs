using alcocalendar.Model;
using alcocalendar.ViewModel.Helpers;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Navigation;

namespace alcocalendar.ViewModel
{
    public class SelectDateViewModel : BindHelper
    {
        private DateTime currentdate;

        private string _monthYear;
        public string MonthYear
        {
            get { return _monthYear; }
            set
            {
                _monthYear = value;
                OnPropertyChanged();
            }
        }
        public BindCommand Next { get; set; }
        public BindCommand Back { get; set; }


        public ObservableCollection<SelectDateUCViewModel> DayCards { get; private set; }
        private readonly INavigationService _navigationService;

        public SelectDateViewModel(INavigationService navigationService) 
        {
            _navigationService = navigationService; 

            currentdate = DateTime.Now;
            UpdateMonthYear();
            UpdateDayCards();
            Next = new BindCommand(_ => NextMonth());
            Back = new BindCommand(_ => BackMonth());
        }

        public void NextMonth()
        {
            currentdate = currentdate.AddMonths(1);
            UpdateMonthYear();
            UpdateDayCards();
        }

        public void BackMonth()
        {
            currentdate = currentdate.AddMonths(-1);
            UpdateMonthYear();
            UpdateDayCards();
        }

        private void UpdateMonthYear()
        {
            string monthName = currentdate.ToString("MMMM");
            string newMonthName = char.ToUpper(monthName[0]) + monthName.Substring(1);
            string year = currentdate.ToString("yyyy");
            MonthYear = $"{newMonthName} {year}";
        }

        private void UpdateDayCards()
        {
            DateTime firstDayOfMonth = new DateTime(currentdate.Year, currentdate.Month, 1);
            DateTime lastDayOfMonth = firstDayOfMonth.AddMonths(1).AddDays(-1);

            DayCards = new ObservableCollection<SelectDateUCViewModel>();

            for (DateTime date = firstDayOfMonth; date <= lastDayOfMonth; date = date.AddDays(1))
            {
                SelectDateUCViewModel card = new SelectDateUCViewModel(_navigationService);
                card.Date = date;
                card.DayNumber = date.Day;
                DayCards.Add(card);
            }

            OnPropertyChanged(nameof(DayCards));
        }
    }

}
