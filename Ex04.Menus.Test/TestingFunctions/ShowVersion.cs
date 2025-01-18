using System;
using Ex04.Menus.Interfaces;

namespace Ex04.Menus.Test.TestingFunctions
{
    public class ShowVersion : IDoActionListener
    {
        public void DoAction()
        {
            ShowVersionAction();
        }

        private void ShowVersionAction()
        {
            Console.WriteLine("App Version: 25.1.4.5480");
        }
    }
}
