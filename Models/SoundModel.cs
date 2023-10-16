namespace cellularSystem.Models;

public class SoundModel
{
    public SoundModel(string sound)
    {
        Sound = sound;
    }

    public SoundModel()
    {
    }

    public int Id { get; set; }
    public string Sound { get; set; }
    public int SpecificationId { get; set; }
    public SpecificationsModel Specification { get; set; }
}