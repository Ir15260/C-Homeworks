

namespace Excersise_1
{
    internal class Dog
    {
        public string Name { get; set; }
        public string Breed { get; set; }
        public string Color { get; set; }


        public Dog(string name, string breed, string color)
        {
            Name = name;
            Breed = breed;
            Color = color;
        }
        public string Eat()
        {
            return $"The Dog is now eating";
        }

        public string Play()
        {
            return $"The Dog is now Playing";
        }

        public string ChaseTail()
        {
            return $"Dog is now chasing its tail";
        }
    }
}

