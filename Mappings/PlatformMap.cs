using cellularSystem.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace cellularSystem.Mappings;

public class PlatformMap : IEntityTypeConfiguration<PlatformModel>
{
    public void Configure(EntityTypeBuilder<PlatformModel> builder)
    {
        builder.ToTable("Platform");
        builder.HasKey(prop => prop.Id);
        builder.Property(prop => prop.Processor).HasColumnName("processor").HasColumnType("varchar(100)").IsRequired();
        builder.Property(prop => prop.OperationalSystem).HasColumnName("operationalsystem").HasColumnType("varchar(100)").IsRequired();
        builder.Property(prop => prop.Id).ValueGeneratedOnAdd();
    }
}