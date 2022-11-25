using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KFU_Lesson_10
{
    internal class Team
    {
        public string Name { get; set; }
        public int Ball { get; set; }

        public Team(string name)
        {
            Name = name;
        }
    }
}
