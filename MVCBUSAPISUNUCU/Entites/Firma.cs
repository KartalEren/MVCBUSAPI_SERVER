namespace MVCBUSAPI.Entites
{
    public class Firma: BaseEntity
    {
        public string  Ad { get; set; }
        public virtual ICollection<Otobüs> Otobüsler { get; set; }
        public virtual ICollection<AppUser> Kullanıcılar { get; set; }

        public Firma()
        {
            Otobüsler = new HashSet<Otobüs>();
            Kullanıcılar = new HashSet<AppUser>();
        }
    }
}
