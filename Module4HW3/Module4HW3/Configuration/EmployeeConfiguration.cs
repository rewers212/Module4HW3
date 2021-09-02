using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Module4HW3
{
    public class EmployeeConfiguration : IEntityTypeConfiguration<Employee>
    {
        public void Configure(EntityTypeBuilder<Employee> builder)
        {
            builder.ToTable("Employee").HasKey(p => p.EmployeeId);
            builder.Property(p => p.EmployeeId).HasColumnName("EmployeeId").ValueGeneratedOnAdd();
            builder.Property(p => p.FirstName).IsRequired().HasColumnName("FirstName").HasMaxLength(50);
            builder.Property(p => p.LastName).IsRequired().HasColumnName("LastName").HasMaxLength(50);
            builder.Property(p => p.HiredDate).IsRequired().HasColumnName("HiredDate").HasColumnType("datetime2").HasMaxLength(7);
            builder.Property(p => p.DateOfBirth).HasColumnName("DateOfBirth").HasColumnType("date");
            builder.Property(p => p.OfficeId).IsRequired().HasColumnName("OfficeId");
            builder.Property(p => p.TitleId).IsRequired().HasColumnName("TitleId");
            builder.HasOne(e => e.Office)
                .WithMany(o => o.Employees)
                .HasForeignKey(e => e.OfficeId)
                .OnDelete(DeleteBehavior.Cascade);
            builder.HasOne(e => e.Title)
                 .WithMany(t => t.Employees)
                 .HasForeignKey(e => e.TitleId)
                 .OnDelete(DeleteBehavior.Cascade);
        }
    }
}
