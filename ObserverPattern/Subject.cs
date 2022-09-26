namespace ObserverPattern;

public class Subject:ISubject
{
    private List<IObserver> observers = new List<IObserver>();
    private int number;

    public Subject()
    {
    }

    public int Number
    {
        get
        {
            return number;
        }
        set
        {
            number = value;
            NotifyObservers();
        }
    }

    public void RegisterObserver(IObserver observer)
    {
        observers.Add(observer);
    }

    public void RemoveObserver(IObserver observer)
    {
        observers.Remove(observer);
    }

    public void NotifyObservers()
    {
        foreach (var observer in observers)
        {
            observer.Update(Number);
        }
    }
}