using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;
using MVCArchitecturePractice.Core.Entity;

namespace MVCArchitecturePractice.Data.Mapping
{
    public class UserMap : EntityTypeConfiguration<User>
    {
        public UserMap()
        {
            //Key
            HasKey(t => t.ID);

            //Property
            Property(t => t.ID).HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);
            Property(t => t.Name).IsRequired().HasMaxLength(20).HasColumnType("nvarchar");
            Property(t => t.Password).IsRequired().HasMaxLength(20).HasColumnType("nvarchar");
            Property(t => t.Address).IsRequired().HasMaxLength(100).HasColumnType("nvarchar");
            Property(t => t.Email).IsRequired().HasMaxLength(100).HasColumnType("nvarchar");
            Property(t => t.AddDate).IsRequired();
            Property(t => t.ModifyDate);

            //Table
            ToTable("User");
        }
    }
}
