class Animal
{
    public virtual void Live()
    {
        Console.WriteLine("животное живет");

    }
  
}
class HerbivoreAnimal:Animal
{    
    public override void Live()
    
    {
        HerbivoreAnimal herb = new HerbivoreAnimal();
        herb.EatGrass();
    }
    public void EatGrass()
    {
        Console.WriteLine("животное ест траву");
    }
}
class Rabbit : HerbivoreAnimal
{
    Animal animal= new Animal();
    HerbivoreAnimal herb = new HerbivoreAnimal();
    Zoo zoo = new Zoo();
    public void Rab()
    {
        Rabbit rabbit = new Rabbit();
        animal.Live();
        Console.WriteLine("это кролик ");
        herb.Live();
        zoo.Add(rabbit);
        Console.WriteLine("");
    }

}
class Dear : HerbivoreAnimal
{
    Animal animal = new Animal();
    HerbivoreAnimal herb = new HerbivoreAnimal();
    Zoo zoo = new Zoo();
    public void Dea()
    {
        Dear dear = new Dear();
        animal.Live();
        Console.WriteLine("это лось ");
        herb.Live();
        zoo.Add(dear);
        Console.WriteLine("");
    }
}
class Predator:Animal
{
    public override void Live()

    {
        Predator predator = new Predator();
        predator.Bite();
    }
    public void Bite()
    {
        Console.WriteLine("животное охотится");
    }
}

class Wolf :Predator
{
    Animal animal = new Animal();
    Predator predator = new Predator();
    Zoo zoo = new Zoo();
    public void Wol()
    {
        Wolf wolf = new Wolf();
        animal.Live();
        Console.WriteLine("это волк");
        predator.Live();
        zoo.Add(wolf);
        Console.WriteLine("");
    }
}
class Bear : Predator
{
    Animal animal = new Animal();
    Predator predator = new Predator();
    Zoo zoo = new Zoo();
    public void Bea()
    {
        Bear bear = new Bear();
        animal.Live();
        Console.WriteLine("это медведь");
        predator.Live();
        zoo.Add(bear);
        Console.WriteLine("");
    }
}
class Zoo
{
    internal void Add(Animal animal)
    {
        Type type = animal.GetType();
        if (type.BaseType == typeof(Predator))
        {
            // Console.WriteLine(type.BaseType.ToString());
            Console.WriteLine("это животное помещено в загон хищников");
        }
        if (type.BaseType == typeof(HerbivoreAnimal))
        {
            //Console.WriteLine(type.BaseType.ToString());
            Console.WriteLine("это животное помещено в загон травоядных");
        }
    }

}
internal class Program
{
    private static void Main(string[] args)
    {
        Rabbit rabbit = new Rabbit();
        Dear dear = new Dear();
        Wolf wolf = new Wolf();
        Bear bear = new Bear();

        rabbit.Rab();
        dear.Dea();
        wolf.Wol();
        bear.Bea();

      
    }
}