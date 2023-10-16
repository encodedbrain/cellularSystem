using cellularSystem.Data;
using cellularSystem.Schemas;

namespace cellularSystem.Services;

public class UpdateService
{
    public async Task<bool> Update(UpdateSchema prop)
    {
        using (var context = new CellphonesDb())
        {
            var cellphone = context.Cellphones.FirstOrDefault(
                cel => cel.Model == prop.Model &&
                       cel.Brand == prop.Brand
                       && cel.Identity ==  prop.Identity
                );

            if (cellphone is null) return false;


            switch (prop.Field)
            {
                case "brand":
                    cellphone.Brand = prop.Update;
                    break;
                case "model":
                    cellphone.Model = prop.Update;
                    break;
            }

            context.Cellphones.Update(cellphone);
            await context.SaveChangesAsync();
            return true;
        }
    }
}