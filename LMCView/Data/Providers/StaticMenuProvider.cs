using LMC.Common;
using LMC.Common.Interfaces;
using System;
using System.Collections.Generic;

namespace LMC.Web.Data.Providers
{
    public class StaticMenuProvider : IMenuProvider
    {


        public MenuItem GetMenuItem(Guid id)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<MenuItem> GetMenuItems()
        {
            throw new NotImplementedException();
        }

        public IEnumerable<MenuItem> GetMenuItemsByCategory(MenuCategory category)
        {
            throw new NotImplementedException();
        }
    }
}
