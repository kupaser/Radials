using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Radials
{
    public class Circle : IFigure
    {
        public List<double> lines { get; set; } = new(1);
        public Circle(double radius)
        {
            if (IFigure.MyLinesIsRight(radius))
            {
                lines.Add(radius);
            }
        }
        public double Square()
        {
            return Math.PI * Math.Pow(lines[0],2);
        }
    }
}
