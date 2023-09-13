using Microsoft.AspNetCore.Components.Web.Virtualization;

namespace MVCBUSAPI.Entites
{
    public class Otobüs:BaseEntity
    {
        public int? KoltukSayısı { get; set; }
       
        public virtual Firma Firma { get; set; }
        public virtual int FirmaId { get; set; }
        public virtual Sefer Sefer { get; set; }
        public virtual int SeferId { get; set; }
      
    }
}
