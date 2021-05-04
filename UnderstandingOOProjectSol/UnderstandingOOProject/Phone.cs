using System;
using System.Collections.Generic;
using System.Text;

namespace UnderstandingOOProject
{
    class Phone
    {
      
        public string color { get; set; }
        //public Phone() { }   Defalut public empty constructor

        public Phone()
        {
            Console.WriteLine("Called the constructor");
        }
        public void checkWorkPublic()
        {
            Console.WriteLine("Public Method");
        }
        protected void checkWorkProtected()
        {
            Console.WriteLine("Protected Method");
        }
        private void checkWorkPrivate()
        {
            Console.WriteLine("private Method");
        }
        internal void checkWorkInternal()
        {
            Console.WriteLine(" Public Internal Method");
        }
    }
}
