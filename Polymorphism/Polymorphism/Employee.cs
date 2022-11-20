using System;
using System.Collections.Generic;
using System.Text;

namespace Polymorphism
{

    class Employee : IQuittable
    {
        public void Quite()
        {
           //create error of implementation exception
            throw new NotImplementedException();
        }

        public void QuiteAgain()
        {
            throw new NotImplementedException();
        }
    }
}
