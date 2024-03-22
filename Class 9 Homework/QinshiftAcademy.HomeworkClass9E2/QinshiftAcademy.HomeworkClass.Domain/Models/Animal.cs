//Create a class Animal. Each Animal has name, color, age and Gender. Use enum for Gender.

using QinshiftAcademy.HomeworkClass.Domain.Enums;

namespace QinshiftAcademy.HomeworkClass.Domain.Models
{
    public class Animal
    {
        public string Name { get; set; }
        public string Color { get; set; }

        public int Age { get; set; }
        public AnimalGender Gender { get; set; }


        public Animal(string name, string color, int age, AnimalGender gender)
        {
            Name = name;
            Color = color;
            Age = age;

        }
    }
}
