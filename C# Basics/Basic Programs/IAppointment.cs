using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Basic_Programs
{
    internal interface IAppointment
    {
        void BookApp(int did, string pname);
        void DelApp(string pname);
    }
}
