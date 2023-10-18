using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using tyuiu.cources.programming.interfaces.Sprint2;

namespace Tyuiu.AvaevaPD.Sprint2.Task1.V11.Lib
{
    public class DataService : ISprint2Task1V11

    {
        public bool[] GetLogicOperations(int a, int b, int c, int d)
        {
            bool[] res = new bool[6];

            res[0] = (a > b) | (c < d); // 145 > 156 - false, 142 < 117 - false
            res[1] = (a + 2 > b) & (c < d); // 145 + 2 > 156 - false, 142 < 117 - false
            res[2] = (b > a) || (d < c); // 145 < 156 - false, 142 > 117 - false 
            res[3] = (a + 2 > b) && (c < d); // 145 + 2 > b - false , 142 < 117 - false
            res[4] = !(!res[2]);
            res[5] = (a > b) ^ (c < d); // 145 > 156 - false, 142 < 117 - false

            return res;

        }
    }
}
