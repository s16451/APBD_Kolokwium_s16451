using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using APBD_Kolokwium_s16451.Models;

namespace APBD_Kolokwium_s16451.Configurations
{
    public class Championship_TeamConfiguration : IEntityTypeConfiguration<Championship_Team>
    {
        public void Configure(EntityTypeBuilder<Championship_Team> builder)
        {
            builder.HasKey(e => new { e.IdTeam, e.IdChampionship });

            builder
                .HasOne(e => e.Team)
                .WithMany(e => e.Championship_Teams)
                .HasForeignKey(e => e.IdTeam);

            builder
               .HasOne(e => e.Championship)
               .WithMany(e => e.Championship_Teams)
               .HasForeignKey(e => e.IdChampionship);

            builder.Property(e => e.Score).IsRequired();
        }
    }
}
