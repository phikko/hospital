using System.Collections.Generic;

namespace Hospital.Menu.Interfaces
{
    public interface IMenu
    {
        List<IMenuItem> items { get; }
    }
}