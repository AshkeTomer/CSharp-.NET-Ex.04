using System;

namespace Ex04.Menus.Events
{
    public class ActiveItem : MenuItem
    {
        public event Action DoAction;

        public ActiveItem(string i_Title, Menu i_PreviousMenu)
            : base(i_Title, i_PreviousMenu)
        {
        }

        public void AddDoActionListener(Action i_DoActionListener)
        {
            DoAction += i_DoActionListener;
        }

        public override void Show()
        {
            Console.Clear();
            DoAction?.Invoke();
            System.Threading.Thread.Sleep(2000);
            PreviousMenu.Show();
        }
    }
}