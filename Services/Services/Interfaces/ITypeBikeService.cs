using DatabaseProvider.Models;
using System.Collections.Generic;

namespace Services.Services.Interfaces
{
    public interface ITypeBikeService
    {
        bool CreateTypeBike(TypeBike typeBike);

        List<TypeBike> GetTypeBikes();
    }
}
