namespace cellularSystem.Models;

public class SpecificationsModel
{
    public SpecificationsModel()
    {
    }

    public int Id { get; set; }
    public GeneralModel General { get; set; }
    public BodyModel Body { get; set; }
    public PlatformModel Platform { get; set; }
    public MemoirsModel Memoir { get; set; }
    public ScreenModel Screen { get; set; }
    public CameraModel Camera { get; set; }
    public BateryModel Batery { get; set; }
    public DataNetworksModel DataNetwork { get; set; }
    public SoundModel Sound { get; set; }
    public OthersModel Other { get; set; }
    public int CellphoneId { get; set; }
    public CellphoneModel Cellphone { get; set; }
}