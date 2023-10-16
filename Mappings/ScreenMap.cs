using cellularSystem.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace cellularSystem.Mappings;

public class ScreenMap : IEntityTypeConfiguration<ScreenModel>
{
    public void Configure(EntityTypeBuilder<ScreenModel> builder)
    {
        builder.ToTable("Screen");
        builder.HasKey(prop => prop.Id);
        builder.Property(prop => prop.Desinty).HasColumnName("density").HasColumnType("varchar(100)").IsRequired();
        builder.Property(prop => prop.Extras).HasColumnName("extras").HasColumnType("varchar(100)").IsRequired();
        builder.Property(prop => prop.Frequency).HasColumnName("frequency").HasColumnType("varchar(100)").IsRequired();
        builder.Property(prop => prop.Protection).HasColumnName("protection").HasColumnType("varchar(100)").IsRequired();
        builder.Property(prop => prop.Resolution).HasColumnName("resolution").HasColumnType("int").IsRequired();
        builder.Property(prop => prop.Size).HasColumnName("size").HasColumnType("int").IsRequired();
        builder.Property(prop => prop.Type).HasColumnName("type").HasColumnType("varchar(100)").IsRequired();
        builder.Property(prop => prop.Id).ValueGeneratedOnAdd();        

        
    }
}