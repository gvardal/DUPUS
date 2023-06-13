using Entities.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Repositories.Config
{
    public class UYIsEmriRotasiConfig : IEntityTypeConfiguration<UYIsEmriRotasi>
    {
        public void Configure(EntityTypeBuilder<UYIsEmriRotasi> builder)
        {
            builder.HasKey(p => p.IsEmriRotaID);    
        }
    }
}
