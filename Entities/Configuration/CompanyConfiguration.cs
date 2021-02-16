using Entities.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;

namespace Entities.Configuration
{
    public class CompanyConfiguration : IEntityTypeConfiguration<Company>
    {
        public void Configure(EntityTypeBuilder<Company> builder)
        {
            builder.HasData
            (
              new Company
              {
                  Id = new Guid("c9d4c053-49b6-410c-bc78-2d54a9991870"),
                  Name = "Raveshmand_Ltd",
                  Address = "Tehran,Tajrish",
                  Country = "Iran"
              },
              new Company
              {
                  Id = new Guid("3d490a70-94ce-4d15-9494-5248280c2ce3"),
                  Name = "Geeks_Ltd",
                  Address = "London",
                  Country = "English"
              }
            );
        }
    }

}
