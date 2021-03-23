using JobTrackingProject.Entities.Concrete;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace JobTrackingProject.DataAccess.Concrete.EntitiyFrameworkCore.Mapping
{
    class ImportanceMap : IEntityTypeConfiguration<Importance>
    {
        public void Configure(EntityTypeBuilder<Importance> builder)
        {
            
        }
    }
}
