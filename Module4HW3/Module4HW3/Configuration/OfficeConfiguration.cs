using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Module4HW3
{
    public class OfficeConfiguration : IEntityTypeConfiguration<Office>
    {
        public void Configure(EntityTypeBuilder<Office> builder)
        {
            builder.ToTable("Office").HasKey(o => o.OfficeId);
            builder.Property(o => o.OfficeId).HasColumnName("OfficeId").ValueGeneratedOnAdd();
            builder.Property(o => o.OfficeId).HasColumnName("Title").HasMaxLength(100);
            builder.Property(o => o.Location).HasColumnName("Location").HasMaxLength(100);
        }
    }
}
