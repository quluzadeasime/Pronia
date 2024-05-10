using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pronia.Business.Exceptions
{
    public class DublicateCategoryException : Exception
    {
        public DublicateCategoryException(string? message) : base(message)
        {
        }
    }
}
