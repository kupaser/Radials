using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Radials
{
    public class Quadro : IFigure
    {
        public List<double> lines { get; set; } = new(4);
        public Quadro(double line)
        {
            if (IFigure.MyLinesIsRight(line))
            {
                for (int i = 0; i < 4; i++)
                {
                    lines.Add(line);
                }
            }
        }
        public double Square()
        {
            return Math.Pow(lines[0],2);
        }
    }
}
