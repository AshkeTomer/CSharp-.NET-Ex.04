namespace Ex04.Menus.Events
{
    public abstract class MenuItem
    {
        private readonly Menu r_PreviousMenu;
        private string m_Title;

        public MenuItem(string i_Title, Menu i_PreviousMenu)
        {
            m_Title = i_Title;
            r_PreviousMenu = i_PreviousMenu;
        }

        public string Title
        {
            get { return m_Title; }
            set { m_Title = value; }
        }

        public Menu PreviousMenu
        {
            get { return r_PreviousMenu; }
        }

        public abstract void Show();
    }
}