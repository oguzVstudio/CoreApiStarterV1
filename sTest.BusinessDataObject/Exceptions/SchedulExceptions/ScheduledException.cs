using System;
using System.Collections.Generic;
using System.Text;

namespace sTest.BusinessDataObject.Exceptions.SchedulExceptions
{
    public class ScheduledException : Exception
    {
        public ScheduledException(string message)
            :base(message)
        {
        }
    }
}
