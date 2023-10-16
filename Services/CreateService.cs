using cellularSystem.Data;
using cellularSystem.Models;
using cellularSystem.Schemas;
using lodging.Services;

namespace cellularSystem.Services;

public class CreateService
{
    public async Task<object> Create(
        CellphoneSchema prop)
    {
        using (var context = new CellphonesDb())
        {
            var cellphone = new CellphoneModel()
            {
                Brand = prop.Brand,
                Model = prop.Model,
                Identity = new Random().Next(),
                Specifications = new SpecificationsModel()
                {
                    Batery = new BateryModel()
                    {
                        Batery = prop.Batery,
                        Charger = prop.Charger
                    },
                    Body = new BodyModel()
                    {
                        Dimensions = prop.Dimensions,
                        Weight = prop.Weight,
                        WaterProtection = prop.WaterProtection
                    },
                    Camera = new CameraModel()
                    {
                        Front = prop.CameraFront,
                        Main = prop.CameraMain
                    },
                    Sound = new SoundModel()
                    {
                        Sound = prop.Sound
                        
                    },
                    General = new GeneralModel()
                    {
                        ReleaseYear = prop.ReleaseYear,
                        PriceLaunch = prop.PriceLaunch
                    },
                    Memoir = new MemoirsModel()
                    {
                      InternalStorage  = prop.InternalStorage,
                      RamMemory = prop.RamMemory
                    },
                    Other = new OthersModel()
                    {
                        InfraRed = prop.InfraRed,
                        Sensors = prop.Sensors,
                        Usb = prop.Usb
                    },
                    Platform = new PlatformModel()
                    {
                        Processor = prop.Processor,
                        OperationalSystem = prop.OperationalSystem
                    },
                    Screen = new ScreenModel()
                    {
                        Desinty = prop.Desinty,
                        Extras = prop.Extras,
                        Frequency = prop.Frequency,
                        Protection = prop.Protection,
                        Resolution = prop.Resolution,
                        Size = prop.Size,
                        Type = prop.Type
                    },
                    DataNetwork = new DataNetworksModel()
                    {
                        ThreeG = prop.ThreeG,
                        Bluetooth = prop.Bluetooth,
                        Gps = prop.Gps,
                        Nfc = prop.Nfc,
                        Wifi = prop.Wifi,
                        FiveG = prop.FiveG,
                        FourG = prop.FourG
                    }
                    
                }
                
                
            };
            if (cellphone is null) return false;

            var token = new TokenServices().GenerateToken(cellphone);

            await context.Cellphones.AddAsync(cellphone);
            await context.SaveChangesAsync();
            return new
            {
                cellphone,
                token
            };
        }
    }
}