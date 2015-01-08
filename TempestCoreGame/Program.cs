﻿using System;

namespace TempestCoreGame
{
    class Program
    {
        static void Main()
        {
            GameServer.Instance.Start();
            while (true)
            {
                var input = Console.ReadLine();
                if (input == "exit")
                    break;
            }
            GameServer.Instance.Stop();
        }
    }
}
