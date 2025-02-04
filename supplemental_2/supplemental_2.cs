using 

namespace supplemental_2;

public class supplemental_2
{
            double u1 = 1.0 - random.NextDouble();
            double u2 = 1.0 - random.NextDouble();
            double standardNormal = Math.Sqrt(-2.0 * Math.Log(u1)) * Math.Cos(2.0 * Math.PI * u2);
            return mean + stdDev * standardNormal;
        }
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


