using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Ontap_Net104_319.Models;

namespace Ontap_Net104_319.Configurations
{
    public class CartConfig : IEntityTypeConfiguration<Cart>
    {
        public void Configure(EntityTypeBuilder<Cart> builder)
        {
            builder.HasKey(p => p.UseName);
            builder.HasOne(p => p.Account).WithOne(p => p.Cart).HasForeignKey<Cart>(p => p.UseName); // 1-1
        }
    }
}
