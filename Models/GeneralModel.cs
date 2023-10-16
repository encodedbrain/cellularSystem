namespace cellularSystem.Models;

public class GeneralModel
{
    public int Id { get; set; }

    public GeneralModel(string releaseYear, decimal priceLaunch)
    {
        ReleaseYear = releaseYear;
        PriceLaunch = priceLaunch;
    }

    public GeneralModel()
    {
    }

    public string ReleaseYear { get; set; } 
    public decimal PriceLaunch { get; set; } 
    
    public int SpecificationId { get; set; }
    public SpecificationsModel Specification { get; set; }
}