namespace cellularSystem.Models;

public class CellphoneModel
{
    public CellphoneModel(string model, string brand, int identity)
    {
        Model = model;
        Brand = brand;
        Identity = identity;
    }

    public CellphoneModel()
    {

    }


    public int Id { get; set; }
    public string Model {get;set;}
    public string Brand { get; set; } 
    public SpecificationsModel Specifications { get; set; }
    public int Identity { get; set; }
}