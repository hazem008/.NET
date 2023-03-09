using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AM.ApplicationCore.Services
{
    //classe d'extension
    public static class IntExtension
    {
        public static int add(this int a,int b) 
        { return a + b; }
    }
}
