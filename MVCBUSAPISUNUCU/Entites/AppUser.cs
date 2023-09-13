using Microsoft.AspNetCore.Identity;

namespace MVCBUSAPI.Entites
{
    public class AppUser:IdentityUser<int>
    {
        public string Ad { get; set; }
        public string Soyad { get; set; }
        public string Sifre { get; set; }
        public virtual Firma? Firma { get; set; }
        public virtual int? FirmaId { get; set; }
        public virtual Sefer? Sefer { get; set; }
        public virtual int? SeferId { get; set; }
    }
}
