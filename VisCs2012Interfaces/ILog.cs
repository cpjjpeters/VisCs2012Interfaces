using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VisCs2012Interfaces
{
    interface ILog
    {
        void Write(String msg);
        string Target
        {
            set;
            get;
        }
    }
}
