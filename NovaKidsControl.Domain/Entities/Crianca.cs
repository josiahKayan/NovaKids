

namespace NovaKidsControl.Domain.Entities
{
    public class Crianca : UserKids
    {
        public Crianca(int id, string name, string data, string horaEntrada, string horarioKids, string matricula) : base(id, name, data, horaEntrada, horarioKids, matricula)
        {
        }

        public override int Id { get; set; }
        public override string Name { get; set; }
        public override string Data { get; set; }
        public override string HoraEntrada { get; set; }
        public override string HorarioKids { get; set; }
        public override string Matricula { get; set; }


       
    }
}
