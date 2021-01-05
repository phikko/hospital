namespace Hospital.Menu.Interfaces
{
    public interface IMenuItem
    {
        string label { get; }
        
        void Handle() {}
    }
}