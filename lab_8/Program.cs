using System;

namespace lab_8
{
    class Program
    {
        static void Main(string[] args)
        {
            
            string[] people = { "Andre", "Tywin", "Maria", "Mike" };
            string[] homeTown = { "Ann Arbor, Jackson", "Benton Harbor", "Saline" };
            string[] favoriteFood = { "Tacos", "Pho", "Peppers", "BBQ" };





            //call for number


                beg:
                Console.WriteLine("Welcome to out C# class. Which student would you like to learn about? (enter a number 1-4)");
                int num1 = int.Parse(Console.ReadLine());
                //1
                try
                {
                    lab_8.GetFirstNumber(num1);
                }
                catch (Exception LessMoreThan)
                {
                    Console.WriteLine(LessMoreThan.Message);
                }



                //1[0]
                if (num1 == 1)
                {
                    Console.WriteLine($" Student 1 is {people[0]} \nWhat would you like to know about {people[0]}");
                    string word = Console.ReadLine();


                do
                {
                    if (word == "hometown")
                    {
                        Console.WriteLine($"{people[0]}'s  hometown is {homeTown[0]}.");
                    }
                    else if (word == "food")
                    {
                        Console.WriteLine($" {people[0]}'s favorite food is {favoriteFood[0]}. \n Would you like to know more ?");
                        string yesno = Console.ReadLine();
                        if (yesno == "y")
                        {
                            goto beg;
                        }
                    }

                  Console.WriteLine("the data does not exist please try again . enter food or hometown.");
                    
                }
                while (word != "hometown" || word != "food");
                {

                   
                }
                
                }
                  


                //2[1]


                else if (num1 == 2)
                {
                    Console.WriteLine($" Student 1 is {people[1]} \nWhat would you like to know about {people[1]}");
                    string word = Console.ReadLine();


                    if (word == "hometown")
                    {
                        Console.WriteLine($"{people[1]}'s  hometown is {homeTown[1]}");
                    }
                    else if (word == "food")
                    {
                        Console.WriteLine($"{people[1]}'s favorite food is {favoriteFood[1]}. Would you like to know more (y/n)");
                        string yesno = Console.ReadLine();
                        if (yesno == "y")
                        {
                            goto beg;
                        }
                    }
                }
                //3[2]
                else if (num1 == 3)
                {
                    Console.WriteLine($" Student 1 is {people[2]} \nWhat would you like to know about {people[2]}");
                    string word = Console.ReadLine();


                    if (word == "hometown")
                    {
                        Console.WriteLine($"{people[2]}'s  hometown is {homeTown[2]}");
                    }
                    else if (word == "food")
                    {
                        Console.WriteLine($"{people[2]}'s favorite food is {favoriteFood[2]}. Would you like to know more (y/n) ?");
                        string yesno = Console.ReadLine();
                        if (yesno == "y")
                        {
                            goto beg;
                        }
                    }
                }
                //4[3]
                else if (num1 == 4)
                {
                    Console.WriteLine($" Student 1 is {people[3]} \nWhat would you like to know about {people[3]}");
                    string word = Console.ReadLine();


                    if (word == "hometown")
                    {
                        Console.WriteLine($"{people[3]}'s  hometown is {homeTown[3]}");
                    }
                    else if (word == "food")
                    {
                        Console.WriteLine($"{people[3]}'s favorite food is {favoriteFood[3]}. Would you like to know more (y/n) ?");
                        string yesno = Console.ReadLine();
                        if (yesno == "y")
                        {
                            goto beg;
                        }
                    }


                }
             
        }
    }
}
