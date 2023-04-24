using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai_Giua_Ki
{
    internal class Cylinder
    {
        private double radius;
        private double height;
        private double baseArea;
        private double lateralArea;
        private double totalArea;
        private double volume;

        public Cylinder(double radius, double height)
        {
            this.radius = radius;
            this.height = height;
        }

        public void Process()
        {
            baseArea = radius * radius * Math.PI;
            lateralArea = 2 * Math.PI * radius * height;
            totalArea = 2 * Math.PI * radius * (height + radius);
            volume = Math.PI * radius * radius * height;
        }

        public string Result()
        {
            return $"Base Area: {baseArea}\nLateral Area: {lateralArea}\nTotal Area: {totalArea}\nVolume: {volume}";
        }
    }
}
    

