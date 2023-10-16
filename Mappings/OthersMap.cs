using cellularSystem.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace cellularSystem.Mappings;

public class OthersMap : IEntityTypeConfiguration<OthersModel>
{
    public void Configure(EntityTypeBuilder<OthersModel> builder)
    {
        builder.ToTable("Others");
        builder.HasKey(prop => prop.Id);
        builder.Property(prop => prop.Sensors).HasColumnName("sensors").HasColumnType("varchar(100)").IsRequired();
        builder.Property(prop => prop.Usb).HasColumnName("usb").HasColumnType("varchar(100)").IsRequired();
        builder.Property(prop => prop.InfraRed).HasColumnName("infrared").HasColumnType("bit").IsRequired();
        builder.Property(prop => prop.Id).ValueGeneratedOnAdd();



    }
}