using System;




    class EmployeeData
    {
        static void Main(string[] args)
        {
            Console.Write("Enter your first name:");
            string firstName=Console.ReadLine();
            Console.Write("Enter your last name:");
            string lastName = Console.ReadLine();
            Console.Write("Enter your age");
            int age = int.Parse(Console.ReadLine());
           
            if (age > 101)
            {
                Console.Write("Wrong input please enter age");
                Console.ReadLine();
            }
            else if (age < 0)
            {
                Console.WriteLine("Wrong input please enter age");
                Console.ReadLine();
            }
            
            
            Console.Write("Enter your gender (m/f)");
            char gender = char.Parse(Console.ReadLine());

            if (gender !='m')
            {
               
            }
            else if (gender != 'f')
            {
             
            }
            else 
            {
                Console.WriteLine("Wrong symbol please enter m or f");
                Console.ReadLine();
            }
            
           
            Console.Write("Enter your personal ID number");
            int personalIDnumber = int.Parse(Console.ReadLine());
           
            Console.Write("Enter your unique employee number from 27560000 to 27569999: ");
            int employeeNumber = int.Parse(Console.ReadLine());

            if (employeeNumber < 27560000)
            {
                Console.WriteLine("Please enter employee number range  27560000 to 27569999:  ");
            }
            else if (employeeNumber > 27569999)
            {
                Console.WriteLine("Please enter employee number range 27560000 to 27569999");
            }
           
            Console.WriteLine("First Name:{0}\nLast name:{1}\nAge:{2}\nGender:{3}\nID Number{4}\nEmployee Number{5}",firstName,lastName,age,gender,personalIDnumber,employeeNumber);
        }
       
    }

