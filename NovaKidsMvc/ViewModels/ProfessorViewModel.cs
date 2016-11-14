using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace NovaKidsMvc.ViewModels
{
    public class ProfessorViewModel : UserKidsViewModel
    {

        public override int Id { get; set; }
        public override string Nome { get; set; }
        public override string HorarioKids { get; set; }
        public override int Senib { get; set; }
        public override string Kids { get; set; }
        public override string Matricula { get; set; }
        public override string Tag { get; set; }
        public override string Tipo { get; set; }

        //public ProfessorViewModel(int id, string nome, string horarioKids, int senib, string matricula, string tag, string tipo) : base(id, nome, horarioKids, senib, matricula, tag, tipo)
        //{
        //    this.Id = id;
        //    this.Nome = nome;
        //    this.HorarioKids = horarioKids;
        //    this.Senib = senib;
        //    this.Matricula = matricula;
        //    this.Tag = tag;
        //    this.Tipo = tipo;
        //}
    }
}