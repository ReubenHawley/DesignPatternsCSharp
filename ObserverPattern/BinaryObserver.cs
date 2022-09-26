namespace ObserverPattern;

public class BinaryObserver:IObserver
{
    private Subject _subject;
    public BinaryObserver(Subject subject):base()
    {
        _subject = subject;
        subject.RegisterObserver(this);
    }
    
    public void Update(int numValue)
    {
        Console.WriteLine($"Binary String: {Convert.ToString(_subject.Number,2)}");
    }
}