public class Bicycle : IVehicles
{
	private string? Brand { get; set; }
	private string? Model { get; set; }
	private int Year { get; set; }
	private string? Color { get; set; }
	private bool IsUsed { get; set; }
	private string Type { get; set; }

	public Bicycle(string? brand, string? model, int year, string? color,
		bool isUsed, string? type)
	{
		Brand = brand;
		Model = model;
		Year = year;
		Color = color;
		IsUsed = isUsed;
		Type = type;

	}
	public string? GetBrand() => Brand;
	public string? GetModel() => Model;
	public string? GetColor() => Color;
	public int GetYear() => Year;
	public bool GetIsUsed() => IsUsed;
	public string? GetType() => Type;
}