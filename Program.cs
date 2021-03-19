using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab2
{
    class Programm
    { }

namespace oops
    { 
        public interface xyz
        {
            void methodA();
            void methodB();
        }

          
        class test : xyz
        {
            public void methodA()
            {
                Console.WriteLine("methodA");
            }
            public void methodB()
            {
                Console.WriteLine("methodB");
            }
        }    
        
        }
    }

