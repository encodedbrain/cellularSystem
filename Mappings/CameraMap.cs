using cellularSystem.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace cellularSystem.Mappings;

public class CameraMap : IEntityTypeConfiguration<CameraModel>
{
    public void Configure(EntityTypeBuilder<CameraModel> builder)
    {
        builder.ToTable("Camera");
        builder.HasKey(prop => prop.Id);
        builder.Property(prop => prop.Front).HasColumnName("front").HasColumnType("varchar(100)").IsRequired();
        builder.Property(prop => prop.Main).HasColumnName("main").HasColumnType("varchar(100)").IsRequired();
        builder.Property(prop => prop.Id).ValueGeneratedOnAdd();
    }
}