using System.Text;

namespace laba4
{
    class Program
    {
        
        abstract class Bird
        {
            public string Name { get; set; }
            public int Age { get; set; }
            public bool IsFlyable { get; set; }

            public abstract void Move();
        }

        class Eagle : Bird
        {
            public int MaxHeight;
            public Eagle(string name,int age, bool isFlyable, int maxHeght)
            {
                Name=name;
                Age=age;
                IsFlyable=isFlyable;
                MaxHeight=maxHeght;
            }
            public override void Move()
            {
                Console.WriteLine($" {Name} віком {Age}р має таку висоту польоту {MaxHeight}");
            }

        }

        class Parrot : Bird
        {
            public int MaxHeight;
            public Parrot(string name, int age, bool isFlyable, int maxHeght)
            {
                Name = name;
                Age = age;
                IsFlyable = isFlyable;
                MaxHeight = maxHeght;
            }
            public override void Move()
            {
                Console.WriteLine($" {Name} віком {Age}р має таку висоту польоту {MaxHeight}");
            }

        }

        class NonFlyableBird : Bird
        {
            public int MaxSpeed;
            public NonFlyableBird(string name, int age, bool isFlyable, int maxSpeed)
            {
                Name = name;
                Age = age;
                IsFlyable = isFlyable;
                MaxSpeed = maxSpeed;
            }
            public override void Move()
            {
                Console.WriteLine($" {Name} віком {Age}р може бігти зі швидкістю: {MaxSpeed}(км/год)");
            }

        }
        class Ostrich : Bird
        {
            public int MaxSpeed;
            public Ostrich(string name, int age, bool isFlyable, int maxSpeed)
            {
                Name = name;
                Age = age;
                IsFlyable = isFlyable;
                MaxSpeed = maxSpeed;
            }
            public override void Move()
            {
                Console.WriteLine($" {Name} віком {Age}р може бігти зі швидкістю: {MaxSpeed}(км/год)");
            }

        }
        class Penguin : Bird
        {
            public int MaxSpeed;
            public Penguin(string name, int age, bool isFlyable, int maxSpeed)
            {
                Name = name;
                Age = age;
                IsFlyable = isFlyable;
                MaxSpeed = maxSpeed;
            }
            public override void Move()
            {
                Console.WriteLine($" {Name} віком {Age}р може бігти зі швидкістю: {MaxSpeed}(км/год)");
            }

        }
        static void Main(string[] args)
        {
            Console.OutputEncoding = UTF8Encoding.UTF8;

            Parrot parrot = new Parrot("Папуга", 1, true, 250);
            Eagle eagle = new Eagle("Орел",5, true, 400);
            NonFlyableBird chik = new NonFlyableBird("Птах", 3, false, 45);
            Ostrich ostrich = new Ostrich("Страус", 10, false, 20);
            Penguin penguin = new Penguin("Пінгвін", 6, false, 15);
            
            Bird[] birds = {parrot, eagle, chik, ostrich, penguin};
            foreach(Bird bird in birds)
            {
                bird.Move();
            }
        }
    }
}

