using cellularSystem.Data;
using lodging.Services;
using Microsoft.EntityFrameworkCore;

namespace cellularSystem.Services;

public class Readservice
{
    public Task<object> Read()
    {
        using (var context = new CellphonesDb())
        {
            var cellphones = context.Cellphones.Select(cel => cel).Include(
                    cel => cel.Specifications).Include(
                    cel => cel.Specifications.Batery)
                .Include(
                    cel => cel.Specifications.Body)
                .Include(
                    cel => cel.Specifications.Camera)
                .Include(
                    cel => cel.Specifications.General).Include(
                    cel => cel.Specifications.Memoir)
                .Include(
                    cel => cel.Specifications.Other).Include(
                    cel => cel.Specifications.Platform)
                .Include(
                    cel => cel.Specifications.Screen)
                .Include(
                    cel => cel.Specifications.Sound)
                .Include(
                    cel => cel.Specifications.DataNetwork);


            var cell = cellphones.FirstOrDefault();

            var token = new TokenServices().GenerateToken(cell);


            foreach (var cel in cellphones)

                return Task.FromResult<object>(new
                {
                    cel, token
                });

            return null!;
        }
    }
}