

namespace NovaKidsControl.Domain.Entities
{
    public class UserKids
    {
        public virtual int Id { get; set; }
        public virtual string Name { get; set; }
        public virtual string Data { get; set; }
        public virtual string HoraEntrada { get; set; }
        public virtual string HorarioKids { get; set; }
        public virtual string Matricula { get; set; }

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
