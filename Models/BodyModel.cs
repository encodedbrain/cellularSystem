namespace cellularSystem.Models;

public class BodyModel
{
        public BodyModel(string dimensions, string weight, bool waterProtection)
        {
                Dimensions = dimensions;
                Weight = weight;
                WaterProtection = waterProtection;
        }

        public BodyModel()
        {

        }

        public int Id { get; set; }
        public string  Dimensions { get; set; } 
        public string Weight { get; set; } 
        public bool WaterProtection { get; set; }
        
        public int SpecificationId { get; set; }
        public SpecificationsModel Specification { get; set; }
}