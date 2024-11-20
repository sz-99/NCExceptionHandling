using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExceptionHandling
{
    internal class InputResult
    {
      

        public bool Success { get; set; } = false;
        public int[]? Result { get; set; } = new int[2];
        public string Message { get; set; } = "";

    }
}
