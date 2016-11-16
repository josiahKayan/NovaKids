using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace NovaKidsMvc.ViewModels
{
    public  class UserKidsViewModel
    {

        public virtual int Id { get; set; }
        public virtual string Nome { get; set; }
        public virtual string HorarioKids { get; set; }
        public virtual int Senib { get; set; }
        public virtual string Kids { get; set; }
        public virtual string Matricula { get; set; }
        public virtual string Tag { get; set; }
        public virtual string Tipo { get; set; }

    }
}