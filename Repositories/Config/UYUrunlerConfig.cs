using Entities.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Repositories.Config
{
    public class UYUrunlerConfig : IEntityTypeConfiguration<UYUrunler>
    {
        public void Configure(EntityTypeBuilder<UYUrunler> builder)
        {
            builder.HasKey("UrunID");
        }
    }
}
