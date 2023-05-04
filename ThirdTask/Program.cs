using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ThirdTask
{
    internal class Program
    {
        static void Main(string[] args)
        {
            RGBColor rGB = new RGBColor(200, 100, 50);
            Console.WriteLine($"HEX format: {rGB.ToHex()}");
            Console.WriteLine($"HSL format: {rGB.ToHSL()}");
            Console.WriteLine($"CMYK format: {rGB.ToCmyk()}");
        }
        struct RGBColor
        {
            public int R;
            public int G;
            public int B;

            public RGBColor(int r, int g, int b)
            {
                R = r;
                G = g;
                B = b;
            }

            public string ToHex()
            {
                string hexR = R.ToString("X2");
                string hexG = G.ToString("X2");
                string hexB = B.ToString("X2");
                return $"#{hexR}{hexG}{hexB}";
            }
            public string ToHSL()
            {
                float r = R / 255f;
                float g = G / 255f;
                float b = B / 255f;

                float max = Math.Max(Math.Max(r, g), b);
                float min = Math.Min(Math.Min(r, g), b);

                float delta = max - min;

                float lightness = (max + min) / 2.0f;

                if (delta == 0f)
                {
                    return $"HSL(0, 0%, {(int)(lightness * 100)}%)";
                }

                float saturation = delta / (lightness < 0.5f ? (2f * lightness) : (2f - 2f * lightness));

                float hue = 0f;


                if (lightness < 0.5f)
                {
                    saturation = (float)(delta / (max + min));
                }
                else
                {
                    saturation = (float)(delta / (2.0f - max - min));
                }
                if (r == max)
                {
                    hue = (g - b) / delta;
                }
                else if (g == max)
                {
                    hue = 2f + (b - r) / delta;
                }
                else if (b == max)
                {
                    hue = 4f + (r - g) / delta;
                }

                return $"HSL({(int)hue}, {(int)(saturation * 100)}%, {(int)(lightness * 100)}%)";
            }

            public string ToCmyk()
            {
                double r = R / 255.0;
                double g = G / 255.0;
                double b = B / 255.0;

                double k = 1 - Math.Max(r, Math.Max(g, b));
                double c = (1 - r - k) / (1 - k);
                double m = (1 - g - k) / (1 - k);
                double y = (1 - b - k) / (1 - k);

                return $"C: {c * 100:0}%, M: {m * 100:0}%, Y: {y * 100:0}%, K: {k * 100:0}%";
            }
        }
    }
}
