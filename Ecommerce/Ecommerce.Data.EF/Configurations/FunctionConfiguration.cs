using Ecommerce.Data.EF.Extensions;
using Ecommerce.Data.Entities;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Ecommerce.Data.EF.Configurations
{
    public class FunctionConfiguration : DbEntityConfiguration<Function>
    {
        public override void Configure(EntityTypeBuilder<Function> entity)
        {
            entity.HasKey(x => x.Id);
            entity.Property(x => x.Id).IsRequired().HasMaxLength(128).IsUnicode(false);
        }
    }
}
