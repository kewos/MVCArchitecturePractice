using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;
using MVCArchitecturePractice.Core.Data;

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
            Property(t => t.Name).IsRequired().HasMaxLength(12);
            Property(t => t.AddedDate).IsRequired();
            Property(t => t.ModifiedDate).IsRequired();

            //Table
            ToTable("Customer");
        }
    }
}
