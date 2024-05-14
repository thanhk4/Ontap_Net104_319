using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Ontap_Net104_319.Models;

namespace Ontap_Net104_319.Configurations
{
    public class BuilConfig : IEntityTypeConfiguration<Buil>
    {
        public void Configure(EntityTypeBuilder<Buil> builder)
        {
           builder.HasKey(x => x.Id);
            builder.HasOne(p=> p.Account).WithMany(p=>p.Buils).HasForeignKey(p=>p.Usename);

        }
    }
}
