using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjemploBanca
{
    public interface ILog 
    {
        bool IsLogEnabled { get; }
        void WriteLine(string text);
    }
}
