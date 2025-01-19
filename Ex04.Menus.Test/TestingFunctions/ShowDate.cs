using System;
using Ex04.Menus.Interfaces;

namespace Ex04.Menus.Test.TestingFunctions
{
    public class ShowDate : IDoActionListener
    {
        public void DoAction()
        {
            showDateAction();
        }

        private void showDateAction()
        {
            Console.WriteLine(DateTime.Now.ToShortDateString());
        }
    }
}
