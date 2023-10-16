using cellularSystem.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace cellularSystem.Mappings;

public class BateryMap : IEntityTypeConfiguration<BateryModel>
{
    public void Configure(EntityTypeBuilder<BateryModel> builder)
    {
        builder.ToTable("Batery");
        builder.HasKey(prop => prop.Id);


        builder.Property(prop => prop.Batery).HasColumnName("batery").HasColumnType("varchar(100)").IsRequired();
        builder.Property(prop => prop.Charger).HasColumnName("charger").HasColumnType("varchar(100)").IsRequired();
        builder.Property(prop => prop.Id).ValueGeneratedOnAdd();
    }
}