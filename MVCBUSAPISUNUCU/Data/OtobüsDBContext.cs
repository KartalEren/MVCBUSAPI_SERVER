using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using MVCBUSAPI.Entites;
using System.Reflection;
using System.Reflection.Emit;

namespace MVCBUSAPI.Data
{
    public class OtobüsDBContext : IdentityDbContext<AppUser, AppRole, int>
    {       //YÖNERGE-1***Identity için DBSet yapmamıza gerek yoktur. Bunu Identity sınıfından alıyor zaten otomatik olarak.
        public OtobüsDBContext(DbContextOptions<OtobüsDBContext> options) : base(options)
        {

        }
        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);//YÖNERGE-2***Çift DB Tablolarını OnModelCreating içine yazmaktansa önce bunu yazmalıyız sonra aşağıdaki tüm tabloları otomatik birleiştiren yapıyı yazarız. Burada sadece bu ifade kalsa yeter.
            builder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());//YÖNERGE-3***Burada tüm DBSetleri otomatik yapması için de  modelBuilder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly()); yapısını kullandık
            //builder.Entity<IdentityUserLogin<int>>().HasNoKey();
        }

        public virtual DbSet<Otobüs> Otobüsler { get; set; }
        public virtual DbSet<Firma> Firmalar { get; set; }
        public virtual DbSet<Sefer> Seferler { get; set; }
     //APPUSER VE APPROLE DB SET E GEREK YOKTURK. IDENTİTY İÇERİSİNDEN GELİYOR.
    }
}
