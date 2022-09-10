using System;
namespace ToDoUygulamasi
{
    class Program
    {
        public static void Main(string[] args)
        {
            int selection = 1;
            Menus menu = new Menus();
            while (selection > 0)
            {
                selection = menu.MakeMainMenu();
                selection = menu.MakeSubMenus(selection);
            }
        }
    }
}