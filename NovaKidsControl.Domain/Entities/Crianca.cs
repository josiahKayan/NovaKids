

using System.ComponentModel.DataAnnotations.Schema;

namespace NovaKidsControl.Domain.Entities
{
    public class Crianca : UserKids
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
