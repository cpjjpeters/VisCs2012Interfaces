using System;
using System.IO;

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
}