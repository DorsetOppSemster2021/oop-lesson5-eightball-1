

using oop_lesson5_eightball_1.list_and_foreach_example;
using System;
using System.Collections.Generic;

namespace oop_lesson5_eightball_1
{
    class Program
    {
        static void Main(string[] args)
        {

            Family myFamily = new Family() { Surname = "Robinson", children = new List<Offspring>() };

            Family myFamily2 = new Family();

            myFamily2.children = new List<Offspring>();



            List<Family> myListOfFamilies = new List<Family>()
            {

                new Family{
                    Surname = "Swiss Family Robinson",
                        children = new List<Offspring>(){
                                new Offspring{FirstName = "JOhn"},
                                new Offspring{FirstName = "Peter"},
                                new Offspring{FirstName = "Mary"},

                        }

                        },

                      new Family{
                    Surname = "Swiss Family Vasquez",
                        children = new List<Offspring>(){
                                new Offspring{FirstName = "JOhn"},
                                new Offspring{FirstName = "Peter"},
                                new Offspring{FirstName = "Mary"},

                        }

                        },

                          new Family{
                    Surname = "Swiss Family Coutinho",
                        children = new List<Offspring>(){
                                new Offspring{FirstName = "Madelin"},
                                new Offspring{FirstName = "Pablo"},
                                new Offspring{FirstName = "Bernado"},

                        }

                        },
                          

                                    new Family{
                    Surname = "Swiss Family Campos",
                        children = new List<Offspring>(){
                                new Offspring{FirstName = "Usman"},
                                new Offspring{FirstName = "Zahid"},
                                new Offspring{FirstName = "Marcos"},

                        }

                        }









            };


            foreach(Family currentFamily in myListOfFamilies)

            {
                Console.WriteLine(currentFamily.ToString());

                foreach(Offspring currentChild in currentFamily.children)
                {
                    Console.WriteLine(currentChild.ToString());

                }

            }





            //Offspring offspring = new();
            //offspring.FirstName = "Mr Nasty";
            //offspring.age = 50;
            

            //Console.WriteLine(myFamily.ToString());
            //Console.WriteLine(offspring.ToString());





        
    }
}
    }
