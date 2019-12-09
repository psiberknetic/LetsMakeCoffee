using System;
using System.Collections.Generic;

namespace LMC.Common.Interfaces
{
    public interface IMenuProvider
    {
        IEnumerable<MenuItem> GetMenuItems();
        IEnumerable<MenuItem> GetMenuItemsByCategory(MenuCategory category);
        MenuItem GetMenuItem(Guid id);
    }
}
