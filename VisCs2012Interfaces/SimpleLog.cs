using System;
using System.IO;

namespace VisCs2012Interfaces
{
    class SimpleLog : LogBase
    {
        public override void Write(string message)
        {
            FileInfo fi = new FileInfo(target);
            StreamWriter sw = fi.AppendText();
            sw.WriteLine(DateTime.Now + " " + message);
            sw.Close();
        }
    }
}