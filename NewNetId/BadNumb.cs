using System;
using System.Collections.Generic;
using System.Text;

namespace NewNetId
{
    class BadNumb : Exception
    {
        public BadNumb()
        { }

        public BadNumb(string message): base(message)
        { 
        
        }
    }
}
