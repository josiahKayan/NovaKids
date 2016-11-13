using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace NovaKidsMvc.ViewModels
{
    public class PresencaViewModel
    {
        public int Id { get; set; }
        public string Data { get; set; }
        public string HorarioKids { get; set; }
        public UserKidsViewModel UserKids { get; set; }

    }
}