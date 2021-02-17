using DatabaseProvider.Models;
using System.Collections.Generic;

namespace Services.Services.Interfaces
{
    public interface IBikeService
    {
        public List<Bike> GetBikes();

        public bool CreateBike(Bike bike);

        public bool UpdateBike(Bike bike);

        public bool DeleteBike(int bikeId);
    }
}
