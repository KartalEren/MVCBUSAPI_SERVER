using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using MVCBUSAPI.Entites;

namespace MVCBUSAPI.Data.TypeConfigurations
{
    public class AppRoleTypeConfiguration : IEntityTypeConfiguration<AppRole>
    {
        public void Configure(EntityTypeBuilder<AppRole> builder)
        {
            builder.HasData

                (
                new AppRole { Id = 1, Name = "SysAdmin", NormalizedName = "SYSADMIN", ConcurrencyStamp = Guid.NewGuid().ToString() },
                new AppRole { Id = 2, Name = "Admin", NormalizedName = "ADMIN", ConcurrencyStamp = Guid.NewGuid().ToString() },
                new AppRole { Id = 3, Name = "Çalışan", NormalizedName = "ÇALIŞAN", ConcurrencyStamp = Guid.NewGuid().ToString() },
                new AppRole { Id = 4, Name = "Müşteri", NormalizedName = "MÜŞTERİ", ConcurrencyStamp = Guid.NewGuid().ToString() }
               
                );
        }
    }
}
