using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using MVCBUSAPI.Entites;

namespace MVCBUSAPI.Data.TypeConfigurations
{
    public class OtobüsTypeConfiguration : IEntityTypeConfiguration<Otobüs>
    {
        public void Configure(EntityTypeBuilder<Otobüs> builder)
        {
            builder.HasKey(x => x.Id);

            builder.Property(x => x.Id)
             .UseIdentityColumn(1, 1);

            builder.Property(x => x.KoltukSayısı)
            .HasDefaultValue(40);



            builder.HasOne<Firma>(x => x.Firma)
                .WithMany(x => x.Otobüsler)
                .HasForeignKey(x => x.FirmaId)
                .OnDelete(DeleteBehavior.Cascade);

            builder.HasOne<Sefer>(x => x.Sefer)
               .WithMany(x => x.Otobüsler)
               .HasForeignKey(x => x.SeferId)
               .OnDelete(DeleteBehavior.Cascade);



            builder.HasData

                (
                new Otobüs { Id = 1, KoltukSayısı = 40, FirmaId = 1, SeferId = 1 },
                new Otobüs { Id = 2, KoltukSayısı = 40, FirmaId = 2, SeferId = 2 },
                new Otobüs { Id = 3, KoltukSayısı = 40, FirmaId = 3, SeferId = 3 }      
                );
        }
    }
}
