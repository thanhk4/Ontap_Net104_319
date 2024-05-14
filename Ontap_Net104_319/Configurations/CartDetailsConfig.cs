using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Ontap_Net104_319.Models;

namespace Ontap_Net104_319.Configurations
{
    public class CartDetailsConfig : IEntityTypeConfiguration<CartDetail>
    {
        public void Configure(EntityTypeBuilder<CartDetail> builder)
        {
           builder.HasKey(x => x.Id);
            builder.HasOne(p=>p.Cart).WithMany(p => p.CartDetails).HasForeignKey(p => p.Usename);
            builder.HasOne(p=>p.Product).WithMany(p=> p.Cartdetails).HasForeignKey(p => p.ProductId);
        }
    }
}
