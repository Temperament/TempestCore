using System;

namespace TempestCoreAuth
{
    class Program
    {
        static void Main()
        {
            AuthServer.Instance.Start();
            while (true)
            {
                var input = Console.ReadLine();
                if (input == "exit")
                    break;
            }
            AuthServer.Instance.Stop();
        }
    }
}
