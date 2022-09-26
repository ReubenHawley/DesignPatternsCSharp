namespace ObserverPattern;

public class OctalObserver:IObserver
{
    private Subject _subject;

    public OctalObserver(Subject subject): base()
    {
        _subject = subject;
        subject.RegisterObserver(this);
    }
    
    public void Update(int numValue)
    {
        Console.WriteLine($"Octal String: {Convert.ToString(_subject.Number,8)}");
    }
}