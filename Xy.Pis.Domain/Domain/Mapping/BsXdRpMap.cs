using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Xy.Pis.Domain.Mapping
{
    public class BsXdRpMap : EntityTypeConfiguration<BsXdRp>
    {
        public BsXdRpMap()
        {
            // Primary Key
            this.HasKey(t => t.ID);

            // Properties
            this.Property(t => t.Code)
                .IsRequired()
                .HasMaxLength(20);

            this.Property(t => t.Name)
                .IsRequired()
                .HasMaxLength(50);

            this.Property(t => t.GroupMain)
                .IsRequired()
                .HasMaxLength(50);

            this.Property(t => t.GroupSub)
                .IsRequired()
                .HasMaxLength(50);

            this.Property(t => t.WbCode)
                .HasMaxLength(50);

            this.Property(t => t.PyCode)
                .HasMaxLength(50);

            this.Property(t => t.F1)
                .HasMaxLength(100);

            // Table & Column Mappings
            this.ToTable("BsXdRp");
            this.Property(t => t.ID).HasColumnName("ID");
            this.Property(t => t.Code).HasColumnName("Code");
            this.Property(t => t.Name).HasColumnName("Name");
            this.Property(t => t.GroupMain).HasColumnName("GroupMain");
            this.Property(t => t.GroupSub).HasColumnName("GroupSub");
            this.Property(t => t.OrderBy).HasColumnName("OrderBy");
            this.Property(t => t.IsActive).HasColumnName("IsActive");
            this.Property(t => t.WbCode).HasColumnName("WbCode");
            this.Property(t => t.PyCode).HasColumnName("PyCode");
            this.Property(t => t.LsOpenType).HasColumnName("LsOpenType");
            this.Property(t => t.OperId).HasColumnName("OperId");
            this.Property(t => t.OperTime).HasColumnName("OperTime");
            this.Property(t => t.LocationId).HasColumnName("LocationId");
            this.Property(t => t.F1).HasColumnName("F1");
            this.Property(t => t.IconIndex).HasColumnName("IconIndex");
            this.Property(t => t.ExecLocId).HasColumnName("ExecLocId");
            this.Property(t => t.IsNumberDisplay).HasColumnName("IsNumberDisplay");

            // Relationships
            this.HasOptional(t => t.BsLocation)
                .WithMany(t => t.BsXdRps)
                .HasForeignKey(d => d.ExecLocId);
            this.HasRequired(t => t.BsLocation1)
                .WithMany(t => t.BsXdRps1)
                .HasForeignKey(d => d.LocationId);
            this.HasRequired(t => t.BsUser)
                .WithMany(t => t.BsXdRps)
                .HasForeignKey(d => d.OperId);

        }
    }
}
