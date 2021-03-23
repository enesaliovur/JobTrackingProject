 using JobTrackingProject.Entities.Concrete;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace JobTrackingProject.DataAccess.Concrete.EntitiyFrameworkCore.Mapping
{
    public class DutyMap : IEntityTypeConfiguration<Duty>
    {
        public void Configure(EntityTypeBuilder<Duty> builder)
        {
            builder.HasKey(I => I.Id);
            builder.Property(I => I.Id).UseIdentityColumn();

            builder.Property(I => I.Name).HasMaxLength(100);
            builder.Property(I => I.Description).HasColumnType("ntext");

            builder.HasOne(I => I.Importance).WithMany(I => I.Duties).HasForeignKey(I => I.ImportanceId);
        }
    }
}
