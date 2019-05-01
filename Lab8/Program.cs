using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab8
{
    class Program
    {
        static void Main(string[] args)
        {



            string[] studentNames = { "Adam White", "Bryan White", "Ben Price", "Bethany White", "Carlos Ringer" };

            string[] homeTowns = { "Detroit", "Livonia", "Novi", "Macomb", "Redford" };

            string[] favoriteFoods = { "Fried Chicken", "Tuna Salad", "Pizza", "Beer", "Nachos" };

            string willContinue = "y";


            {
                while (willContinue == "y")
                {
                   
                        Console.WriteLine("Please select a student to view. Enter a number 1 - 5.");
                    int userInfo = int.Parse(Console.ReadLine());
                        


                    for (int i = 0; i < 5; i++)
                        {

                            if (userInfo == i + 1)
                            {
                                Console.WriteLine($"Student {userInfo} is {studentNames[i]}");

                                Console.WriteLine("What would you like to know about this student?");
                                Console.WriteLine("You may choose either 'hometown' or 'favorite food'.");
                                string userInfo2 = Console.ReadLine().ToLower();


                                if (userInfo2 == "hometown")
                                {
                                    Console.WriteLine($"{studentNames[i]}'s {userInfo2} is {homeTowns[i]}");

                                }
                                else if (userInfo2 == "favorite food")
                                {
                                    Console.WriteLine($"{studentNames[i]}'s {userInfo2} is {favoriteFoods[i]}");
                                }
                                else
                                {
                                    Console.WriteLine("That is not a valid answer! Please enter either 'hometown' or 'favorite food'.");
                                    break;
                                }
                            }
                            //else
                            //{
                            //    Console.WriteLine("That is not a valid answer!");
                                
                            //}
                        }
                    

                    Console.WriteLine("Would you like to get another student's information?   y or n");
                    willContinue = Console.ReadLine().ToLower();

                }
                Console.WriteLine("Thank you for using the student info system!");
            }

















        }
    }
}












