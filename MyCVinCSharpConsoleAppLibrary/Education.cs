using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyCVinCSharpConsoleAppLibrary
{
    public class Education
    {
        public string University { get; set; }
        public string Title { get; set; }
        public string License1 { get; set; }
        public string License2 { get; set; }
        public string License3 { get; set; }
        public string License4 { get; set; }
        public string IssueAuthority { get; set; }
        public string Member { get; set; }
        public string MyEducation()
        {
            return $"Highest level of my education is {Title}, {University}. \n" +
                $"Also I'm holder of these licenses issued by {IssueAuthority}: \n" +
                $"\t-{License1} \n\t-{License2} \n\t-{License3} \n\t-{License4}. \n" +
                $"I am proud member of {Member}.";
        }
        public Education(string university, string title, string license1, string license2, string license3, string license4, string issueAuthority, string member)
        {
            University = university;
            Title = title;
            License1 = license1;
            License2 = license2;
            License3 = license3;
            License4 = license4;
            IssueAuthority = issueAuthority;
            Member = member;
        }
    }
}
