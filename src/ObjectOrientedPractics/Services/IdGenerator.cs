using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObjectOrientedPractics.Services
{
    public static class IdGenerator
    {
        private static int _id = 0;

        public static int GetNextID()
        {
            _id++;
            return _id;
        }
    }
}


