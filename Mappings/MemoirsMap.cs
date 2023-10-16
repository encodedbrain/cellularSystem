using cellularSystem.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace cellularSystem.Mappings;

public class MemoirsMap : IEntityTypeConfiguration<MemoirsModel>
{
    public void Configure(EntityTypeBuilder<MemoirsModel> builder)
    {
        builder.ToTable("Memoirs");
        builder.HasKey(prop => prop.Id);
        builder.Property(prop => prop.InternalStorage).HasColumnName("internalstorage").HasColumnType("int").IsRequired();
        builder.Property(prop => prop.RamMemory).HasColumnName("ram").HasColumnType("int").IsRequired();
        builder.Property(prop => prop.Id).ValueGeneratedOnAdd();

    }
}