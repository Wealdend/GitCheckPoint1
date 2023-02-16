namespace GitCheckPoint1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("This is the Git checkpoint task 1.1");
            CheckTest.testMessage("\nTask 2 checked");

            int num1 = 10;
            int num2 = 20;
            int result = Calculate.Add(num1, num2);
            Console.WriteLine("\nThe result of adding " + num1 + " and " + num2 + " is " + result);
        }
    }
}