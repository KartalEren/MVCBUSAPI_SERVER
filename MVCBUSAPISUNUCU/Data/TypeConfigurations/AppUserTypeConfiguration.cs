using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using MVCBUSAPI.Entites;

namespace MVCBUSAPI.Data.TypeConfigurations
{
    public class AppUserTypeConfiguration : IEntityTypeConfiguration<AppUser>
    {
        public void Configure(EntityTypeBuilder<AppUser> builder)
        {
            builder.HasOne<Firma>(x => x.Firma)
                .WithMany(x => x.Kullanıcılar)
                .HasForeignKey(x => x.FirmaId)
                .OnDelete(DeleteBehavior.Cascade);

            builder.HasOne<Sefer>(x => x.Sefer)
               .WithMany(x => x.Kullancılar)
               .HasForeignKey(x => x.SeferId)
               .OnDelete(DeleteBehavior.Cascade);

            builder.HasData
                 (
                     new AppUser
                     {
                         Id = 1,
                         Ad = "Erden",
                         Soyad = "Timur",
                         Email = "sysadmin@gmail.com",
                         Sifre = "1234",
                     },

                     new AppUser
                     {
                         Id = 2,
                         Ad = "Okan",
                         Soyad = "Buruk",
                         Email = "admin@gmail.com",
                         Sifre = "1234",
                     },

                     new AppUser
                     {
                         Id = 3,
                         Ad = "Umut",
                         Soyad = "Öncel",
                         Email = "umut@gmail.com",
                         Sifre = "1234",
                         FirmaId = 1
                     },

                     new AppUser
                     {
                         Id = 4,
                         Ad = "Eren",
                         Soyad = "Kartal",
                         Email = "eren@gmail.com",
                         Sifre = "1234",
                         FirmaId = 2
                     },

                     new AppUser
                     {
                         Id = 5,
                         Ad = "Furkan",
                         Soyad = "Kahveci",
                         Email = "furkan@gmail.com",
                         Sifre = "1234",
                         FirmaId = 3
                     },

                     new AppUser
                     {
                         Id = 6,
                         Ad = "Mauro",
                         Soyad = "Icardi",
                         Email = "sysadmin@gmail.com",
                         Sifre = "1234",
                         SeferId = 1
                     }
                 );

        }
    }
}
