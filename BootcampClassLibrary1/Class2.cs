using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace BootcampClassLibrary1
{
    public class Class2
    {
        public void DoSomethingWithString()
        {
            string s = "Fred";
            const string STRING1 = "Hello!";
            const string STRING2 = "Good Morning";

            string s1 = STRING1+STRING2;
            string s2 = string.Concat(STRING1, STRING2);
            
            string s3 = string.Join(' ',new string[] { STRING1, STRING2 });

            string[] stringArr = s.Split(' ');

            int i = 100;
            decimal d = 10.5m;
            DateTime today = DateTime.Now;

            string s4 = string.Format("The integer is {0}. The decimal is {1}. The date is {2}.", i, d, today);
            string s5 = $"The integer is {i}. The decimal is {d:###.###}. The date is {today}.";


            StringBuilder sb = new();
            sb.Append(STRING1);

            sb.Append("This is a some reallylong text that we want to splice in here");
            sb.AppendLine();

            sb.AppendFormat("The integer is {0}. The decimal is {1:###.###}. The date is {2}.", i, d, today);
            sb.AppendLine();

            sb.AppendLine($"The integer is {i}. The decimal is {d:###.###}. The date is {today}");

            string s6 = sb.ToString();

            string s7 = "hello";
            

        }


    }
}
