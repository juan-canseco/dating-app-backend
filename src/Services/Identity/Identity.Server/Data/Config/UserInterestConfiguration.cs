using Identity.Server.Models;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;

namespace Identity.Server.Data.Config
{
    public class UserInterestConfiguration : IEntityTypeConfiguration<UserInterest>
    {
        public void Configure(EntityTypeBuilder<UserInterest> builder)
        {
            builder.ToTable(name: "UserInterests", schema: "Identity");
            builder.HasKey(i => new { i.UserId, i.InterestId });
            builder.HasOne(i => i.User).WithMany(u => u.UserInterests).HasForeignKey(i => i.UserId);
            builder.HasOne(i => i.Interest).WithMany(i => i.UserInterests).HasForeignKey(i => i.InterestId);
        }
    }

}
