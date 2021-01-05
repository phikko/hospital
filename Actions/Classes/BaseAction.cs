using Hospital.Actions.Interfaces;

namespace Hospital.Actions.Classes
{
    public class BaseAction : IAction
    {
        public virtual void Handle() {}
    }
}