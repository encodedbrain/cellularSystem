namespace cellularSystem.Models;

public class PlatformModel
{
    public PlatformModel(string processor, string operationalSystem)
    {
        Processor = processor;
        OperationalSystem = operationalSystem;
    }

    public PlatformModel()
    {
    }

    public int Id { get; set; }
    public string  Processor  { get; set; } 
    public string OperationalSystem { get; set; } 
    
    public int SpecificationId { get; set; }
    
    public SpecificationsModel Specification { get; set; }
}