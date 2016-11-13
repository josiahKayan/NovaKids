using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace NovaKidsMvc.ViewModels
{
    public class ProfessorViewModel : UserKidsViewModel
    {
        public ProfessorViewModel(int id, string nome, string data, string horaEntrada, string horarioKids, string matricula) : base(id, nome, data, horaEntrada, horarioKids, matricula)
        {
        }

        public override int Id { get; set; }
        public override string Nome { get; set; }
        public override string HorarioKids { get; set; }


    }
}