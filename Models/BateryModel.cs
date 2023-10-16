namespace cellularSystem.Models;

public class BateryModel
{
    public BateryModel(string batery, string charger)
    {
        Batery = batery;
        Charger = charger;
    }

    public BateryModel()
    {

    }

    public int Id { get; set; }
    public string Batery { get; set; }
    public string Charger { get; set; }
    
    public int SpecificationId { get; set; }
    public SpecificationsModel Specification { get; set; }
}