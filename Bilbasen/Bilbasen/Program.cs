using DomainModels;
namespace Bilbasen
{
	internal class Program
	{
		static void Main(string[] args)
		{
			GetListOfSameBrandCars();
			GetListOfCarsWithMileage();
			GetListOfCarsByColor();

			int amountOfCars = GetAmountOfCars();
			Console.WriteLine($"The amount of the cars, which are the same brand as the first car in a list: {amountOfCars}\n");
			Console.WriteLine("------------------------------------------------------------\n");

			GetListOfCarsByYearRange();
		}

		static void GetListOfSameBrandCars()
		{
			CarCollection cars = new();
			List<Car> carList = cars.GetCars();

			Console.WriteLine("List of the cars, which are the same brand as the first car in a list: ");
			foreach (Car car in carList)
			{
				string firstCarBrand = carList[0].Brand;

				if (car.Brand == firstCarBrand)
				{
					Console.WriteLine($"Brand: {car.Brand},\t Model: {car.Model},\t Color: {car.Color},\t Year: {car.Year},\t Is used: {car.IsUsed},\t Mileage: {car.MileageKm},\t Fuel type: {car.FuelType},\t Body type: {car.CarType}");
				}
			}
			Console.WriteLine("------------------------------------------------------------\n");
		}

		static void GetListOfCarsWithMileage()
		{
			CarCollection cars = new();
			List<Car> carList = cars.GetCars();

			Console.WriteLine("List of the cars with the mileage above 150,000 km: ");
			foreach (Car car in carList)
			{
				if (car.MileageKm > 150000)
				{
					Console.WriteLine($"Brand: {car.Brand},\t Model: {car.Model},\t Color: {car.Color},\t Year: {car.Year},\t Is used: {car.IsUsed},\t Mileage: {car.MileageKm},\t Fuel type: {car.FuelType},\t Body type: {car.CarType}");
				}
			}
			Console.WriteLine("------------------------------------------------------------\n");
		}

		static void GetListOfCarsByColor()
		{
			CarCollection cars = new();
			List<Car> carList = cars.GetCars();

			Console.WriteLine("List of the cars with color red: ");
			foreach (Car car in carList)
			{
				if (car.Color == "Red")
				{
					Console.WriteLine($"Brand: {car.Brand},\t Model: {car.Model},\t Color: {car.Color},\t Year: {car.Year},\t Is used: {car.IsUsed},\t Mileage: {car.MileageKm},\t Fuel type: {car.FuelType},\t Body type: {car.CarType}");
				}
			}
			Console.WriteLine("------------------------------------------------------------\n");
		}

		static int GetAmountOfCars()
		{
			CarCollection cars = new();
			List<Car> carList = cars.GetCars();
			
			int count = 0;

			string firstCarBrand = carList[0].Brand;

			foreach (Car car in carList)
			{
				if (car.Brand.Equals(firstCarBrand)) 
				{
					count++;
				}
			}
			return count;
		}

		static void GetListOfCarsByYearRange()
		{
			CarCollection cars = new();
			List<Car> carList = cars.GetCars();

			Console.WriteLine("List of the cars, which were made between 1980 and 1999: ");
			foreach (Car car in carList)
			{
				if (car.Year >= 1980 && car.Year <= 1999)
				{
					Console.WriteLine($"Brand: {car.Brand},\t Model: {car.Model},\t Color: {car.Color},\t Year: {car.Year},\t Is used: {car.IsUsed},\t Mileage: {car.MileageKm},\t Fuel type: {car.FuelType},\t Body type: {car.CarType}");
				}
			}
			Console.WriteLine("------------------------------------------------------------\n");
		}
	}
}
