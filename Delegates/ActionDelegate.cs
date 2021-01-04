using System;

namespace Delegates
{
    /// <summary>
    /// Action Delegate:
    ///  Action is also a delegate type defined in the System namespace.
    ///  1. An Action type delegate is the same as Func delegate except that the 
    ///     Action delegate doesn't return a value.
    ///  2. In other words, an Action delegate can be used with a method that has a 
    ///     void return type.
    /// </summary>
    internal class ActionDelegate
    {
        public static void Save()
        {
            Action<string, Action> save = (title, actionMethod) =>
             {
                 try
                 {
                     actionMethod();
                     Console.WriteLine($"{title} Saved");
                 }
                 catch (Exception ex)
                 {
                     Console.WriteLine($"Error : {ex.Message}");
                 }
             };
            save("Details", SaveDetails);
            save("Accounts", () => SaveAccounts(3, 4));
        }
        public static void SaveDetails()
        {
            Console.WriteLine("details are saved");
            Console.ReadLine();
        }
        public static void SaveAccounts(int a, int b)
        {
            int sum = a + b;
            Console.WriteLine($"sum is : {sum}");
            Console.ReadLine();
        }
    }
}

