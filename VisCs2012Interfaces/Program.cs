using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VisCs2012Interfaces
{
    class Program
    {
        static void Main(string[] args)
        {
            ILog log;
            log = new TextLog();
            log.Target = "c:\\temp\\test.log";
            log.Write("tekstlogger via interface");

            LogBase slog;
            slog = new SimpleLog();
            Console.WriteLine("Still something wrong");
            //slog.Target("c:\\temp\\slog.txt");
            slog.Write("logging via abstract class");

        }
    }
}
