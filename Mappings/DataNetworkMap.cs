using cellularSystem.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace cellularSystem.Mappings;

public class DataNetworkMap: IEntityTypeConfiguration<DataNetworksModel>
{
    public void Configure(EntityTypeBuilder<DataNetworksModel> builder)
    {
        builder.ToTable("DataNetwork");
        builder.HasKey(prop => prop.Id);
        builder.Property(prop => prop.Bluetooth).HasColumnName("bluetooth").HasColumnType("varchar(100)").IsRequired();
        builder.Property(prop => prop.Gps).HasColumnName("gps").HasColumnType("bit").IsRequired();
        builder.Property(prop => prop.Wifi).HasColumnName("wifi").HasColumnType("varchar(100)").IsRequired();
        builder.Property(prop => prop.Nfc).HasColumnName("nfc").HasColumnType("bit").IsRequired();
        builder.Property(prop => prop.FiveG).HasColumnName("5g").HasColumnType("bit").IsRequired();
        builder.Property(prop => prop.FourG).HasColumnName("4g").HasColumnType("bit").IsRequired();
        builder.Property(prop => prop.ThreeG).HasColumnName("3g").HasColumnType("bit").IsRequired();
        builder.Property(prop => prop.Id).ValueGeneratedOnAdd();
    }
}