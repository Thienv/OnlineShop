using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using OnlineShop.Model;
using OnlineShop.Model.Models;

namespace OnlineShop.Data.Configuration
{
    public class FooterEC : IEntityTypeConfiguration<Footer>
    {
        public void Configure(EntityTypeBuilder<Footer> builder)
        {
            builder.Property(f => f.Content).HasMaxLength(EntitySetting.Footer.ContentMaxLength);
        }
    }
}
