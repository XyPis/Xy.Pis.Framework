using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Xy.Pis.Domain.Mapping
{
    public class VwInDrugCheckMap : EntityTypeConfiguration<VwInDrugCheck>
    {
        public VwInDrugCheckMap()
        {
            // Primary Key
            this.HasKey(t => new { t.Name, t.InvoNo, t.LsInOut, t.IsCancel, t.Price, t.Totality, t.Amount, t.InvoTime });

            // Properties
            this.Property(t => t.Name)
                .IsRequired()
                .HasMaxLength(50);

            this.Property(t => t.ItemName)
                .HasMaxLength(50);

            this.Property(t => t.Spec)
                .HasMaxLength(50);

            this.Property(t => t.InvoNo)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.DoctorName)
                .HasMaxLength(40);

            this.Property(t => t.LocationName)
                .HasMaxLength(30);

            this.Property(t => t.ExecLocName)
                .HasMaxLength(30);

            this.Property(t => t.LsInOut)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.Code)
                .HasMaxLength(20);

            this.Property(t => t.Price)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.Totality)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.UnitIdName)
                .HasMaxLength(50);

            this.Property(t => t.Amount)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.PatientName)
                .HasMaxLength(30);

            this.Property(t => t.SexName)
                .HasMaxLength(4);

            this.Property(t => t.InvItemName)
                .HasMaxLength(50);

            this.Property(t => t.GroupName)
                .HasMaxLength(8);

            this.Property(t => t.FormName)
                .HasMaxLength(50);

            // Table & Column Mappings
            this.ToTable("VwInDrugCheck");
            this.Property(t => t.Name).HasColumnName("Name");
            this.Property(t => t.ItemName).HasColumnName("ItemName");
            this.Property(t => t.Spec).HasColumnName("Spec");
            this.Property(t => t.InvoNo).HasColumnName("InvoNo");
            this.Property(t => t.DoctorName).HasColumnName("DoctorName");
            this.Property(t => t.LocationName).HasColumnName("LocationName");
            this.Property(t => t.ExecLocName).HasColumnName("ExecLocName");
            this.Property(t => t.LsInOut).HasColumnName("LsInOut");
            this.Property(t => t.IsCancel).HasColumnName("IsCancel");
            this.Property(t => t.Code).HasColumnName("Code");
            this.Property(t => t.Price).HasColumnName("Price");
            this.Property(t => t.Totality).HasColumnName("Totality");
            this.Property(t => t.UnitIdName).HasColumnName("UnitIdName");
            this.Property(t => t.Amount).HasColumnName("Amount");
            this.Property(t => t.InvoTime).HasColumnName("InvoTime");
            this.Property(t => t.PatientName).HasColumnName("PatientName");
            this.Property(t => t.SexName).HasColumnName("SexName");
            this.Property(t => t.Age).HasColumnName("Age");
            this.Property(t => t.InvItemName).HasColumnName("InvItemName");
            this.Property(t => t.GroupName).HasColumnName("GroupName");
            this.Property(t => t.IsMental).HasColumnName("IsMental");
            this.Property(t => t.IsExpen).HasColumnName("IsExpen");
            this.Property(t => t.FormName).HasColumnName("FormName");
            this.Property(t => t.IsInject).HasColumnName("IsInject");
        }
    }
}
