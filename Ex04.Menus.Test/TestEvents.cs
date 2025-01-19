using Ex04.Menus.Test.TestingFunctions;
using Ex04.Menus.Events;

namespace Ex04.Menus.Test
{
    public class TestEvent
    {
        private readonly MainMenu r_MainMenu;

        public TestEvent()
        {
            r_MainMenu = new MainMenu("** EVENTS main menu **\n");
            BuildMenu();
        }

        public void BuildMenu()
        {
            buildVersionDigitsSubMenu();
            buildDateTimeSubMenu();
        }

        private void buildVersionDigitsSubMenu()
        {
            SubMenu versionDigitsSubMenu = new SubMenu("Letters and Version", r_MainMenu);

            ActiveItem showVersionItem = new ActiveItem("Show Version", versionDigitsSubMenu);
            showVersionItem.DoAction += new ShowVersion().DoAction;
            versionDigitsSubMenu.AddMenuItem(showVersionItem);

            ActiveItem countLettersItem = new ActiveItem("Count Lowecase Letters", versionDigitsSubMenu);
            countLettersItem.DoAction += new CountLetters().DoAction;
            versionDigitsSubMenu.AddMenuItem(countLettersItem);

            r_MainMenu.AddMenuItem(versionDigitsSubMenu);
        }

        private void buildDateTimeSubMenu()
        {
            SubMenu dateTimeSubMenu = new SubMenu("Show Current Date / Time", r_MainMenu);

            ActiveItem showTimeItem = new ActiveItem("Show Current Time", dateTimeSubMenu);
            showTimeItem.DoAction += new ShowTime().DoAction;
            dateTimeSubMenu.AddMenuItem(showTimeItem);

            ActiveItem showDateItem = new ActiveItem("Show Current Date", dateTimeSubMenu);
            showDateItem.DoAction += new ShowDate().DoAction;
            dateTimeSubMenu.AddMenuItem(showDateItem);

            r_MainMenu.AddMenuItem(dateTimeSubMenu);
        }

        public void StartMenu()
        {
            r_MainMenu.Show();
        }
    }
}
