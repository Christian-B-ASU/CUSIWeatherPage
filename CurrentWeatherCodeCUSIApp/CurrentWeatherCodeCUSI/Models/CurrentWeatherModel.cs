using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CurrentWeatherCodeCUSI.Models
{
    public class CurrentWeatherModel
    {
        public Weather[] weather { get; set; }
        public Main Main { get; set; }
        public int dt { get; set; }
        public Sys sys { get; set; }
        public string name { get; set; }
        public int cod { get; set; }
    }
}
