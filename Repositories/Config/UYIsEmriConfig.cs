using Entities.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Repositories.Config
{
    public class UYIsEmriConfig : IEntityTypeConfiguration<UYIsEmri>
    {
        public void Configure(EntityTypeBuilder<UYIsEmri> builder)
        {
            builder.HasKey(p => p.IsEmriID);
        }
    }
}
