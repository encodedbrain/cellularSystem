using cellularSystem.Data;
using cellularSystem.Schemas;

namespace cellularSystem.Services;

public class DeleteService
{
    public async Task<bool> Delete(DeleteSchema prop)
    {
        using (var context = new CellphonesDb())
        {
            var cellphone = context.Cellphones.FirstOrDefault(cel => cel.Model == prop.Model 
            && cel.Brand == prop.Brand && cel.Identity ==  prop.Identity);


            if (cellphone is null) return false;


            context.Cellphones.Remove(cellphone);
            await context.SaveChangesAsync();
            return true;
        }
    }
}