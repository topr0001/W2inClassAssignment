namespace W2InClassAssignment;

public class Program
{
    
    static void Main(string[] args)
    {
        Book book = new Book("Elden Ring", "Erencan Toprak", 1881);
        book.DisplayInfo();
        
        Student student = new Student();
        student.Name = "Steve";
        student.Grade = 98;

        Console.WriteLine($"{student.Name} is passing: {student.IsPassing()}");
        
        Engine engine = new Engine(680);
        Car car = new Car(engine, "Ferrari");
        car.Describe();
        
        Console.WriteLine("Counter:"+Vowels.CountVowels("Hello World"));
        Console.WriteLine("Counter:"+Vowels.CountVowels("Apples Are Awesome"));
      

    }
}