// See https://aka.ms/new-console-template for more information

using ObserverPattern;

public class Program
{
    public static void Main(String[] args)
    {
        Subject subject = new Subject();

        new HexaObserver(subject);
        new OctalObserver(subject);
        new BinaryObserver(subject);

        Console.WriteLine("First state change: 15");
        subject.Number = 15;
        Console.WriteLine("Second state change: 10");
        subject.Number = 10;
    }
}