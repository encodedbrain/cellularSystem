using cellularSystem.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace cellularSystem.Mappings;

public class BodyMap : IEntityTypeConfiguration<BodyModel>
{
    public void Configure(EntityTypeBuilder<BodyModel> builder)
    {
        builder.ToTable("Body");
        builder.HasKey(prop => prop.Id);
        builder.Property(prop => prop.Dimensions).HasColumnName("dimensions").HasColumnType("varchar(100)").IsRequired();
        builder.Property(prop => prop.Weight).HasColumnName("weight").HasColumnType("varchar(100)").IsRequired();
        builder.Property(prop => prop.WaterProtection).HasColumnName("charger").HasColumnType("bit").IsRequired();
        builder.Property(prop => prop.Id).ValueGeneratedOnAdd();
    }
}