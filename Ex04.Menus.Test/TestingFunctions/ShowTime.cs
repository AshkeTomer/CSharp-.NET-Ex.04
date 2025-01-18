using System;
using Ex04.Menus.Interfaces;

namespace Ex04.Menus.Test.TestingFunctions
{
    public class ShowTime : IDoActionListener
    {
        public void DoAction()
        {
            ShowTimeAction();
        }

        private void ShowTimeAction()
        {
            Console.WriteLine(DateTime.Now.ToLongTimeString());
        }
    }
}
