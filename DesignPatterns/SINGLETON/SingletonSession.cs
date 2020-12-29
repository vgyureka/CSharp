using System;

namespace DesignPatterns.SINGLETON
{
    public sealed class SingletonSession
    {
        private SingletonSession()
        {
            Console.WriteLine($"Singleton instance is created in STATIC CONSTRUCTOR.");
        }
        private static SingletonSession _instance;

        public static SingletonSession Instance
        {
            get
            {
                return _instance ?? (_instance = new SingletonSession());
            }
        }

        public string Environment { get; set; }

        public string UserName
        {
            get
            {
                return System.Security.Principal.WindowsIdentity.GetCurrent().Name;
            }
        }

        public string MachineName
        {
            get
            {
                return System.Environment.MachineName;
            }
        }

        public bool Authenticated { get; set; }
    }
}
