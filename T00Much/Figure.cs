using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace T00Much
{
    abstract class Figure
    {
        public enum condition
        {
            visibl,
            invisible
        }

        public Figure(string color, condition condition)
        {
            Color = color;
            Condition = condition;
        }

        public string Color { get; set; }

        public condition Condition { get; set; }

        public abstract void MoveX(int x);
        public abstract void MoveY(int y);
        public abstract void ChangeColor(string color);
        public abstract void ChangeCondition(condition Condition);


    }
}
