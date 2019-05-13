using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TreeCalculator
{
    /// <summary>
    /// This type of exception throws when unknown operand have been met by Parse function
    /// </summary>
    public class UnknownOperandException : Exception
    {
        public UnknownOperandException()
        {
        }

        public UnknownOperandException(string message) : base(message)
        {
        }
    }
}
