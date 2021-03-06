using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Xy.Pis.Domain.Mapping
{
    public class Vw_zycybrxxMap : EntityTypeConfiguration<Vw_zycybrxx>
    {
        public Vw_zycybrxxMap()
        {
            // Primary Key
            this.HasKey(t => new { t.住院号, t.姓名, t.性别, t.住院次数, t.入院日期 });

            // Properties
            this.Property(t => t.住院号)
                .IsRequired()
                .HasMaxLength(13);

            this.Property(t => t.姓名)
                .IsRequired()
                .HasMaxLength(30);

            this.Property(t => t.住院信息)
                .HasMaxLength(44);

            this.Property(t => t.性别)
                .IsRequired()
                .HasMaxLength(4);

            this.Property(t => t.主管医生)
                .HasMaxLength(40);

            this.Property(t => t.住院次数)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.病人类别)
                .HasMaxLength(50);

            this.Property(t => t.入院科室)
                .HasMaxLength(30);

            this.Property(t => t.住院科室)
                .HasMaxLength(30);

            this.Property(t => t.床位号)
                .HasMaxLength(10);

            // Table & Column Mappings
            this.ToTable("Vw_zycybrxx");
            this.Property(t => t.住院号).HasColumnName("住院号");
            this.Property(t => t.姓名).HasColumnName("姓名");
            this.Property(t => t.住院信息).HasColumnName("住院信息");
            this.Property(t => t.性别).HasColumnName("性别");
            this.Property(t => t.主管医生).HasColumnName("主管医生");
            this.Property(t => t.住院次数).HasColumnName("住院次数");
            this.Property(t => t.入院日期).HasColumnName("入院日期");
            this.Property(t => t.出院日期).HasColumnName("出院日期");
            this.Property(t => t.病人类别).HasColumnName("病人类别");
            this.Property(t => t.入院科室).HasColumnName("入院科室");
            this.Property(t => t.住院科室).HasColumnName("住院科室");
            this.Property(t => t.床位号).HasColumnName("床位号");
            this.Property(t => t.住院天数).HasColumnName("住院天数");
            this.Property(t => t.排序).HasColumnName("排序");
        }
    }
}
