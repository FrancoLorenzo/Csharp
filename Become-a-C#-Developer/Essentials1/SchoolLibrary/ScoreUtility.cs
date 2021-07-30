using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolLibrary
{
    public class ScoreUtility
    {
        public static IScored BestofTwo(IScored Assignment1, IScored Assignment2)
        {
            var score1 = Assignment1.Score / Assignment1.MaximunScore;
            var score2 = Assignment1.Score / Assignment1.MaximunScore;

            if (score1 > score2)
            {
                return Assignment1;
            }
            else
            {
                return Assignment2;
            }
        }
    }
}
