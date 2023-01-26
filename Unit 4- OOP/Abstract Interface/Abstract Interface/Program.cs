using Abstract_Interface;

//Animal a = new Animal(); Cannot create abstract instance
Cat c = new Cat("Yumi", 16, 20, true, "Multicolor");
c.Speak();
c.Move();
c.Eat();

Console.WriteLine(c.GetDetails());

Dog d = new Dog("Avis", 25, 20, "medium", true);
d.Speak();
d.Move();
d.Eat();

Console.WriteLine(d.GetDetails());

List<Animal> pets = new List<Animal>();
pets.Add(c);
pets.Add(d);
foreach (Animal a in pets)
{
    Console.WriteLine(a.Name);
}


Car bike = new Car("Bike", 20);
//bike.Turbo = new BasicTurbo();
bike.Turbo = new MaxTurbo();
bike.Drive();