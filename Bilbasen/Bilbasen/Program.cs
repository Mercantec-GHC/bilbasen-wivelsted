namespace Bilbasen
{
	internal class Program 
	{
		static void Main(string[] args)
		{
			GetCarsByFuelType();
			//GetAllBycicles();
			//GetListOfSameBrandCars();
			//GetListOfCarsWithMileage();
			//GetListOfCarsByColor();

			//int amountOfCars = GetAmountOfCars();
			//Console.WriteLine($"The amount of the cars, which are the same brand as the first car in a list: {amountOfCars}\n");
			//Console.WriteLine("------------------------------------------------------------\n");

			//GetListOfCarsByYearRange();
		}

		static List<Bicycle> GetAllBycicles()
		{ 
			BicycleCollection bicycles = new BicycleCollection();
			List<Bicycle> bicycleList = bicycles.GetBicycles();

			Console.WriteLine($"List of the bicycles: \n");

			for (int i = 0; i < bicycleList.Count; i++)
			{
				Bicycle bike = bicycleList[i];
				Console.WriteLine($"#{i + 1}: Brand: {bike.GetBrand()},\t Model: {bike.GetModel()},\t Color: {bike.GetColor()},\t " +
								  $"New: {(bike.GetIsUsed() ? "No" : "Yes")},\t Type: {bike.GetType()}");
			}

			return bicycleList;
		}

		static void GetListOfSameBrandCars()
		{
			CarCollection cars = new();
			List<Car> carList = cars.GetCars();

			Console.WriteLine("List of the cars, which are the same brand as the first car in a list: ");
			string firstCarBrand = carList[0].GetBrand();

			foreach (Car car in carList)
			{
				if (car.GetBrand() == firstCarBrand)
				{
					Console.WriteLine($"Brand: {car.GetBrand()},\t Model: {car.GetModel()}");
					//Console.WriteLine($"Brand: {car.GetBrand()},\t Model: {car.GetModel()},\t Color: {car.Color},\t Year: {car.Year},\t Is used: {car.IsUsed},\t Mileage: {car.GetMileage()},\t Fuel type: {car.FuelType},\t Body type: {car.CarType}");
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
				if (car.GetMileage() > 100000)
				{
					Console.WriteLine($"Brand: {car.GetBrand()},\t Model: {car.GetModel()},\t Year: {car.GetYear()},\t Mileage: {car.GetMileage()}");
					//Console.WriteLine($"Brand: {car.GetBrand()},\t Model: {car.GetModel()},\t Color: {car.Color},\t Year: {car.Year},\t Is used: {car.IsUsed},\t Mileage: {car.GetMileage()},\t Fuel type: {car.FuelType},\t Body type: {car.CarType}");
				}
			}
			Console.WriteLine("------------------------------------------------------------\n");
		}

		public static void GetCarsByFuelType()
		{
			CarCollection cars = new();
			List<Car> carList = cars.GetCars();


			Console.WriteLine("List of the cars using gas: ");
			foreach (Car car in carList)
			{
				if (car.GetFuelType() == "Gas")
				{
					Console.WriteLine($"Brand: {car.GetBrand()},\t Model: {car.GetModel()}");
					//Console.WriteLine($"Brand: {car.GetBrand()},\t Model: {car.GetModel()},\t Color: {car.Color},\t Year: {car.Year},\t Is used: {car.IsUsed},\t Mileage: {car.GetMileage()},\t Fuel type: {car.FuelType},\t Body type: {car.CarType}");
				}
			}
			Console.WriteLine();

			Console.WriteLine("List of the cars using diesel: ");
			foreach (Car car in carList)
			{
				if (car.GetFuelType() == "Diesel")
				{
					Console.WriteLine($"Brand: {car.GetBrand()},\t Model: {car.GetModel()}");
					//Console.WriteLine($"Brand: {car.GetBrand()},\t Model: {car.GetModel()},\t Color: {car.Color},\t Year: {car.Year},\t Is used: {car.IsUsed},\t Mileage: {car.GetMileage()},\t Fuel type: {car.FuelType},\t Body type: {car.CarType}");
				}
			}
			Console.WriteLine();
			Console.WriteLine("List of electric cars: ");
			foreach (Car car in carList)
			{ 
				if (car.GetFuelType() == "Electric")
				{
					Console.WriteLine($"Brand: {car.GetBrand()},\t Model: {car.GetModel()}");
					//Console.WriteLine($"Brand: {car.GetBrand()},\t Model: {car.GetModel()},\t Color: {car.Color},\t Year: {car.Year},\t Is used: {car.IsUsed},\t Mileage: {car.GetMileage()},\t Fuel type: {car.FuelType},\t Body type: {car.CarType}");
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
				if (car.GetColor() == "Red")
				{
					Console.WriteLine($"Brand: {car.GetBrand()},\t Model: {car.GetModel()},\t Color: {car.GetColor()}");
					//Console.WriteLine($"Brand: {car.GetBrand()},\t Model: {car.GetModel()},\t Color: {car.Color},\t Year: {car.Year},\t Is used: {car.IsUsed},\t Mileage: {car.GetMileage()},\t Fuel type: {car.FuelType},\t Body type: {car.CarType}");
				}
			}
			Console.WriteLine("------------------------------------------------------------\n");
		}

		static int GetAmountOfCars()
		{
			CarCollection cars = new();
			List<Car> carList = cars.GetCars();
			
			int count = 0;

			string firstCarBrand = carList[0].GetBrand();

			foreach (Car car in carList)
			{
				if (car.GetBrand().Equals(firstCarBrand)) 
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
				if (car.GetYear() >= 1980 && car.GetYear() <= 1999)
				{
					Console.WriteLine($"Brand: {car.GetBrand()},\t Model: {car.GetModel()},\t Year: {car.GetYear()}");
					//Console.WriteLine($"Brand: {car.GetBrand()},\t Model: {car.GetModel()},\t Color: {car.Color},\t Year: {car.Year},\t Is used: {car.IsUsed},\t Mileage: {car.GetMileage()},\t Fuel type: {car.FuelType},\t Body type: {car.CarType}");
				}
			}
			Console.WriteLine("------------------------------------------------------------\n");
		}
	}
}
