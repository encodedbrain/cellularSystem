using cellularSystem.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace cellularSystem.Mappings;

public class CellphoneMap : IEntityTypeConfiguration<CellphoneModel>
{
    public void Configure(EntityTypeBuilder<CellphoneModel> builder)
    {
        builder.ToTable("Cellphone");
        builder.HasKey(prop => prop.Id);
        builder.Property(prop => prop.Brand).HasColumnName("brand").HasColumnType("varchar(100)").IsRequired();
        builder.Property(prop => prop.Model).HasColumnName("model").HasColumnType("varchar(100)").IsRequired();
        builder.Property(prop => prop.Id).ValueGeneratedOnAdd();
    }
}