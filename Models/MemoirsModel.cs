namespace cellularSystem.Models;

public class MemoirsModel
{
    public MemoirsModel(int internalStorage, int ramMemory)
    {
        InternalStorage = internalStorage;
        RamMemory = ramMemory;
    }

    public MemoirsModel()
    {
    }

    public int Id { get; set; }
    public int InternalStorage { get; set; }
    public int RamMemory { get; set; }
    
    public int SpecificationId { get; set; }
    public SpecificationsModel Specification { get; set; }
}