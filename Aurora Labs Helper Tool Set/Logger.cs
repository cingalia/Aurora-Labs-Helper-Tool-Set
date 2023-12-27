namespace Aurora_Labs_Helper_Tool_Set
{
    public class Logger
    {
        public void ConsoleLog(string className, string methodName, string errorMessage)
        {
            Console.WriteLine("Class name:" + className);
            Console.WriteLine("Method name:" + methodName);
            Console.WriteLine("Error:" + errorMessage);
        }
    }
}