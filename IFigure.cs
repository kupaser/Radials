using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Radials
{
    internal interface IFigure
    {
        /// <summary>
        /// Стороны фигуры
        /// </summary>
        public List<double> lines { get; set; }
        /// <summary>
        /// Вычисление площади фигуры
        /// </summary>
        /// <returns>Результат вычисления площади фигуры</returns>
        public double Square();
        /// <summary>
        /// Каждая фигура должна соответствовать правилам:
        /// невозможность нулевых и отрицательных значений.  
        /// стороны представлены числами
        /// Рекоммендуется вызывать в конструкторе для проверки значений создаваемой фигуры
        /// </summary>
        /// <param name="lines">Стороны фигуры</param>
        /// <returns>Результат проверки на правильные значения</returns>
        private protected static bool MyLinesIsRight(params double[] lines)
        {
            foreach (var line in lines)
            {
                if (line is double.NaN)
                {
                    throw new ArgumentException($"Стороны фигуры должны быть числами!");
                }
                if (line == 0)
                {
                    throw new ArgumentException($"Стороны фигуры не могут равняться нулю!");
                }
                if (line < 0)
                {
                    throw new ArgumentException($"Сторона не может быть меньше нуля!");
                }
            }
            return true;
        }
    }
}
