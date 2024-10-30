public class BicycleCollection
{
	private readonly List<Bicycle> _bicycles = new List<Bicycle>
		{
			new Bicycle("Trek", "Domane SL 7", 2023, "Red", false, "Road"),
			new Bicycle("Specialized", "Stumpjumper EVO", 2022, "Blue", true, "Mountain"),
			new Bicycle("Cannondale", "Quick CX 3", 2021, "Green", false, "Hybrid"),
			new Bicycle("Giant", "Escape 3", 2020, "Black", true, "City"),
			new Bicycle("Bianchi", "Infinito CV", 2019, "White", false, "Road"),
			new Bicycle("Salsa", "Mukluk", 2021, "Orange", true, "Fat Bike"),
			new Bicycle("Raleigh", "Cadent 2", 2020, "Grey", false, "Urban"),
			new Bicycle("Fuji", "Nevada 29", 2022, "Yellow", true, "Mountain"),
			new Bicycle("Schwinn", "Searcher", 2018, "Red", false, "Touring"),
			new Bicycle("Surly", "Troll", 2019, "Black", true, "Adventure")
		};

	public List<Bicycle> GetBicycles() => _bicycles;
}