using System;
using System.Collections.Generic;
using System.Text;

namespace lab_8
{
    class lab_8
    {
        public static int GetFirstNumber(int num1)
        {
           
            
             if (num1 >= 5 || num1 <= 0)
             {
                 throw new Exception("please enter a number between 1 and 4");
                    
             }
              else
                  return num1;
            
            
        }
       public static string GetFoodHometown(string word)
       {
            if (word != "hometown" || word != "food")
            {
                throw new Exception("Please enter hometown or food");
            }
            else
                return word;
       }


    }
}
