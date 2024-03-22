//Create a list of ten numbers.
//Use LINQ to select in a list of the squares of all the numbers in the list from above.


List<double> numbersList = new List<double>();

numbersList.Add(5);
numbersList.Add(9);
numbersList.Add(11);
numbersList.Add(23);
numbersList.Add(5);
numbersList.Add(2);
numbersList.Add(44);
numbersList.Add(7);
numbersList.Add(44);
numbersList.Add(98);

foreach (double d in numbersList)
{
    Console.WriteLine(d);
}

List<double> squareResults = numbersList.Select(num => num * num).ToList();
Console.WriteLine("Squared Results:");
foreach (double d in squareResults)
{
    Console.WriteLine(d);
}