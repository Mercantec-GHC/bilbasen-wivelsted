using DomainModels;

namespace Bilbasen
{
	public class CarCollection
	{
		List<Car> _cars = new List<Car>
		{
			new Car("Toyota", "Corolla", 2020, "White", true, 45_000, "Gas", 1320, "Sedan"),
			new Car("Tesla", "Model S", 2023, "Black", false, 0, "Electric", 1961, "Sedan"),
			new Car("Ford", "Bronco", 1989, "Blue", true, 180_000, "Gas", 2500, "SUV"),
			new Car("BMW", "X5", 2019, "Silver", true, 75_000, "Diesel", 2205, "SUV"),
			new Car("Honda", "Civic", 2017, "Red", true, 105_000, "Gas", 1240, "Hatchback"),
			new Car("Chevrolet", "Impala", 1967, "Black", true, 200_000, "Gas", 1700, "Sedan"),
			new Car("Ford", "F-150", 2018, "Red", true, 85_000, "Gas", 2600, "Pickup"),
			new Car("Nissan", "Altima", 2021, "Blue", false, 10_000, "Gas", 1440, "Sedan"),
			new Car("Toyota", "Camry", 2016, "Gray", true, 120_000, "Gas", 1460, "Sedan"),
			new Car("Mercedes-Benz", "C-Class", 2022, "White", false, 5_000, "Gas", 1655, "Sedan"),
			new Car("Honda", "Accord", 2015, "Silver", true, 130_000, "Gas", 1500, "Sedan"),
			new Car("Audi", "A4", 2020, "Black", true, 20_000, "Gas", 1465, "Sedan"),
			new Car("Jeep", "Wrangler", 2021, "Green", false, 8_000, "Gas", 2015, "SUV"),
			new Car("BMW", "3 Series", 2019, "White", true, 40_000, "Diesel", 1540, "Sedan"),
			new Car("Volvo", "XC90", 2017, "Gray", true, 95_000, "Gas", 2100, "SUV"),
			new Car("Kia", "Sportage", 2020, "Blue", true, 25_000, "Gas", 1590, "SUV"),
			new Car("Hyundai", "Elantra", 2018, "Red", true, 60_000, "Gas", 1250, "Sedan"),
			new Car("Ford", "Explorer", 2016, "Blue", true, 110_000, "Gas", 2045, "SUV"),
			new Car("Chevrolet", "Tahoe", 2021, "Black", false, 15_000, "Gas", 2450, "SUV"),
			new Car("Dodge", "Charger", 2022, "Gray", false, 2_000, "Gas", 1960, "Sedan"),
			new Car("Lexus", "RX 350", 2017, "White", true, 70_000, "Gas", 1890, "SUV"),
			new Car("Porsche", "911", 2019, "Silver", false, 12_000, "Gas", 1420, "Sport"),
			new Car("Volkswagen", "Golf", 2020, "Blue", true, 45_000, "Gas", 1355, "Hatchback"),
			new Car("Nissan", "Rogue", 2023, "Gray", false, 5_000, "Gas", 1680, "SUV"),
			new Car("Mazda", "CX-5", 2021, "Red", true, 30_000, "Gas", 1640, "SUV"),
			new Car("Subaru", "Outback", 2018, "Green", true, 80_000, "Gas", 1625, "Wagon"),
			new Car("Chevrolet", "Blazer", 2021, "Red", false, 10_000, "Gas", 1850, "SUV"),
			new Car("Tesla", "Model 3", 2019, "White", true, 50_000, "Electric", 1600, "Sedan"),
			new Car("GMC", "Yukon", 2022, "Black", false, 7_000, "Gas", 2570, "SUV"),
			new Car("Ford", "Mustang", 2021, "Blue", false, 5_000, "Gas", 1720, "Sport"),
			new Car("Kia", "Optima", 2017, "White", true, 95_000, "Gas", 1440, "Sedan"),
			new Car("Honda", "Pilot", 2019, "Silver", true, 70_000, "Gas", 1960, "SUV"),
			new Car("BMW", "X3", 2020, "Black", true, 30_000, "Diesel", 1810, "SUV"),
			new Car("Toyota", "Highlander", 2022, "Blue", false, 4_000, "Gas", 1925, "SUV"),
			new Car("Audi", "Q5", 2018, "Gray", true, 65_000, "Gas", 1800, "SUV"),
			new Car("Dodge", "Ram 1500", 2021, "White", false, 3_000, "Diesel", 2600, "Pickup"),
			new Car("Jeep", "Grand Cherokee", 2017, "Black", true, 90_000, "Gas", 1985, "SUV"),
			new Car("Ford", "Fusion", 2015, "Silver", true, 110_000, "Gas", 1450, "Sedan"),
			new Car("Toyota", "Tacoma", 2018, "Gray", true, 80_000, "Gas", 2050, "Pickup"),
			new Car("Nissan", "Pathfinder", 2019, "Blue", true, 60_000, "Gas", 1900, "SUV"),
			new Car("Mercedes-Benz", "GLS", 2023, "White", false, 2_000, "Gas", 2450, "SUV"),
			new Car("Ford", "Escape", 2020, "Red", true, 25_000, "Gas", 1615, "SUV"),
			new Car("Toyota", "Land Cruiser", 2021, "Black", false, 10_000, "Gas", 2725, "SUV"),
			new Car("Hyundai", "Santa Fe", 2019, "Gray", true, 50_000, "Gas", 1680, "SUV"),
			new Car("Volvo", "XC60", 2020, "Blue", true, 30_000, "Gas", 1840, "SUV"),
			new Car("Cadillac", "Escalade", 2022, "Black", false, 5_000, "Gas", 2750, "SUV"),
			new Car("Kia", "Soul", 2018, "Green", true, 70_000, "Gas", 1300, "Hatchback"),
			new Car("BMW", "X7", 2019, "Black", true, 55_000, "Diesel", 2460, "SUV"),
			new Car("Ford", "Edge", 2016, "White", true, 90_000, "Gas", 1780, "SUV"),
			new Car("Honda", "CR-V", 2017, "Blue", true, 100_000, "Gas", 1590, "SUV"),
			new Car("Toyota", "4Runner", 2018, "Red", true, 85_000, "Gas", 2045, "SUV"),
			new Car("Chevrolet", "Silverado", 2019, "Silver", true, 60_000, "Gas", 2620, "Pickup"),
			new Car("Hyundai", "Tucson", 2020, "Blue", true, 35_000, "Gas", 1585, "SUV"),
			new Car("Nissan", "Leaf", 2021, "White", false, 15_000, "Electric", 1580, "Hatchback"),
			new Car("Porsche", "Cayenne", 2022, "Black", false, 3_000, "Gas", 2185, "SUV"),
			new Car("Tesla", "Model X", 2020, "Blue", true, 40_000, "Electric", 2480, "SUV"),
			new Car("Subaru", "Forester", 2019, "Green", true, 50_000, "Gas", 1600, "SUV"),
			new Car("Kia", "Sorento", 2022, "Gray", false, 6_000, "Gas", 1775, "SUV"),
			new Car("Toyota", "Prius", 2020, "Silver", true, 45_000, "Hybrid", 1450, "Hatchback"),
			new Car("Mazda", "Mazda3", 2017, "Red", true, 90_000, "Gas", 1320, "Sedan")
		};

		public List<Car> GetCars()
		{ return _cars; }
	}
}
