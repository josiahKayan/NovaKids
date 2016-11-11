using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NovaKidsControl.Domain.Models
{
    public class Professor : UserKids
    {
        public new int Id { get; set; }

        public Professor() { }

        public Professor(int id, string name, string data, string horaEntrada, string horarioKids, string matricula)
        {
            Id = id;
            this.Name = name;
            this.Data = data;
            this.HoraEntrada = horaEntrada;
            this.HorarioKids = horarioKids;
            this.Matricula = matricula;
        }
    }
}
