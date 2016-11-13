using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace NovaKidsMvc.ViewModels
{
    public class UserKidsViewModel
    {

        public virtual int Id { get; set; }
        public virtual string Nome { get; set; }
        public virtual string Data { get; set; }
        public virtual string HoraEntrada { get; set; }
        public virtual string HorarioKids { get; set; }
        public virtual string Matricula { get; set; }

        public UserKidsViewModel(int id, string nome, string data, string horaEntrada, string horarioKids, string matricula)
        {
            this.Id = id;
            this.Nome = nome;
            this.Data = data;
            this.HoraEntrada = horaEntrada;
            this.HorarioKids = horarioKids;
            this.Matricula = matricula;
        }

    }
}