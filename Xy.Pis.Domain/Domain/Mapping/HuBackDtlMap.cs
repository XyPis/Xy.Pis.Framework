using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Xy.Pis.Domain.Mapping
{
    public class HuBackDtlMap : EntityTypeConfiguration<HuBackDtl>
    {
        public HuBackDtlMap()
        {
            // Primary Key
            this.HasKey(t => t.ID);

            // Properties
            this.Property(t => t.Memo)
                .IsRequired()
                .HasMaxLength(50);

            this.Property(t => t.VoucherNo)
                .IsRequired()
                .HasMaxLength(50);

            this.Property(t => t.F1)
                .HasMaxLength(100);

            this.Property(t => t.F2)
                .HasMaxLength(100);

            this.Property(t => t.F3)
                .HasMaxLength(100);

            this.Property(t => t.F4)
                .HasMaxLength(100);

            // Table & Column Mappings
            this.ToTable("HuBackDtl");
            this.Property(t => t.ID).HasColumnName("ID");
            this.Property(t => t.BillId).HasColumnName("BillId");
            this.Property(t => t.InBatchId).HasColumnName("InBatchId");
            this.Property(t => t.ItemId).HasColumnName("ItemId");
            this.Property(t => t.UnitId).HasColumnName("UnitId");
            this.Property(t => t.DrugNum).HasColumnName("DrugNum");
            this.Property(t => t.RetailPrice).HasColumnName("RetailPrice");
            this.Property(t => t.StockPrice).HasColumnName("StockPrice");
            this.Property(t => t.Memo).HasColumnName("Memo");
            this.Property(t => t.VoucherNo).HasColumnName("VoucherNo");
            this.Property(t => t.IsMargin).HasColumnName("IsMargin");
            this.Property(t => t.F1).HasColumnName("F1");
            this.Property(t => t.F2).HasColumnName("F2");
            this.Property(t => t.F3).HasColumnName("F3");
            this.Property(t => t.F4).HasColumnName("F4");

            // Relationships
            this.HasRequired(t => t.BsItem)
                .WithMany(t => t.HuBackDtls)
                .HasForeignKey(d => d.ItemId);
            this.HasRequired(t => t.BsUnit)
                .WithMany(t => t.HuBackDtls)
                .HasForeignKey(d => d.UnitId);
            this.HasRequired(t => t.HuBack)
                .WithMany(t => t.HuBackDtls)
                .HasForeignKey(d => d.BillId);
            this.HasRequired(t => t.HuStore)
                .WithMany(t => t.HuBackDtls)
                .HasForeignKey(d => d.InBatchId);

        }
    }
}
