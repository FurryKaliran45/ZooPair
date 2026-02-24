public class Animal
{
    private string _name;
    private int _age;
    public string Name = _name;
    public int Age = _age;
    private string _favoriteFood;
    public Animal(string name, int age, string favouriteFood)
    {
        _name = name;
        _age = age;
        _favoriteFood = favouriteFood;
    }
    public virtual void MakeSound()
    {
        Console.WriteLine("Животное издает звук");
    }
    void favoriteFood();
}