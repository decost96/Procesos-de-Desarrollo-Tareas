using System;
using System.Collections.Generic;
using System.Text;

namespace AbiertoCerrado
{
    class Logging
    {
        public void Info(string message)
        {
            Log.Information(message);
        }
        public void Error(string message, Exception e)
        {
            Log.Error(e, message);
        }
        public void Fatal(string message, Exception e)
        {
            Log.Fatal(e, message);
        }
    }
}
