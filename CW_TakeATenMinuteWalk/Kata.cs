using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CW_TakeATenMinuteWalk
{
    public class Kata
    {
        public bool IsValidWalk(string[] walk)
        {
            var countN = 0;
            var countS = 0;
            var countW = 0;
            var countE = 0;
            foreach (var item in walk)
            {
                switch (item)
                {
                    case "n":
                        countN++;
                        break;
                    case "s":
                        countS++;
                        break;
                    case "w":
                        countW++;
                        break;
                    default:
                        countE++;
                        break;
                }
                
            }
            if (walk.Count() == 10 && (countN == countS && countW == countE))
            {
                return true;
            }
            return false;

        }
    }
}
