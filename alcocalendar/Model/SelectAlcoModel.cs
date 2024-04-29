using System;
using System.Collections.Generic;
using System.IO.Packaging;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace alcocalendar.Model
{
    internal class SelectAlcoModel
    {
        public int alco {  get; set; }
        public string path {  get; set; }
        public bool isChosee {  get; set; }

        public SelectAlcoModel() { }

        public SelectAlcoModel(int alco, string path)
        {
            this.alco = alco;
            this.path = path;
            isChosee = false;
        }
    }
    enum Alco
    {
        Beer = 1,
        Champagne = 2,
        Martini = 3,
        Vodka = 4, 
        Whiskey = 5
    }
}
