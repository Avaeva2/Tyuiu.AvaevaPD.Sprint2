using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using tyuiu.cources.programming.interfaces.Sprint2;

namespace Tyuiu.AvaevaPD.Sprint2.Task3.V2.Lib
{
    public class DataService : ISprint2Task3V2
    {
        public double Calculate(double x)
        {
            double y = 0;

            if (x > 3)
            {
               y =  x - 12x + cosx;
            }
            else
            {
                if (x == 2)
                {
                   y =  x - (1 / x);
                }
                else
                {
                    if ((x > -6) && (x < 1))
                    {
                         y = x^5 + 10x - (1/ x+3);
                    }
                    else
                    {
                        if (x < -6)
                        {
                             y = x + 10x - (1/x^4)
                        }

                    }

                }    
            }

            return Math.Round(y, 3);
        }
    }
}
