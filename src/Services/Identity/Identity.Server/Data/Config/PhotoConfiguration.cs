using Identity.Server.Models;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;

namespace Identity.Server.Data.Config
{
    public class PhotoConfiguration : IEntityTypeConfiguration<Photo>
    {
        public void Configure(EntityTypeBuilder<Photo> builder)
        {
            builder.ToTable(name: "Photos", schema: "Identity");
            builder.HasKey(p => p.Id);
            builder.Property(p => p.Url).IsRequired();
            builder.Property(p => p.Path).IsRequired();
            builder.Property(p => p.IsMain).IsRequired();
            builder
                .HasOne(p => p.User)
                .WithMany(u => u.Photos);
        }
    }
}

