using System;

namespace ChatServer
{
    class Program
    {
        static void Main()
        {
            ChatServer.Instance.Start();
            while (true)
            {
                var input = Console.ReadLine();
                if (input == "exit")
                    break;
            }
            ChatServer.Instance.Stop();
        }
    }
}
