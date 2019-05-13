using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UniqueList
{
    public class ItemDidNotExist : Exception
    {
        public ItemDidNotExist()
        {
        }

        public ItemDidNotExist(string message) : base(message)
        {
        }
    }
}