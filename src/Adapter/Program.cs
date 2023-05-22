//Loading cities from an external system for a travel agent application using Adpter Pattern

using ClassAdapter;

Console.Title = "Adapter";

// object adapter example
ICityAdapter adapter = new CityAdapter();
var city = adapter.GetCity();

Console.WriteLine($"{city.FullName}, {city.Inhabitants}");
Console.ReadKey();