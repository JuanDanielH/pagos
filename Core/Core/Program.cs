using NLog;
using System;

namespace Core
{
    public class Program
    {
        public Logger Logger = LogManager.GetCurrentClassLogger();

        static void Main(string[] args)
        {
            Program p = new Program();
            p.Logger.Info("Core... Desde NLog");
        }
    }
}
