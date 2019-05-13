using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UniqueList
{
    public class ItemIsAlreadyExist : Exception
    {
        public ItemIsAlreadyExist()
        {
        }

        public ItemIsAlreadyExist(string message) : base(message)
        {
        }
    }
}