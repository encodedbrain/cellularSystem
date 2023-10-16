using cellularSystem.Mappings;
using cellularSystem.Models;
using Microsoft.EntityFrameworkCore;

namespace cellularSystem.Data;

public class CellphonesDb : DbContext
{
    public DbSet<BateryModel> Baterys { get; set; }
    public DbSet<BodyModel> Bodys { get; set; }
    public DbSet<CameraModel> Cameras { get; set; }
    public DbSet<CellphoneModel> Cellphones { get; set; }
    public DbSet<DataNetworksModel> DataNetworks { get; set; }
    public DbSet<GeneralModel> Generals { get; set; }
    public DbSet<MemoirsModel> Memoirs { get; set; }
    public DbSet<OthersModel> Others { get; set; }
    public DbSet<PlatformModel> Platforms { get; set; }
    public DbSet<ScreenModel> Screens { get; set; }
    public DbSet<SoundModel> Sounds { get; set; }
    public DbSet<SpecificationsModel> Specifications { get; set; }
    


    public CellphonesDb(DbContextOptions options) : base(options)
    {
    }

    public CellphonesDb()
    {
 
    }


    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        var configRoot = new ConfigurationBuilder()
            .SetBasePath(AppDomain.CurrentDomain.BaseDirectory)
            //replace appsettings.Development.json with appsettings.json
            .AddJsonFile("appsettings.Development.json")
            .Build();
        optionsBuilder.UseSqlServer(configRoot.GetConnectionString("DefaultConnection"));
        base.OnConfiguring(optionsBuilder);
    }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder
            .Entity<SpecificationsModel>()
            .HasOne(e => e.Cellphone)
            .WithOne(e => e.Specifications)
            .HasForeignKey<SpecificationsModel>(e => e.CellphoneId)
            .IsRequired();
        
        
        modelBuilder
            .Entity<BateryModel>()
            .HasOne(e => e.Specification)
            .WithOne(e => e.Batery)
            .HasForeignKey<BateryModel>(e => e.SpecificationId)
            .IsRequired();
        
              
        modelBuilder
            .Entity<BodyModel>()
            .HasOne(e => e.Specification)
            .WithOne(e => e.Body)
            .HasForeignKey<BodyModel>(e => e.SpecificationId)
            .IsRequired();
        
              
        modelBuilder
            .Entity<CameraModel>()
            .HasOne(e => e.Specification)
            .WithOne(e => e.Camera)
            .HasForeignKey<CameraModel>(e => e.SpecificationId)
            .IsRequired();
        
        
              
        modelBuilder
            .Entity<DataNetworksModel>()
            .HasOne(e => e.Specification)
            .WithOne(e => e.DataNetwork)
            .HasForeignKey<DataNetworksModel>(e => e.SpecificationId)
            .IsRequired();
        
        
              
        modelBuilder
            .Entity<GeneralModel>()
            .HasOne(e => e.Specification)
            .WithOne(e => e.General)
            .HasForeignKey<GeneralModel>(e => e.SpecificationId)
            .IsRequired();
        
              
        modelBuilder
            .Entity<MemoirsModel>()
            .HasOne(e => e.Specification)
            .WithOne(e => e.Memoir)
            .HasForeignKey<MemoirsModel>(e => e.SpecificationId)
            .IsRequired();
        
              
        modelBuilder
            .Entity<OthersModel>()
            .HasOne(e => e.Specification)
            .WithOne(e => e.Other)
            .HasForeignKey<OthersModel>(e => e.SpecificationId)
            .IsRequired();
        
              
        modelBuilder
            .Entity<PlatformModel>()
            .HasOne(e => e.Specification)
            .WithOne(e => e.Platform)
            .HasForeignKey<PlatformModel>(e => e.SpecificationId)
            .IsRequired();
        
              
        modelBuilder
            .Entity<ScreenModel>()
            .HasOne(e => e.Specification)
            .WithOne(e => e.Screen)
            .HasForeignKey<ScreenModel>(e => e.SpecificationId)
            .IsRequired();
        
              
        modelBuilder
            .Entity<SoundModel>()
            .HasOne(e => e.Specification)
            .WithOne(e => e.Sound)
            .HasForeignKey<SoundModel>(e => e.SpecificationId)
            .IsRequired();
        
        
        modelBuilder.ApplyConfiguration(new BateryMap());
        modelBuilder.ApplyConfiguration(new BodyMap());
        modelBuilder.ApplyConfiguration(new CameraMap());
        modelBuilder.ApplyConfiguration(new CellphoneMap());
        modelBuilder.ApplyConfiguration(new DataNetworkMap());
        modelBuilder.ApplyConfiguration(new GeneralMap());
        modelBuilder.ApplyConfiguration(new MemoirsMap());
        modelBuilder.ApplyConfiguration(new OthersMap());
        modelBuilder.ApplyConfiguration(new PlatformMap());
        modelBuilder.ApplyConfiguration(new ScreenMap());
        modelBuilder.ApplyConfiguration(new SoundMap());
        modelBuilder.ApplyConfiguration(new SpecificationMap());


    }
}