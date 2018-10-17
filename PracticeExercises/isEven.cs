using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeExercises
{
    public class IsEven
    {
        public bool this[bool check]
        {
            get
            {
                if (check == false)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
        }
    }
}
