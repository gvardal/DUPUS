using Entities.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repositories.Config
{
    public class UYIsEmriDurumuConfig : IEntityTypeConfiguration<UYIsEmriDurumu>
    {
        public void Configure(EntityTypeBuilder<UYIsEmriDurumu> builder)
        {
            builder.HasKey(k => k.IsEmriDurumId);
        }
    }
}
