using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Radials
{
    public class Triangle : IFigure
    {
        public List<double> lines { get; set; } = new(3);

        public Triangle(double one_line, double two_line, double three_line)
        {
            if (IFigure.MyLinesIsRight(one_line,two_line,three_line))
            {
                if (!(
                one_line + two_line > three_line &&
                one_line + three_line > two_line &&
                three_line + two_line > one_line
                ))
                {
                    throw new ArgumentException($"Прямоугольник с параметрами: {one_line}, {two_line}, {three_line} не существует!");
                }
            }
            lines = [one_line, two_line, three_line];
            //Если там есть гипотенуза, то она будет последней
            lines.Sort();
        }

        /// <summary>
        /// Проверка по Пифагору
        /// </summary>
        /// <returns>Прямоугольный ли треугоольник</returns>
        public bool IsRight()
        {
            try
            {
                if (Math.Pow(lines[2],2) == Math.Pow(lines[1],2) + Math.Pow(lines[0],2))
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return false;
            }
        }
        
        //формула Герона
        public double Square()
        {
            var s = lines.Sum() / 2;
            var A = Math.Sqrt(s * (s - lines[0]) * (s - lines[1]) * (s - lines[2]));
            return A;
        }
    }
}
