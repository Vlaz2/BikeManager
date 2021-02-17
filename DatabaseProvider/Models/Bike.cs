namespace DatabaseProvider.Models
{
    public class Bike
    {

        public int Id { get; set; }

        public string Title { get; set; }

        public int TypeBikeId { get; set; }

        public TypeBike TypeBike { get; set; }

        public double Price { get; set; }

        public bool IsRented { get; set; }
    }
}
