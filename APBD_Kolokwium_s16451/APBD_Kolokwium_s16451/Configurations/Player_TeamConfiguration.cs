using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using APBD_Kolokwium_s16451.Models;

namespace APBD_Kolokwium_s16451.Configurations
{
    public class Player_TeamConfiguration : IEntityTypeConfiguration<Player_Team>
    {
        public void Configure(EntityTypeBuilder<Player_Team> builder)
        {
            builder.HasKey(e => new { e.IdPlayer, e.IdTeam });

            builder
                .HasOne(e => e.Player)
                .WithMany(e => e.Player_Teams)
                .HasForeignKey(e => e.IdPlayer);

            builder
               .HasOne(e => e.Team)
               .WithMany(e => e.Player_Teams)
               .HasForeignKey(e => e.IdTeam);

            builder.Property(e => e.Comment).HasMaxLength(300);
            builder.Property(e => e.NumOnShirt).IsRequired();
        }
    }
}
