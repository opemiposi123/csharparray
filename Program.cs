
using System;

namespace TestApp
{
   class program
   {
     static void Main(string[] args) 
      {
          
           /* Console.WriteLine("Enter four digit number: ");
               string numberInput = Console.ReadLine();

               int number1 = Convert.ToInt32(numberInput[0].ToString()); 
                   int number2 = Convert.ToInt32(numberInput[1].ToString()); 
                int number4 = Convert.ToInt32(numberInput[3].ToString()); 

              int addFourDigit = number1 + number2 + number3 + number4;

              Console.WriteLine($"Addition of the four digit is: {addFourDigit}");

              Console.WriteLine($"Move last digit to first position: {number4}{number1}{number2}{number3}");*/

             /*Console.WriteLine("Enter applicant firstname:"); 
           string applicantFirstname = Console.ReadLine();

           Console.WriteLine("Enter applicant othername:");
           string applicantOthername = Console.ReadLine();

           Console.WriteLine("Enter applicant age:");
           int applicantAge = Convert.parse(Console.ReadLine());


          Console.WriteLine("Enter applicant gender:");
          string applicantGender = Console.ReadLine();

          Console.WriteLine("Enter applicant parents:");
          string applicantParent = Console.ReadLine();

         Console.WriteLine("Enter apploicant previous school");
          string applicantPreviousSchool */




             Random random = new Random();

            int noOfDaysRemaining = random.Next(11);
            int discount = 0;

            if (noOfDaysRemaining <= 10)
            {
              Console.WriteLine($"Your suscribtion will soon expire");
            }

             else if(noOfDaysRemaining <=5)
            {
               Console.WriteLine($"Your suscribtion will expire in {noOfDaysRemaining}days.\nRenew now and get {discount}% discount");
            }

            if (noOfDaysRemaining ==2)
            {
               Console.WriteLine($"Your suscribtion will expire in {noOfDaysRemaining}days.\nRenew now and get {discount}% discount");
            }
            else if (noOfDaysRemaining ==1)
             {
                 Console.WriteLine($"Your suscribtion will expire in a day");
             }

             /*string phonenumber ="0803757820";

             foreach (char digit in phonenumber)
             {

              if(digit % 2 == 0 && digit != '0')
                {
                   Console.WriteLine(digit);
                }
             }


               for (int i = 0; i <=10; i--) 
              {
                Console.WriteLine
              }
          

             }
             */
             //  string[] person = {"ade","sola","mahmood","intiosor","sultoon"};
             //Console.WriteLine(person[2]);

             /* int[] numbers = {1,2,3,5,};
              for (int i = 0; i < numbers.Length; i++) 
              {
                 Console.WriteLine(cars[i]);

              } 
                Console.WriteLine("      ");
                Array.Sort(cars);
               foreach(int i in cars)
               {
                  Console.WriteLine(i);

               }
               Console.WriteLine("       ");
               Console.WriteLine(cars.Sum());
                */
                /*  Console.WriteLine("----------------------calculator-------------------------");
               Console.WriteLine("input any number:");
                double number = Convert.Parse(Console.ReadLine());
               Console.WriteLine($"operators e.g \n add = +  \n subtract = - \n multiplication = *  \n division = / \n input an operator");
              string operands = Console.ReadLine();
               const string add = "+";
               const string mult = "*";
               const string sub = "-";
               const string div = "/";
               
         
               Console.WriteLine("input secondnumber :");
               double secnumber = Convert.ToInt64 (Console.ReadLine());
              
                switch (opera)
      
                 case mult:
                  Console.WriteLine($"{number}*{secnumber}={number * secnumber}");
                   break;
                 case add:
                   Console.WriteLine($"{number} + {secnumber} = {number + secnumber}");
                   break;
                 case sub :
                   Console.WriteLine($"{number}-{secnumber} = {number - secnumber}");
                   break;
                 case div :
                  Console.WriteLine($"{number}/{secnumber} = {number / secnumber}");
                  break;

                 int[] myNumbers = {5, 1, 8, 9};
                // Console.WriteLine(myNumbers.Max());  // returns the largest value
                 // Console.WriteLine(myNumbers.Min());  // returns the smallest value
                 //Console.WriteLine(myNumbers.Sum());  // returns the sum of elements*/

                        
             //no1
             string[] months = {"january","febuary","march","april","may","june","july","august","september","october","november","december"}; 
           int numOfMonths = months.Length;
           Console.WriteLine(numOfMonths);
           Console.WriteLine("   \n  ");

           //no2
          for (int i = 0; i < months.Length; i++)
         {
             Console.WriteLine(months[i]);
         }
         Console.WriteLine("  \n   ");
         +
         //no3
         //for Array method
         //reverse 
          string[] month = {"january","febuary","march","april","may","june","july","august","september","october","november","december"};

         for (int i = months.Length -1; i >= 0; i--)
         {
           Console.WriteLine(months[i]);
         }
         Console.WriteLine("  \n    ");
          //no4
          //sort method
          string[] namesOfMonth = {"january","febuary","march","april","may","june","july","august","september","october","november","december"};
          Array.Sort(namesOfMonth);
          foreach (string i in namesOfMonth)
          {
            Console.WriteLine(i);
          }
          Console.WriteLine("    \n    ");

          //no5
          //copy the 1st six month to another array
          string[]

          



          
      
    





     
      }
   }
}