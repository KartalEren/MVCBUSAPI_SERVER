using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using MVCBUSAPI.Entites;

namespace MVCBUSAPI.Data.TypeConfigurations
{
    public class SeferTypeConfiguration : IEntityTypeConfiguration<Sefer>
    {
        public void Configure(EntityTypeBuilder<Sefer> builder)
        {
            builder.HasKey(x => x.Id);

            builder.Property(x => x.Id)
             .UseIdentityColumn(1, 1);


            builder.Property(x => x.Tarih)
             .IsRequired();


            builder.HasData
             (
            new Sefer { Id = 1, Tarih = DateTime.Now.AddDays(1) },
            new Sefer { Id = 2, Tarih = DateTime.Now.AddDays(2) },
            new Sefer { Id = 3, Tarih = DateTime.Now.AddDays(3) }
             );

        }
    }
}
