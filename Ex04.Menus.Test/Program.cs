namespace Ex04.Menus.Test
{
    public class Program
    {
        public static void Main()
        {
            TestInterface testInterface = new TestInterface();
            testInterface.StartMenu();

            TestEvent testEvent = new TestEvent();
            testEvent.StartMenu();
        }
    }
}