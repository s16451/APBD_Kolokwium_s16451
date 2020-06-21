using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using APBD_Kolokwium_s16451.Models;


namespace APBD_Kolokwium_s16451.Configurations
{
    public class PlayerConfiguration : IEntityTypeConfiguration<Player>
    {
        public void Configure(EntityTypeBuilder<Player> builder)
        {
            builder.HasKey(e => e.IdPlayer);
            builder.Property(e => e.FirstName).HasMaxLength(30).IsRequired();
            builder.Property(e => e.LastName).HasMaxLength(50).IsRequired();
            builder.Property(e => e.DateOfBirth).IsRequired();
        }
    }
}
