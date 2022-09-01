using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyCVinCSharpConsoleAppLibrary
{
    public class Intro
    {
        public string Name { get; set; }
        public string Sur { get; set; }
        public string City { get; set; }
        public int Age { get; set; }
        public string ItsMe()
        {
            return $"Hi, I'm {Name} {Sur} from {City}. I'm {Age} " +
                $"and looking forward to become a developer";
        }
    }
}
