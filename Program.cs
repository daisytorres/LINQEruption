// See https://aka.ms/new-console-template for more information

List<Eruption> eruptions = new List<Eruption>()
{
    new Eruption("La Palma", 2021, "Canary Is", 2426, "Stratovolcano"),
    new Eruption("Villarrica", 1963, "Chile", 2847, "Stratovolcano"),
    new Eruption("Chaiten", 2008, "Chile", 1122, "Caldera"),
    new Eruption("Kilauea", 2018, "Hawaiian Is", 1122, "Shield Volcano"),
    new Eruption("Hekla", 1206, "Iceland", 1490, "Stratovolcano"),
    new Eruption("Taupo", 1910, "New Zealand", 760, "Caldera"),
    new Eruption("Lengai, Ol Doinyo", 1927, "Tanzania", 2962, "Stratovolcano"),
    new Eruption("Santorini", 46, "Greece", 367, "Shield Volcano"),
    new Eruption("Katla", 950, "Iceland", 1490, "Subglacial Volcano"),
    new Eruption("Aira", 766, "Japan", 1117, "Stratovolcano"),
    new Eruption("Ceboruco", 930, "Mexico", 2280, "Stratovolcano"),
    new Eruption("Etna", 1329, "Italy", 3320, "Stratovolcano"),
    new Eruption("Bardarbunga", 1477, "Iceland", 2000, "Stratovolcano")
};


// // Example Query - Prints all Stratovolcano eruptions
// IEnumerable<Eruption> stratovolcanoEruptions = eruptions.Where(c => c.Type == "Stratovolcano");
// PrintEach(stratovolcanoEruptions, "Stratovolcano eruptions.");
// // Execute Assignment Tasks here!

// // Helper method to print each item in a List or IEnumerable. This should remain at the bottom of your class!
// static void PrintEach(IEnumerable<Eruption> items, string msg = "")
// {
//     Console.WriteLine("\n" + msg);
//     foreach (Eruption item in items)
//     {
//         Console.WriteLine(item.ToString());
//     }
// }


//------------ NOTE FROM LECTURE ------------
// another way to write a foreach is as:
// eruptions.ForEach(Console.WriteLine);




//--------------------------------------- Assignment Questions: ------------------------------------------------

//Use LINQ to find the first eruption that is in Chile and print the result.
Eruption? firstChile = eruptions.FirstOrDefault(e => e.Location == "Chile");
Console.WriteLine(firstChile);



//Find the first eruption from the "Hawaiian Is" location and print it. If none is found, print "No Hawaiian Is Eruption found."
Eruption? firstHawaii = eruptions.FirstOrDefault(e => e.Location == "Hawaiian Is");
if (firstHawaii == null)
{
    Console.WriteLine("No eruptions in Hawaiian Is were found.");
}
else
{
    Console.WriteLine(firstHawaii);
}



//Find the first eruption from the "Greenland" location and print it. If none is found, print "No Greenland Eruption found.
Eruption? firstGreenland = eruptions.FirstOrDefault(e => e.Location == "Greenland");
if (firstGreenland == null)
{
    Console.WriteLine("No eruptions in Greenland were found.");
}
else
{
    Console.WriteLine(firstGreenland);
}



//Find the first eruption that is after the year 1900 AND in "New Zealand", then print it.
Eruption? first1900NewZealand = eruptions.FirstOrDefault(e => e.Year > 1900 && e.Location == "New Zealand");
Console.WriteLine(first1900NewZealand);



//Find all eruptions where the volcano's elevation is over 2000m and print them.
List<Eruption> over2000Elevation = eruptions.Where(e => e.ElevationInMeters > 2000).ToList();
over2000Elevation.ForEach(Console.WriteLine);



//Find all eruptions where the volcano's name starts with "L" and print them. Also print the number of eruptions found.
List<Eruption> startsWithL = eruptions.Where(e => e.Volcano.StartsWith("L")).ToList();
startsWithL.ForEach(Console.WriteLine);



//Find the highest elevation, and print only that integer (Hint: Look up how to use LINQ to find the max!)
int highestElevation = eruptions.Max(e => e.ElevationInMeters);
Console.WriteLine(highestElevation);



//Use the highest elevation variable to find and print the name of the Volcano with that elevation.
List<string> highestElevationName = eruptions.Where(e => e.ElevationInMeters == highestElevation).Select(e => e.Volcano).ToList();
highestElevationName.ForEach(Console.WriteLine);



//Print all Volcano names alphabetically.
List<Eruption> alphaOrder = eruptions.OrderBy(e => e.Volcano).ToList();
alphaOrder.ForEach(Console.WriteLine);



//Print the sum of all the elevations of the volcanoes combined.
int elevationSum = eruptions.Sum(e => e.ElevationInMeters);
Console.WriteLine(elevationSum);



//Print whether any volcanoes erupted in the year 2000 (Hint: look up the Any query)
bool y2k = eruptions.Any(e => e.Year == 2000);
Console.WriteLine(y2k);



//Find all stratovolcanoes and print just the first three (Hint: look up Take)
List<Eruption> stratoVolcanoes = eruptions.Where(e => e.Type == "Stratovolcano").Take(3).ToList();
stratoVolcanoes.ForEach(Console.WriteLine);



//Print all the eruptions that happened before the year 1000 CE alphabetically according to Volcano name.
List<Eruption> before1000 = eruptions.Where(e => e.Year < 1000).OrderBy(e => e.Volcano).ToList();
before1000.ForEach(Console.WriteLine);



//Redo the last query, but this time use LINQ to only select the volcano's name so that only the names are printed.
List<string> before1000Name = eruptions.Where(e => e.Year < 1000).OrderBy(e => e.Volcano).Select(e => e.Volcano).ToList();
before1000Name.ForEach(Console.WriteLine);