using Bookshelf.App.Common;
using Bookshelf.Domain.Entity;
using System;
using System.Collections.Generic;

using System.Text;

namespace Bookshelf.App.Concrete
{
    public class MenuActionService : BaseService<MenuAction>
    {
        public MenuActionService()
        {
            Initialize();
        }
        public List<MenuAction> GetMenuActionByMenuName(string menuName)
        {
            List<MenuAction> result = new List<MenuAction>();
            foreach(var menuAction in Items)
            {
                if(menuAction.MenuName == menuName)
                {
                    result.Add(menuAction);
                }
            }
            return result;
        }
        private void Initialize()
        {
            AddItem(new MenuAction() { Id = 1, Name = "Add book", MenuName = "Main" });
            AddItem(new MenuAction() { Id = 2, Name = "Edit book", MenuName = "Main" });
            AddItem(new MenuAction() { Id = 3, Name = "Show books", MenuName = "Main" });
            AddItem(new MenuAction() { Id = 4, Name = "Delete book", MenuName = "Main" });

            AddItem(new MenuAction() { Id = 1, Name = "Edit genres", MenuName = "BookEdit" });
            AddItem(new MenuAction() { Id = 2, Name = "Edit status", MenuName = "BookEdit" });

            AddItem(new MenuAction() { Id = 1, Name = "Show all books", MenuName = "BookShow" });
            AddItem(new MenuAction() { Id = 2, Name = "Show books by author", MenuName = "BookShow" });
            AddItem(new MenuAction() { Id = 3, Name = "Show books by genre", MenuName = "BookShow" });
            AddItem(new MenuAction() { Id = 4, Name = "Show books by publishing house", MenuName = "BookShow" });
            AddItem(new MenuAction() { Id = 5, Name = "Show books by status", MenuName = "BookShow" });
        }
    }
}
