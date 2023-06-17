using Microsoft.EntityFrameworkCore;

namespace EFCoreMoviesForVue.Entities.Configurations
{
    public class MovieConfig : IEntityTypeConfiguration<Movie>
    {
        public void Configure(Microsoft.EntityFrameworkCore.Metadata.Builders.EntityTypeBuilder<Movie> builder)
        {
            builder.HasKey(m => m.Id);
            builder.Property(m => m.Title).IsRequired().HasMaxLength(100);
            builder.Property(m => m.ImgUrl).IsRequired().HasMaxLength(200);
            builder.Property(m => m.Synopsis).IsRequired().HasMaxLength(500);
        }

    }
}
