using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NovaKidsControl.Domain.Models
{
    public class UserKids
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Data { get; set; }
        public string HoraEntrada { get; set; }
        public string HorarioKids { get; set; }
        public string Matricula { get; set; }

        public UserKids(int id, string name , string data, string horaEntrada, string horarioKids, string matricula)
        {
            this.Id = id;
            this.Name = name;
            this.Data = data;
            this.HoraEntrada = horaEntrada;
            this.HorarioKids = horarioKids;
            this.Matricula = matricula;
        }


    }
}
