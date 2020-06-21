using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using APBD_Kolokwium_s16451.Models;


namespace APBD_Kolokwium_s16451.Configurations
{
    public class TeamConfiguration : IEntityTypeConfiguration<Team>
    {
        public void Configure(EntityTypeBuilder<Team> builder)
        {
            builder.HasKey(e => e.IdTeam);
            builder.Property(e => e.TeamName).HasMaxLength(30).IsRequired();
            builder.Property(e => e.MaxAge).IsRequired();
        }
    }
}
