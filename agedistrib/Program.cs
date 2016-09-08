using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace agedistrib
{
    class Program
    {
        /* ou're responsible for providing a demographic report for your local school district based on age. To do this, you're going to determine which 'category' each person fits into based on their age. The person's age will determine which category they should be in:

If they're from 0 to 2 the child should be with parents print : 'Still in Mama's Arms' 
If they're 3 or 4 and should be in preschool print : 'Preschool Maniac' 
If they're from 5 to 11 and should be in elementary school print : 'Elementary School' 
From 12 to 14: 'Middle School' 
From 15 to 18: 'High School' 
From 19 to 22: 'College'
From 23 to 65: 'Working for the Man' 
From 66 to 100: 'The Golden Years' 
If the age of the person is less than 0 or more than 100 - it might be an alien - print: "This program is for humans".
*/
        static void Main(string[] args)
        {

            Console.WriteLine("How old are you?");
            int userAge = int.Parse(Console.ReadLine());

            if (userAge >= 0 && userAge <= 2)
            {
                Console.WriteLine("Still in Mama's arms");

            }
            else if (userAge ==3 && userAge ==4)
            {
                Console.WriteLine("Preschool Maniac");
            }

            else if (userAge >=5 && userAge <= 11)
            {

                Console.WriteLine("Elementary School");
            }


        }



    }
}
