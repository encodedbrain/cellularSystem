namespace cellularSystem.Models;

public class DataNetworksModel
{
    
    public int Id { get; set; }

    public DataNetworksModel(bool threeG, bool fourG, bool fiveG, string wifi, string bluetooth, bool gps, bool nfc)
    {
        ThreeG = threeG;
        FourG = fourG;
        FiveG = fiveG;
        Wifi = wifi;
        Bluetooth = bluetooth;
        Gps = gps;
        Nfc = nfc;
    }

    public DataNetworksModel()
    {
    }

    public bool ThreeG { get; set; }
    public bool FourG { get; set; }
    public bool FiveG { get; set; }
    public string Wifi { get; set; }
    public string Bluetooth { get; set; }
    public bool Gps { get; set; }
    public bool Nfc { get; set; }
    
    public int SpecificationId { get; set; }
    public SpecificationsModel Specification { get; set; }

}