using cellularSystem.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace cellularSystem.Mappings;

public class SoundMap : IEntityTypeConfiguration<SoundModel>
{
    public void Configure(EntityTypeBuilder<SoundModel> builder)
    {
        builder.ToTable("Sound");
        builder.HasKey(prop => prop.Id);
        builder.Property(prop => prop.Sound).HasColumnName("sound").HasColumnType("varchar(100)").IsRequired();
        builder.Property(prop => prop.Id).ValueGeneratedOnAdd();
    }
}