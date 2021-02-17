using DatabaseProvider;
using DatabaseProvider.Models;
using Microsoft.EntityFrameworkCore;
using Services.Services.Interfaces;
using System.Collections.Generic;
using System.Linq;

namespace Services.Services.Repositories
{
    public class BikeService : IBikeService
    {
        private readonly BikeContext _context;

        public BikeService(BikeContext context)
        {
            _context = context;
        }

        public bool CreateBike(Bike bike)
        {
            if (bike == null) return false;

            _context.Bikes.Add(bike);

            return true;
        }

        public bool DeleteBike(int bikeId)
        {
            var bike = _context.Bikes.FirstOrDefault(x => x.Id == bikeId);

            if (bike == null) return false;

            _context.Bikes.Remove(bike);

            return true;
        }

        public List<Bike> GetBikes()
        {
            return  _context.Bikes.Include(x => x.TypeBike).ToList();
        }

        public bool UpdateBike(Bike bike)
        {
            var oldBike = _context.Bikes.FirstOrDefault(x => x.Id == bike.Id);

            if (oldBike == null) return false;

            oldBike.IsRented = bike.IsRented;

            return true;
        }
    }
}
