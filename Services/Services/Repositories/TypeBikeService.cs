using DatabaseProvider;
using DatabaseProvider.Models;
using Services.Services.Interfaces;
using System.Collections.Generic;
using System.Linq;

namespace Services.Services.Repositories
{
    public class TypeBikeService : ITypeBikeService
    {
        private readonly BikeContext _context;

        public TypeBikeService(BikeContext context)
        {
            _context = context;
        }

        public bool CreateTypeBike(TypeBike typeBike)
        {
            if (typeBike == null) return false;

            _context.TypeBikes.Add(typeBike);

            return true;
        }

        public List<TypeBike> GetTypeBikes()
        {
            return _context.TypeBikes.ToList();
        }
    }
}
