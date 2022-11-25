using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace T00Much
{
    internal class Point : Figure
    {
        public int X { get; set; }
        public int Y { get; set; }


        public Point(int x, int y, string color, condition condition) : base(color, condition)
        {
            X = x;
            Y = y;
            Color = color;
            Condition = condition;
        }


        public override void MoveX(int x)
        {
            X += x;
        }

        public override void MoveY(int y)
        {
            Y += y;
        }


        public override void ChangeColor(string color)
        {
            Color = color;
        }

        public override void ChangeCondition(condition Condition)
        {
            this.Condition = Condition;
        }
    }
}
