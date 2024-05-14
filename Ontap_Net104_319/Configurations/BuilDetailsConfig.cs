using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Ontap_Net104_319.Models;

namespace Ontap_Net104_319.Configurations
{
    public class BuilDetailsConfig : IEntityTypeConfiguration<BuilDetail>
    {
        public void Configure(EntityTypeBuilder<BuilDetail> builder)
        {
         builder.HasKey(x => x.Id);
            builder.HasOne(p=> p.Buil).WithMany(p=>p.Details).HasForeignKey(p=>p.BuillId);
            builder.HasOne(x => x.Product).WithMany(p => p.BuilDetails).HasForeignKey(p => p.ProductID);
        }
    }
}
