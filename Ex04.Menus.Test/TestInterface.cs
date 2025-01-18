using Ex04.Menus.Test.TestingFunctions;
using Ex04.Menus.Interfaces;

namespace Ex04.Menus.Test
{
    public class TestInterface
    {
        private readonly MainMenu r_MainMenu;

        public TestInterface()
        {
            r_MainMenu = new MainMenu("** INTERFACE main menu **\n");
            BuildMenu();
        }

        public void BuildMenu()
        {

            SubMenu subMenu = new SubMenu("Letters and Version", r_MainMenu);

            ActiveItem activeItem = new ActiveItem("Show Version", subMenu);
            activeItem.AddDoActionListener(new ShowVersion() as IDoActionListener);
            subMenu.AddMenuItem(activeItem);

            activeItem = new ActiveItem("Count Lowecase Letters", subMenu);
            activeItem.AddDoActionListener(new CountLetters() as IDoActionListener);
            subMenu.AddMenuItem(activeItem);

            r_MainMenu.AddMenuItem(subMenu);

            subMenu = new SubMenu("Show Current Date / Time", r_MainMenu);

            activeItem = new ActiveItem("Show Current Time", subMenu);
            activeItem.AddDoActionListener(new ShowTime() as IDoActionListener);
            subMenu.AddMenuItem(activeItem);

            activeItem = new ActiveItem("Show Current Date", subMenu);
            activeItem.AddDoActionListener(new ShowDate() as IDoActionListener);
            subMenu.AddMenuItem(activeItem);

            r_MainMenu.AddMenuItem(subMenu);
        }

        public void StartMenu()
        {
            r_MainMenu.Show();
        }
    }
}