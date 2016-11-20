using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Traffic_Simulator
{
    class BoxMuller
    {
        Random rand = new Random();
       
        public static int[] Box(double mu, double sigma)
        {
            Random rand = new Random();
            int[] gaussianSpeeds = new int[10];
            for (int i = 0; i < 10; i++)
            {
                /*This function impliments a single axis of the basic 'Box Muller Transform' which is a pseudo-random
                 * number sampling method. 
                 * 
                 * u1 & u2 are independent random variables between 0 and 1
                 */
                double u1 = rand.NextDouble();
                double u2 = rand.NextDouble();

                /*
                 * z1 is an independent random variable with a standard normal distribution.
                 * randnormal is the sample of a normal distribution N(Mu, Sigma) by deviating from center by randStd. 
                 */
                double z0 = Math.Sqrt(-2.0 * Math.Log(u1)) * Math.Cos(2.0 * Math.PI * u2);
                double z1 = Math.Sqrt(-2.0 * Math.Log(u1)) * Math.Sin(2.0 * Math.PI * u2);

                double randNormal = Math.Round(mu + (sigma + z0), 2);

                gaussianSpeeds[i]=(int)randNormal;
                //return randNormal;
            }

            return gaussianSpeeds;
        }
    }
}
