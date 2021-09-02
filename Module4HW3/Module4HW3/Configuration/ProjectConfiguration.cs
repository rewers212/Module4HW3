using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Module4HW3
{
    public class ProjectConfiguration : IEntityTypeConfiguration<Project>
    {
        public void Configure(EntityTypeBuilder<Project> builder)
        {
            builder.ToTable("Project").HasKey(o => o.ProjectId);
            builder.Property(o => o.ProjectId).HasColumnName("ProjectId").ValueGeneratedOnAdd();
            builder.Property(o => o.Name).HasColumnName("Name").HasMaxLength(50);
            builder.Property(o => o.Budget).HasColumnName("budget").HasColumnType("money");
            builder.Property(o => o.StartedDate).IsRequired().HasColumnName("StartedDate").HasColumnType("datetime2").HasMaxLength(7);
        }
    }
}
