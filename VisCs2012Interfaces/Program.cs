using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VisCs2012Interfaces
{
    public class TextLog : ILog
    {
        public void Write(string msg)
        {
            FileInfo fi = new FileInfo(_target);
            StreamWriter sw = fi.AppendText();
            sw.WriteLine(DateTime.Now + " "+ msg);
            sw.Close();
        }

        private string _target;
        public string Target
        {
            get { return _target;}
            set { _target = value; }
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            ILog log;
            log = new TextLog();
            log.Target = "c:\\temp\\test.log";
            log.Write("tekstlogger via interface");
        }
    }
}
