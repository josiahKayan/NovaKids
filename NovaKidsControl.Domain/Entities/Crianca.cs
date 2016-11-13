

namespace NovaKidsControl.Domain.Entities
{
    public class Crianca : UserKids
    {
        public Crianca(int id, string nome, string data, string horaEntrada, string horarioKids, string matricula) : base(id, nome, data, horaEntrada, horarioKids, matricula)
        {
        }

        public override int Id { get; set; }
        public override string Nome { get; set; }
        public override string HorarioKids { get; set; }
       

       
    }
}
