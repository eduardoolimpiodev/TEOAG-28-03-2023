using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using TEOAG.Domain.Entities;

namespace TEOAG.Data.Mappings
{
    public class ProductMap : IEntityTypeConfiguration<Product>
    {
        public void Configure(EntityTypeBuilder<Product> builder)
        {
            builder.ToTable("Products");

            builder.Property(pr => pr.ProductName)
                .HasColumnType("varchar(100)");

            builder.Property(pr => pr.SupplierDescription)
                .HasColumnType("varchar(255)");    
        }
    }
}