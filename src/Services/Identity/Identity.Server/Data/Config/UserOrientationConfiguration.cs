using Identity.Server.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Identity.Server.Data.Config
{
    public class UserOrientationConfiguration : IEntityTypeConfiguration<UserOrientation>
    {
        public void Configure(EntityTypeBuilder<UserOrientation> builder)
        {
            builder.ToTable(name: "UserOrientations", schema: "Identity");
            builder.HasKey(o => new { o.UserId, o.OrientationId });
            builder.HasOne(o => o.User).WithMany(u => u.UserOrientations).HasForeignKey(o => o.UserId);
            builder.HasOne(o => o.Orientation).WithMany(u => u.UserOrientations).HasForeignKey(o => o.OrientationId);
        }
    }
}
