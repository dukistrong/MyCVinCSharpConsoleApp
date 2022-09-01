using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyCVinCSharpConsoleAppLibrary
{
    public class Other
    {
        public string Developing { get; set; }

        public string JustToSay()
        {
            return $"As I'm a patient, responsible and adaptable person \n" +
                $"ready to learn more and more, I belive I would be a good candidate \n" +
                $"to become a part of your successiful team. \n" +
                $"I would do my best to apply the acquired knowledge in {Developing}";
        }
    }
}
