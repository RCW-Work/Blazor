using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Threading.Tasks;

namespace BlazorSCADA.Components
{
    public class Components
    {
        public class testBtn
        {
            public delegate void testDelegate();
            public event testDelegate onTrigger;

            public void testDelegateFunction() { }

            public void testLoop()
            {
                testDelegate cbfunction = new testDelegate(testDelegateFunction);

                for (int i = 0; i < 10; i++)
                {
                    cbfunction.Invoke();
                }
            }
            

    }
    }
}
