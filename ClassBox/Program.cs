using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace ClassBox
{
    class Program
    {
        static void Main(string[] args)
        {
            Type boxType = typeof(Box);
            FieldInfo[] fields = boxType.GetFields(BindingFlags.NonPublic | BindingFlags.Instance);
            Console.WriteLine(fields.Count());

            var dimensions = new double[3];

            try
            {
                for (int i = 0; i < dimensions.Length; i++)
                {
                    dimensions[i] = double.Parse(Console.ReadLine());
                }

                var box = new Box(dimensions[0], dimensions[1], dimensions[2]);

                var surfaceArea = box.GetSurfaceArea();
                var lateralSurfaceArea = box.GetLateralSurfaceArea();
                var volume = box.GetVolume();

                Console.WriteLine($"Surface Area - {surfaceArea:f2}");
                Console.WriteLine($"Lateral Surface Area - {lateralSurfaceArea:f2}");
                Console.WriteLine($"Volume - {volume:f2}");
            }
            catch (ArgumentException ex)
            {
                Console.WriteLine(ex.Message);   
            }
        }
    }
}
