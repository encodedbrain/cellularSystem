namespace cellularSystem.Models;

public class OthersModel
{
    public OthersModel(bool infraRed, string usb, string sensors)
    {
        InfraRed = infraRed;
        Usb = usb;
        Sensors = sensors;
    }

    public OthersModel()
    {
    }

    public int Id { get; set; }
    public bool InfraRed { get; set; }
    public string Usb { get; set; }
    public string Sensors { get; set; }
    
    public int SpecificationId { get; set; }
    public SpecificationsModel Specification { get; set; }
}