using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab4
{
    public class Test
    {
        public string name { get; set; }
        public int score { get; set; }

        public override string ToString()
        {
            return name + " : " + score;
        }
    }
}