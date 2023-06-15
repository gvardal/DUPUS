using Entities.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Repositories.Config
{
    public class UYKonumConfig : IEntityTypeConfiguration<UYKonum>
    {
        public void Configure(EntityTypeBuilder<UYKonum> builder)
        {
            builder.HasKey(p => p.KonumID);
        }
    }
}
