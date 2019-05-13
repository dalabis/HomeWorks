using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListLib
{
    public class ListIsEmptyException : Exception
    {
        public ListIsEmptyException()
        {
        }

        public ListIsEmptyException(string message) : base(message)
        {
        }
    }
}