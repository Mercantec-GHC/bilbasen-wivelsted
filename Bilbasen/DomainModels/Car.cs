public class Car : IVehicles
{
	private string? Brand { get; set; }
	private string? Model { get; set; }
	private int Year { get; set; }
	private string? Color { get; set; }
	private bool IsUsed { get; set; }
	private int MileageKm { get; set; }
	private string? FuelType { get; set; }
	private int WeightKg { get; set; }


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

	}
	public string? GetBrand() => Brand;
	public string? GetModel() => Model;
	public string? GetColor() => Color;
	public int GetWeightKg() => WeightKg;
	public int GetYear() => Year;
	public bool GetIsUsed() => IsUsed;
	public int GetMileage() => MileageKm;
	public string? GetFuelType() => FuelType;
}