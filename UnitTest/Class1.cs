using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace NUnitDemonstration
// MohanKumar Mutation Test Class Lab 4
{
    public static class Triangle
    {
        public static string ValidTriangle(int firstAngle, int secondAngle, int
        thirdAngle)
        {
            string result;

            //Introducing a Mutation (changing == to != )
            //if ((firstAngle + secondAngle + thirdAngle) != 180)

             //Killing the Mutant by reverting to original Code

                if ((firstAngle + secondAngle + thirdAngle) == 180)
            {
                result = "The triangle is valid.";
            }
            else
            {
                result = "The triangle is NOT valid.";
            }
            return result;
        }
    }
}