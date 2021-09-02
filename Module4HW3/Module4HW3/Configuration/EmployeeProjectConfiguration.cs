using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Module4HW3
{
    public class EmployeeProjectConfiguration : IEntityTypeConfiguration<EmployeeProject>
    {
        public void Configure(EntityTypeBuilder<EmployeeProject> builder)
        {
            builder.ToTable("EmployeeProject").HasKey(e => e.EmployeeProjectId);
            builder.Property(e => e.EmployeeProjectId).HasColumnName("EmployeeProjectId").ValueGeneratedOnAdd();
            builder.Property(e => e.Rate).IsRequired().HasColumnName("Rate").HasColumnType("money");
            builder.Property(e => e.StartedDate).IsRequired().HasColumnName("StartedDate").HasColumnType("datetime2").HasMaxLength(7);
            builder.Property(e => e.EmployeeId).IsRequired().HasColumnName("EmployeeId");
            builder.Property(e => e.ProjectId).IsRequired().HasColumnName("ProjectId");
            builder.HasOne(ep => ep.Employee)
                .WithMany(e => e.EmployeeProjects)
                .HasForeignKey(e => e.EmployeeId)
                .OnDelete(DeleteBehavior.Cascade);
            builder.HasOne(ep => ep.Project)
                .WithMany(e => e.EmployeeProjects)
                .HasForeignKey(e => e.ProjectId)
                .OnDelete(DeleteBehavior.Cascade);
        }
    }
}
