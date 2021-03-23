﻿using JobTrackingProject.Entities.Concrete;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace JobTrackingProject.DataAccess.Concrete.EntitiyFrameworkCore.Mapping
{
    class NotificationMap : IEntityTypeConfiguration<Notification>
    {
        public void Configure(EntityTypeBuilder<Notification> builder)
        {
            builder.HasKey(I => I.Id);
            builder.Property(I => I.Id).UseIdentityColumn();

            builder.Property(I => I.Description).HasColumnType("ntext").IsRequired();

            builder.HasOne(I => I.AppUser).WithMany(I => I.Notifications).HasForeignKey(I => I.AppUserId);

        }
    }
}
