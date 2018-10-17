using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeExercises
{
    public class IsOdd
    {
        public bool this[int number]
        {
            get
            {
                if (number %2 == 0)
                {
                    return false;
                }
                else
                {
                    return true;
                }                
            }
        }
    }
}
