namespace cellularSystem.Models;

public class CameraModel
{

    public int Id { get; set; }

    public CameraModel(string main, string front)
    {
        Main = main;
        Front = front;
    }

    public CameraModel()
    {

    }

    public string Main { get; set; }
    public string Front { get; set; }
    
    public int SpecificationId { get; set; }
    public SpecificationsModel Specification { get; set; }
}