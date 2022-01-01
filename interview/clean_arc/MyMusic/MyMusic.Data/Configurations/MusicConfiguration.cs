using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using MyMusic.Core.Models;

namespace MyMusic.Data.Configurations
{
    public partial class MusicConfiguration : IEntityTypeConfiguration<Music>
    {
        public void Configure(EntityTypeBuilder<Music> builder)
        {
            builder
                .ToTable("Musics");

            builder
                .HasKey( m => m.Id);
                
            builder
                .Property(m => m.Id)
                .UseIdentityColumn();
            
            builder
                .Property( m => m.Name)
                .IsRequired()
                .HasMaxLength(50);
                
            builder
                .HasOne( m => m.Artist)
                .WithMany( m => m.Musics)
                .HasForeignKey( m => m.ArtistId);

                
        }
    }
}