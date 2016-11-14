

namespace NovaKidsControl.Domain.Entities
{
    public class UserKids
    {
        public virtual int Id { get; set; }
        public virtual string Nome { get; set; }
        public virtual string HorarioKids { get; set; }
        public virtual int Senib { get; set; }
        public virtual string Kids { get; set; }
        public virtual string Matricula { get; set; }
        public virtual string Tag { get; set; }
        public virtual string Tipo { get; set; }

    //    public UserKids( int id, string nome, string horarioKids,int senib, string kids ,string matricula, string tag, string tipo)
    //    {
    //        this.Id = id;
    //        this.Nome = nome;
    //        this.HorarioKids = horarioKids;
    //        this.Senib = senib;
    //        this.Kids = kids;
    //        this.Matricula = matricula;
    //        this.Tag = tag;
    //        this.Tipo = tipo;
    //    }

    //public UserKids() { }
       
    }
}
