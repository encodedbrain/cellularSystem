using cellularSystem.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace cellularSystem.Mappings;

public class SpecificationMap : IEntityTypeConfiguration<SpecificationsModel>
{
    public void Configure(EntityTypeBuilder<SpecificationsModel> builder)
    {
        builder.ToTable("specification");
        builder.HasKey(prop => prop.Id);
        builder.Property(prop => prop.Id).ValueGeneratedOnAdd();
    }
}