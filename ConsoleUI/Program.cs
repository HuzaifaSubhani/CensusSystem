using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace ConsoleUI
{
    internal class Program
    {
        public static string Username = "HuzaifaSubhani";
        public static string Password = "Huzaifa123";
        public static string username = "";
        public static string password = "";
        public static string decision ="";
        public static int male=0;
        public static int female = 0;
        public static int other = 0;
        public static int child = 0;
        public static int teen = 0;
        public static int adults = 0;
        public static int oldAge = 0;
        public static int married = 0;
        public static int unmarried = 0;
        public static int islam = 0;
        public static int christianity = 0;
        public static int hinduism  = 0;
        public static int budhism = 0;
        public static int literate = 0;
        public static int illiterate = 0;
        public static int employed = 0;
        public static int unemployed = 0;


        static void Main(string[] args)
        {

            string option = Greet();
            bool check =Login(option);
            string output = "";
            if (check)
            {
                Console.WriteLine("Agr access grant hogaya tu yaha pe admin wala sara kaaam chala dunga");
            }
            do
            {
                output = CensusWorker();
                
            } while (output.ToLower() == "yes");
            Outcome();
            
            Console.ReadLine();
        }
        static string Greet()
        {

            Console.WriteLine("Welcome to the Census Management System");
            Console.WriteLine("What do you want to access? \n A) Admin \n B) Census Worker");
            string ans = Console.ReadLine();
            return ans;
        }
        static string CensusWorker()
            
        {
            Console.WriteLine("Which sector you are working in? \n A \n B \n C \n D");
            string sector = Console.ReadLine();
            Console.WriteLine($"Pls enter the number of houses in sector {sector.ToUpper()}");
            int houses=int.Parse(Console.ReadLine());
            for (int i = 0; i < houses; i++)
            {
                Console.WriteLine("Enter the house number?");
                int houseNumber = int.Parse(Console.ReadLine());
                Console.WriteLine("Enter the number of persons in the house?");
                int houseMembers = int.Parse(Console.ReadLine());
                for (int j = 0; j < houseMembers; j++)
                {
                    Console.WriteLine($"What is the NAME of {j+1} member?");
                    string memberName=Console.ReadLine();

                    Console.WriteLine($"What is the CNIC of {memberName}?");
                    int memberCnic = int.Parse(Console.ReadLine());

                    Console.WriteLine($"What is the GENDER of {memberName}?\n male\n female\n other");
                    string memberGender = Console.ReadLine();
                    if (memberGender.ToLower()=="male")
                    {
                        male++;
                    }
                    else if (memberGender.ToLower() == "female")
                    {
                        female++;
                    }
                    else if (memberGender.ToLower() == "other")
                    {
                        other++;
                    }
               
                    Console.WriteLine($"What is the AGE of {memberName}?");
                    int memberAge =int.Parse(Console.ReadLine());
                    if (memberAge<=12)
                    {
                        child++;
                    }
                    else if (memberAge <= 19)
                    {
                        teen++;
                    }
                    else if (memberAge <= 35)
                    {
                        adults++;
                    }
                    else
                    {
                        oldAge++;
                    }
                    Console.WriteLine($"What is the MARTIAL-STATUS of {memberName}?");
                    string memberMartialStatus = Console.ReadLine();
                    if(memberMartialStatus.ToLower() == "married")
                    {
                        married++;
                    }
                    else if (memberMartialStatus.ToLower() == "unmarried")
                    {
                        unmarried++;
                    }

                    Console.WriteLine($"What is the Religion of {memberName}?");
                    string memberReligion = Console.ReadLine();
                    if (memberReligion.ToLower()=="islam")
                    {
                        islam++;
                    }
                    else if (memberReligion.ToLower() == "christianity")
                    {
                        christianity++;
                    }
                    else if (memberReligion.ToLower() == "hinduism")
                    {
                        hinduism++;
                    }
                    else if (memberReligion.ToLower() == "bubdhism")
                    {
                        budhism++;
                    }

                    Console.WriteLine($"Is {memberName} literate?");
                    string memberLiteracy = Console.ReadLine();
                    if (memberLiteracy.ToLower() == "yes")
                    {
                        literate++;
                    }
                    else if (memberLiteracy.ToLower()=="no")
                    {
                        illiterate++;
                    }



                    Console.WriteLine($"Is {memberName} Employed?");
                    string memberEmployed = Console.ReadLine();
                    if (memberEmployed.ToLower() == "yes")
                    {
                        employed++;
                    }
                    else if (memberEmployed.ToLower()=="no")
                    {
                        unemployed++;
                    }

                }
            }
               Console.WriteLine("Do you want to continue");
               decision = Console.ReadLine();
               return decision;

        }
        static bool Login(string option)
        {


            if (option.ToLower() == "a")
            {
                Console.WriteLine("Pls Enter the Username?");
                username = Console.ReadLine();

                if (username != Username)
                {
                    Console.WriteLine("Incorrect Username");
                    Console.WriteLine("Pls Re-Enter the Username?");
                    username = Console.ReadLine();
                    if (username == Username)
                    {
                        Console.WriteLine("Pls Enter the Password?");
                        password = Console.ReadLine();
                        if (password != Password)
                        {
                            Console.WriteLine("Incorrect Password");
                            Console.WriteLine("Pls Re-Enter the Password?");
                            password = Console.ReadLine();
                            if (password == Password)
                            {
                                Console.WriteLine("Login successfull");
                                return true;

                            }
                            else
                            {
                                Console.WriteLine("Access Denied!");
                                return false;


                            }
                        }
                        else
                        {
                            Console.WriteLine("Login successfull");
                            return true;

                        }

                    }
                    else
                    {
                        Console.WriteLine("Access Denied!");
                        return false;

                    }


                }
                else
                {
                    Console.WriteLine("Pls Enter the Password?");
                    password = Console.ReadLine();
                    if (password != Password)
                    {
                        Console.WriteLine("Incorrect Password");
                        Console.WriteLine("Pls Re-Enter the Password?");
                        password = Console.ReadLine();
                        if (password == Password)
                        {
                            Console.WriteLine("Login successfull");
                            return true;

                        }
                        else
                        {
                            Console.WriteLine("Access Denied!");
                            return false;

                        }
                    }
                    else
                    {
                        Console.WriteLine("Login successfull");
                        return true;
                    }
                }


             
            }
            else if (option.ToLower() == "b")
            {
                //CensusWorker();
                return false;

            }
            else
            {
            Console.WriteLine("Invalid option");
                return false;

            }

        }
        static void Outcome() {

            Console.WriteLine($"Total number of males are {male}");
            Console.WriteLine($"Total number of females are {female}");
            Console.WriteLine($"Total number of others are {other}");
            Console.WriteLine($"Total number of childs are {child}");
            Console.WriteLine($"Total number of teens are {teen}");
            Console.WriteLine($"Total number of adults are {adults}");
            Console.WriteLine($"Total number of old-age are {oldAge}");
            Console.WriteLine($"Total number of married are {married}");
            Console.WriteLine($"Total number of unmarried are {unmarried}");
            Console.WriteLine($"Total number of muslims are {islam}");
            Console.WriteLine($"Total number of christians are {christianity}");
            Console.WriteLine($"Total number of hindu are {hinduism}");
            Console.WriteLine($"Total number of budhis are {budhism}");
            Console.WriteLine($"Total number of literate are {literate}");
            Console.WriteLine($"Total number of illeterate are {illiterate}");
            Console.WriteLine($"Total number of employed are {employed}");
            Console.WriteLine($"Total number of unemployed are {unemployed}");
        }
    }




    
}
    


