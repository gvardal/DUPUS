using Entities.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Repositories.Config
{
    public class UYUretimPlaniConfig : IEntityTypeConfiguration<UYUretimPlani>
    {
        public void Configure(EntityTypeBuilder<UYUretimPlani> builder)
        {
            builder.HasKey(p => p.UretimPlaniID);
        }
    }
}
