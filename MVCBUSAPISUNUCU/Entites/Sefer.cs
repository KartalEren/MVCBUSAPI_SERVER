namespace MVCBUSAPI.Entites
{
    public class Sefer:BaseEntity
    {
        public DateTime Tarih { get; set; }
        public virtual ICollection<Otobüs> Otobüsler { get; set; }
        public virtual ICollection<AppUser> Kullancılar { get; set; }
        public Sefer()
        {
            Otobüsler = new HashSet<Otobüs>();
            Kullancılar = new HashSet<AppUser>();
        }
    }
}
