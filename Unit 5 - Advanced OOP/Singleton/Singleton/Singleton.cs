using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Singleton
{
    public class Singletonobj
    {
        //use through whole program
        private static string instance = null;

        //no constructor avaiable
        private Singletonobj()
        {

        }

        //return back instance
        public static string getInstance()
        {
            //first time this is used, it will create the value
            if(instance == null)
            {
                instance = "Justin";
            }

            //value remains through the rest of usage
            return instance;
        }
    }
}
