using System;
using Ex04.Menus.Interfaces;

namespace Ex04.Menus.Test.TestingFunctions
{
    public class ShowTime : IDoActionListener
    {
        public void DoAction()
        {
            showTimeAction();
        }

        private void showTimeAction()
        {
            Console.WriteLine(DateTime.Now.ToLongTimeString());
        }
    }
}
