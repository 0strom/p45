using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp22222222333444
{
    internal class Program333
    {

        struct Vector
        {
            public int x, y, z;

            public Vector(int a, int b, int c)
            {
                x = a;
                y = b;
                z = c;
            }

            public static Vector operator +(Vector a, Vector b)
            {
                return new Vector(a.x + b.x, a.y + b.y, a.z + b.z);
            }

            public static Vector operator -(Vector a, Vector b)
            {
                return new Vector(a.x - b.x, a.y - b.y, a.z - b.z);
            }

            public static Vector operator *(Vector a, int n)
            {
                return new Vector(a.x * n, a.y * n, a.z * n);
            }

            public override string ToString()
            {
                return x + ", " + y + ", " + z;
            }
        }

        struct DecimalNumber
        {
            public int number;

            public DecimalNumber(int n)
            {
                number = n;
            }

            public string Binary()
            {
                return Convert.ToString(number, 2);
            }

            public string Octal()
            {
                return Convert.ToString(number, 8);
            }

            public string Hex()
            {
                return Convert.ToString(number, 16);
            }
        }

        struct RGB
        {
            public int r, g, b;

            public RGB(int red, int green, int blue)
            {
                r = red;
                g = green;
                b = blue;
            }

            public string Hex()
            {
                return "#" + r.ToString("X2") +
                             g.ToString("X2") +
                             b.ToString("X2");
            }

            public string HSL()
            {
                double R = r / 255.0;
                double G = g / 255.0;
                double B = b / 255.0;

                double max = Math.Max(R, Math.Max(G, B));
                double min = Math.Min(R, Math.Min(G, B));
                double h = 0, s = 0;
                double l = (max + min) / 2;

                if (max != min)
                {
                    double d = max - min;
                    s = l > 0.5 ? d / (2 - max - min) : d / (max + min);

                    if (max == R)
                        h = (G - B) / d + (G < B ? 6 : 0);
                    else if (max == G)
                        h = (B - R) / d + 2;
                    else
                        h = (R - G) / d + 4;

                    h *= 60;
                }

                return "H: " + h + ", S: " + s * 100 + "%, L: " + l * 100 + "%";
            }

            public string CMYK()
            {
                double R = r / 255.0;
                double G = g / 255.0;
                double B = b / 255.0;

                double k = 1 - Math.Max(R, Math.Max(G, B));
                double c = 0, m = 0, y = 0;

                if (k < 1)
                {
                    c = (1 - R - k) / (1 - k);
                    m = (1 - G - k) / (1 - k);
                    y = (1 - B - k) / (1 - k);
                }

                return "C: " + c * 100 + "%, M: " + m * 100 +
                       "%, Y: " + y * 100 + "%, K: " + k * 100 + "%";
            }
        }

        class Program
        {
            static void Main()
            {
                Vector a = new Vector(1, 2, 3);
                Vector b = new Vector(4, 5, 6);

                Console.WriteLine("Addition: " + (a + b));
                Console.WriteLine("Subtraction: " + (a - b));
                Console.WriteLine("Multiplication: " + (a * 2));

                DecimalNumber n = new DecimalNumber(25);

                Console.WriteLine("\nBinary: " + n.Binary());
                Console.WriteLine("Octal: " + n.Octal());
                Console.WriteLine("Hex: " + n.Hex());

                RGB color = new RGB(255, 100, 50);

                Console.WriteLine("\nHEX: " + color.Hex());
                Console.WriteLine("HSL: " + color.HSL());
                Console.WriteLine("CMYK: " + color.CMYK());
            }
        }

    }
}
