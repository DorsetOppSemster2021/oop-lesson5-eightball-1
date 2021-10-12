using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oop_lesson5_eightball_1.list_and_foreach_example
{
    public class Family
    {
        public Family()
        {

        }
        public Family(string _Surname)
        {
            Surname = _Surname;
        }
        public string Surname { get; set; }

        public List<Offspring> children = new List<Offspring>();


        public override string ToString()
        {
            return $"I am the Family {Surname}";
        }
    }


    public class Offspring
    {
     
        public string FirstName { get; set; }
        public override string ToString()
        {
            //return base.ToString();
            return $"================I am offspring. My first name is {FirstName}";

        }

    }
}
