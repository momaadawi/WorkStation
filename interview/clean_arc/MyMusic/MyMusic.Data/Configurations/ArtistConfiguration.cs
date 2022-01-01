using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using MyMusic.Core.Models;

namespace MyMusic.Data.Configurations
{
    public partial class MusicConfiguration
    {
        public class ArtistConfiguration : IEntityTypeConfiguration<Artist>
    {
            public void Configure(EntityTypeBuilder<Artist> builder)
            {
                builder
                    .ToTable("Artists");

                builder
                    .HasKey( m => m.Id);

                builder
                    .Property(m => m.Id)
                    .UseIdentityColumn();

                 builder
                    .Property(m => m.Name)
                    .IsRequired()
                    .HasMaxLength(50);

            }
        }
    }
}