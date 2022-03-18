using System;
using System.Collections.Generic;
using System.Text;

namespace NewNetId
{
    class BadName : Exception
    {
        public BadName()
        { 
        
        }

        public BadName(string message) : base(message)
        { 
        
        }
    }
}
