using System;
using System.Text;

namespace supplemental_2
{
    public static class RandomUtils
    {
        private static readonly Random random = new Random();
        
        /// <summary>
        /// Generates a normally distributed random number using Box-Muller Transform.
        /// </summary>
        
        public static double GenerateNormal(double mean, double stdDev)
        {
            double u1 = 1.0 - random.NextDouble();
            double u2 = 1.0 - random.NextDouble();
            double standardNormal = Math.Sqrt(-2.0 * Math.Log(u1)) * Math.Cos(2.0 * Math.PI * u2);
            return mean + stdDev * standardNormal;
        }



        /// <summary>
        /// Generates a random password of given length using A-Z, a-z, 0-9, and _.
        /// </summary>

        public static string GeneratePassword(int length)

        {
            const string chars = "ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz0123456789_";
            StringBuilder password = new StringBuilder(length);
            for (int i = 0; i < length; i++)
            {
                password.Append(chars[random.Next(chars.Length)]);
            }
            return password.ToString();
        }




        /// <summary>
        /// Generates a random color in HEX format and its RGB equivalent.
        /// </summary>
public static (string, (int, int, int)) GenerateRandomColor()
        {
            int r = random.Next(256);
            int g = random.Next(256);
            int b = random.Next(256);
            string hex = $"#{r:X2}{g:X2}{b:X2}";
            return (hex, (r, g, b));
        }
    }
}


