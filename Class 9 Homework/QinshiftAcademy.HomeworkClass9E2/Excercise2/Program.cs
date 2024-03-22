//Create a class Animal. Each Animal has name, color, age and Gender. Use enum for Gender.

//Find the names of all the animals aged 5 or more Find all the names of the animals that start with 'A' Find all male, brown animals 
//Find the first animal whose name is longer than 10 characters

using QinshiftAcademy.HomeworkClass.Domain.Enums;
using QinshiftAcademy.HomeworkClass.Domain.Models;

Animal animal1 = new Animal("Dog", "Brown", 5, AnimalGender.Female);
Animal animal2 = new Animal("Cat", "White", 5, AnimalGender.Female);
Animal animal3 = new Animal("Cow", "Black", 5, AnimalGender.Male);
Animal animal4 = new Animal("Horse", "Brown", 5, AnimalGender.Female);
Animal animal5 = new Animal("Rabbit", "Gray", 5, AnimalGender.Male);
Animal animal6 = new Animal("Elephant", "Gray", 5, AnimalGender.Female);
Animal animal7 = new Animal("Lion", "Yellow", 5, AnimalGender.Male);
Animal animal8 = new Animal("Tiger", "Orange", 5, AnimalGender.Female);
Animal animal9 = new Animal("Zebra", "Black and White", 5, AnimalGender.Male);
Animal animal10 = new Animal("Giraffe", "Yellow and Brown", 5, AnimalGender.Female);
Animal animal11 = new Animal("Panda", "Black and White", 5, AnimalGender.Male);
Animal animal12 = new Animal("Kangaroo", "Brown", 5, AnimalGender.Male);
Animal animal13 = new Animal("Dolphin", "Gray", 5, AnimalGender.Female);
Animal animal14 = new Animal("Penguin", "Black and White", 5, AnimalGender.Male);
Animal animal15 = new Animal("Octopus", "Red", 5, AnimalGender.Female);
List<Animal> animals = new List<Animal>() { animal1, animal2, animal3, animal4, animal5, animal6, animal7, animal8, animal9, animal10, animal11, animal12, animal13, animal14, animal15 };

List<Animal> animalsAged5OrMore = animals.Where(a => a.Age >= 5).ToList();
Console.WriteLine("Animals aged 5 or more are the following");
foreach (Animal i in animalsAged5OrMore)
{
    Console.WriteLine(i.Name);
}

List<Animal> animalsNameStartsWithA = animals.Where(a => a.Name.StartsWith("A")).ToList();
Console.WriteLine("Animals that name starts with A are:");
foreach (Animal i in animalsNameStartsWithA)
{
    Console.WriteLine(i.Name);
}

List<Animal> animalsThatAreBrownAndMale = animals.Where(a => a.Color == "Brown").Where(a => a.Gender == AnimalGender.Male).ToList();
Console.WriteLine("Animals that are brown and Male:");
foreach (Animal i in animalsThatAreBrownAndMale)
{
    Console.WriteLine(i.Name);
}


Animal firstAnmilaWithNameLongerThan10Characters = animals.FirstOrDefault(a => a.Name.Length > 10);
if (firstAnmilaWithNameLongerThan10Characters != null)
{
    Console.WriteLine($"The name of the first Animal whose name is longer than 10 characters is {firstAnmilaWithNameLongerThan10Characters.Name}");
}
else
{
    Console.WriteLine("There is no animal with nale longer than 10 caracters");
}