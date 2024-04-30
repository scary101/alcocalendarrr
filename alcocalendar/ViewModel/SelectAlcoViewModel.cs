using alcocalendar.Model;
using alcocalendar.View;
using alcocalendar.ViewModel.Helpers;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace alcocalendar.ViewModel
{
    public class SelectAlcoViewModel : BindHelper
    {
        public ObservableCollection<SelectAlcoUCViewModel> userconrol { get; set; }
        private List<SelectAlcoModel> alcos {  get; set; }
        public BindCommand Save {  get; private set; }
        public DateTime date { get; set; }

        public SelectAlcoViewModel(DateTime date)
        {
            this.date = date.Date;
            Save = new BindCommand(_ => SaveCard());
            alcos = new List<SelectAlcoModel>
            {
                new SelectAlcoModel {alco = (int)Alco.Beer, path = "C:\\Users\\user\\source\\repos\\alcocalendar\\alcocalendar\\Images\\beer.png" },
                new SelectAlcoModel {alco = (int)Alco.Martini, path = "C:\\Users\\user\\source\\repos\\alcocalendar\\alcocalendar\\Images\\martini.png" },
                new SelectAlcoModel {alco = (int)Alco.Vodka, path = "C:\\Users\\user\\source\\repos\\alcocalendar\\alcocalendar\\Images\\vodka.png" },
                new SelectAlcoModel {alco = (int)Alco.Champagne, path = "C:\\Users\\user\\source\\repos\\alcocalendar\\alcocalendar\\Images\\champagne.png" },
                new SelectAlcoModel {alco = (int)Alco.Whiskey, path = "C:\\Users\\user\\source\\repos\\alcocalendar\\alcocalendar\\Images\\whiskey.png" }
            };

            userconrol = new ObservableCollection<SelectAlcoUCViewModel>();

            foreach (var alc in alcos)
            {
                SelectAlcoUCViewModel card = new SelectAlcoUCViewModel();
                card.Selected = false;
                card.ImagePath = alc.path;
                userconrol.Add(card);
            }
        }

        public void SaveCard()
        {
            List<SelectDay> days = SerDeser.DeserData<SelectDay>("zametki.json");
            List<SelectAlcoModel> alco = new List<SelectAlcoModel>();
            for(int i = 0; i < userconrol.Count(); i++)
            {
                if (userconrol[i].Selected == true)
                {
                    alcos[i].isChosee = true;
                    alco.Add(alcos[i]);
                    
                }
            }
            if(alco != null)
            {
                SelectDay day = new SelectDay(date);
                day.alcolist = alco;
                days.Add(day);
                SerDeser.SerData<SelectDay>(days, "zametki.json");
            }
        }
    }

}
