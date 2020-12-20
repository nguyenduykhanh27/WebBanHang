using Ecommerce.Data.EF.Extensions;
using Ecommerce.Data.Entities;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Ecommerce.Data.EF.Configurations
{
    public class ContactDetailConfiguration : DbEntityConfiguration<Contact>
    {
        public override void Configure(EntityTypeBuilder<Contact> entity)
        {
            entity.HasKey(x => x.Id);
            entity.Property(x => x.Id).IsRequired().HasMaxLength(128).IsUnicode(false);
        }
    }
}
