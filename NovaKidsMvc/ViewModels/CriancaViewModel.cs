using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace NovaKidsMvc.ViewModels
{
    public class CriancaViewModel : UserKidsViewModel
    {

        public override int Id { get; set; }
        public override string Nome { get; set; }
        public override string HorarioKids { get; set; }
        public override int Senib { get; set; }
        public override string Kids { get; set; }
        public override string Matricula { get; set; }
        public override string Tag { get; set; }
        public override string Tipo { get; set; }
    }
}