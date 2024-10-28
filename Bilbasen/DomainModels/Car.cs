namespace DomainModels
{
    public class Car
    {
        public string? Brand { get; set; }
        public string? Model { get; set; }
        public int Year { get; set; }
        public string? Color { get; set; }
        public bool IsUsed { get; set; }
        public int MileageKm { get; set; }
        public string FuelType { get; set; }
        public int WeightKg { get; set; }
        public string CarType { get; set; }


        public Car(string? brand, string? model, int year, string? color,
            bool isUsed, int mileageKm, string? fuelType, int weightKg, string? carType)
        {
            Brand = brand;
            Model = model;
            Year = year;
            Color = color;
            IsUsed = isUsed;
            MileageKm = mileageKm;
            FuelType = fuelType;
            WeightKg = weightKg;
            CarType = carType;

        }
    }
}
