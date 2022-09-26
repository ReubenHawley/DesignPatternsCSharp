namespace ObserverPattern;

public class HexaObserver:IObserver
{
    private Subject _subject;

    public HexaObserver(Subject subject):base() 
    {
        _subject = subject;
        subject.RegisterObserver(this);
    }
    

    public void Update(int numValue)
    {
        Console.WriteLine($"Hexa String: {_subject.Number.ToString("X")}");
    }
}