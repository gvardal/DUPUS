using Entities.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Repositories.Config
{
    internal class UYKonumTuruConfig : IEntityTypeConfiguration<UYKonumTuru>
    {
        public void Configure(EntityTypeBuilder<UYKonumTuru> builder)
        {
            builder.HasKey(p => p.KonumTuruID);
        }
    }
}
