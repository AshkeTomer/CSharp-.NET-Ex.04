using System;
using Ex04.Menus.Interfaces;

namespace Ex04.Menus.Test.TestingFunctions
{
    public class ShowDate : IDoActionListener
    {
        public void DoAction()
        {
            ShowDateAction();
        }

        private void ShowDateAction()
        {
            Console.WriteLine(DateTime.Now.ToShortDateString());
        }
    }
}
