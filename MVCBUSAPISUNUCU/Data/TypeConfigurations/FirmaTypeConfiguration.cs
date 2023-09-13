using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using MVCBUSAPI.Entites;

namespace MVCBUSAPI.Data.TypeConfigurations
{
    public class FirmaTypeConfiguration : IEntityTypeConfiguration<Firma>
    {
        public void Configure(EntityTypeBuilder<Firma> builder)
        {
            builder.HasKey(x => x.Id);

            builder.Property(x => x.Id)
             .UseIdentityColumn(1, 1);

            builder.Property(x => x.Ad)
                .IsRequired()
            .HasMaxLength(100);
            builder.HasData

               (
               new Firma { Id = 1, Ad="Umut Turizm"},
               new Firma { Id = 2, Ad="Furkan Turizm"},
               new Firma { Id = 3, Ad="Eren Turizm"}
               );

        }
    }
}
