using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using APBD_Kolokwium_s16451.Models;

namespace APBD_Kolokwium_s16451.Configurations
{
    public class ChampionshipConfiguration : IEntityTypeConfiguration<Championship>
    {
        public void Configure(EntityTypeBuilder<Championship> builder)
        {
            builder.HasKey(e => e.IdChampionship);
            builder.Property(e => e.OfficialName).HasMaxLength(100).IsRequired();
            builder.Property(e => e.Year).IsRequired();
        }
    }
}
