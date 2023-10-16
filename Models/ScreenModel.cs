namespace cellularSystem.Models;

public class ScreenModel
{
    public ScreenModel(string type, int size, int resolution, string frequency, string desinty, string protection, string extras)
    {
        Type = type;
        Size = size;
        Resolution = resolution;
        Frequency = frequency;
        Desinty = desinty;
        Protection = protection;
        Extras = extras;
    }

    public ScreenModel()
    {
    }

    public int Id { get; set; }
    public string Type { get; set; }
    public int Size { get; set; }
    public int Resolution { get; set; }
    public string Frequency { get; set; }
    public string Desinty { get; set; }
    public string Protection { get; set; }
    public string Extras { get; set; }
    
    public int SpecificationId { get; set; }
    
    public SpecificationsModel Specification { get; set; }


}