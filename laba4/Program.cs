using System.Text;
using System.Collections;

namespace laba4
{
    class Program
    {
        
        abstract class Bird
        {
            public string Name { get; set; }
            public int Age { get; set; }
            public bool IsFlyable { get; set; }
            public int weight { get; set; }
            public abstract void Move();
        }

        abstract class FlyableBird : Bird
        {
            public bool IsFlyable = true;
            public int MaxHeight { get; set; }
        }

        abstract class NonFlyableBird : Bird
        {
            public bool IsFlyable =false;
            public int MaxSpeed { get; set; }
        }




        class Eagle : FlyableBird
        {
            public Eagle(string name,int age, int maxHeght)
            {
                Name=name;
                Age=age;
                MaxHeight=maxHeght;
            }
            public override void Move()
            {
                Console.WriteLine($" {Name} віком {Age}р має таку висоту польоту {MaxHeight}");
            }

        }

        class Parrot : FlyableBird
        {
            public Parrot(string name, int age, int maxHeght)
            {
                Name = name;
                Age = age;
                MaxHeight = maxHeght;
            }
            public override void Move()
            {
                Console.WriteLine($" {Name} віком {Age}р має таку висоту польоту {MaxHeight}");
            }

        }

        class Ostrich : NonFlyableBird
        {
            public Ostrich(string name, int age, int maxSpeed)
            {
                Name = name;
                Age = age;
                MaxSpeed = maxSpeed;
            }
            public override void Move()
            {
                Console.WriteLine($" {Name} віком {Age}р може бігти зі швидкістю: {MaxSpeed}(км/год)");
            }

        }
        class Penguin : NonFlyableBird
        {
            public Penguin(string name, int age, int maxSpeed)
            {
                Age = age;
                MaxSpeed = maxSpeed;
            }
            public override void Move()
            {
                Console.WriteLine($" {Name} віком {Age}р може бігти зі швидкістю: {MaxSpeed}(км/год)");
            }

        }
        
        class Zoo
        {
            ArrayList Animals = new ArrayList();

            public Zoo()
            {
               
            }

            public void AddBird(Bird bird)
            {
                Animals.Add(bird);
            }

            public double GetAvarageWeight(Bird bird)
            {

                double sum=0;
                int count=0;
                foreach (Bird item in Animals)
                {
                    if(item.GetType().Name == bird.GetType().Name)
                    {
                        sum += item.Age;
                        count++;
                    }
                }
                return sum/count;
             
            }
        }
        static void Main(string[] args)
        {
            Console.OutputEncoding = UTF8Encoding.UTF8;

            Parrot parrot = new Parrot("Папуга", 1, 250);
            Parrot parrot1 = new Parrot("Папуга1", 2, 250);
            Parrot parrot2 = new Parrot("Папуга2", 6, 250);
            Parrot parrot3 = new Parrot("Папуга3", 8, 250);

            Eagle eagle = new Eagle("Орел",5, 400);
            Ostrich ostrich = new Ostrich("Страус", 10, 20);
            Penguin penguin = new Penguin("Пінгвін", 6, 15);
            
            Zoo zoo = new Zoo();

            zoo.AddBird(parrot);
            zoo.AddBird(parrot1);
            zoo.AddBird(eagle);
            zoo.AddBird(ostrich);
            zoo.AddBird(penguin);

            Console.WriteLine($"Середній вік {parrot1.GetType().Name}: {zoo.GetAvarageWeight(parrot1)}");
        }
    }
}

