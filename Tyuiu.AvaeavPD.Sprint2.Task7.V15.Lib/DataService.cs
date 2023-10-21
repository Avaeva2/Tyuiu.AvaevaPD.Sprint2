﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using tyuiu.cources.programming.interfaces.Sprint2;
namespace Tyuiu.AvaeavPD.Sprint2.Task7.V15.Lib
{
    public class DataService : ISprint2Task7V15
    {
        public bool CheckDotInShadedArea(double x, double y)
        {
            bool res;
            if ((Math.Pow(x,2)+ Math.Pow(y,2) <= 1) && ((x>0) && (x <= 1) && (y>0) && (x <=1)))
            {
                res = true;
            }
            else
            {
                res = false;
            }
            return res;
        }
    }
}
