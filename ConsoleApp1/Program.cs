public class dog
{
    public string Breed { get; set; }

    public dog(string breed)
    {
        Breed = breed;
    }

    public void Bark()
    {
        Console.WriteLine("bark bark, im a");
        Console.WriteLine(Breed);
    }
}
//test comment

class Program
{
    static void Main()
    {
        Console.WriteLine("Enter your dog breed");
        var breed = Console.ReadLine();

        var dog = new dog(breed);
        dog.Bark();
    }
}
