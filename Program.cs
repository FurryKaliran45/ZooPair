{
    static void Main()
    {
        Console.WriteLine("Добро пожаловать в зоопарк!");

        Zoo zoo = new Zoo();
        zoo.AddAnimal(new Mammal("Лев", 5, "мясо"));
        zoo.AddAnimal(new Bird("Орел", 3, "зёрнышки"));
        zoo.ShowAll();
    }
}