using Identity.Server.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Identity.Server.Data.Config
{
    public class OrientationConfiguration : IEntityTypeConfiguration<Orientation>
    {
        public void Configure(EntityTypeBuilder<Orientation> builder)
        {
            builder.ToTable(name: "Orientations", schema: "Identity");
            builder.HasKey(x => x.Id);
            builder.Property(x => x.Name).IsRequired().HasMaxLength(50).ValueGeneratedOnAdd();
        }
    }
}
