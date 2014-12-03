using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;
using MVCArchitecturePractice.Core.Data;

namespace MVCArchitecturePractice.Data.Mapping
{
    class MessageMap : EntityTypeConfiguration<Message>
    {
        public MessageMap()
       {
           //Key
           HasKey(t => t.ID);

           //Properties
           Property(t => t.ID).HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);
           Property(t => t.Comment).IsRequired().HasMaxLength(100).HasColumnType("nvarchar");
           Property(t => t.AddedDate).IsRequired();
           Property(t => t.ModifiedDate).IsRequired();

           //Table
           ToTable("Message");

           //Relation          
           HasRequired(t => t.User).WithMany(c => c.Messages).HasForeignKey(t => t.UserId).WillCascadeOnDelete(false);
       }       
    }
}
