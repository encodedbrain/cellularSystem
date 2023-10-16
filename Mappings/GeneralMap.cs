using cellularSystem.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace cellularSystem.Mappings;

public class GeneralMap : IEntityTypeConfiguration<GeneralModel>
{
    public void Configure(EntityTypeBuilder<GeneralModel> builder)
    {
        builder.ToTable("General");
        builder.HasKey(prop => prop.Id);
        builder.Property(prop => prop.PriceLaunch).HasColumnName("pricelaunch").HasColumnType("decimal").IsRequired();
        builder.Property(prop => prop.ReleaseYear).HasColumnName("releaseyear").HasColumnType("varchar(100)").IsRequired();
        builder.Property(prop => prop.Id).ValueGeneratedOnAdd();
    }
}