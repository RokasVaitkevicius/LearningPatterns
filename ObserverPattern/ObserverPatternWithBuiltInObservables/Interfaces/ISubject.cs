namespace ObserverPatternWithBuiltInObservables.Interfaces
{
    public interface ISubject
    {
        void RegisterObserver(IObserver o);
        void RemoveObsever(IObserver o);
        void NotifyObserver();
    }
}