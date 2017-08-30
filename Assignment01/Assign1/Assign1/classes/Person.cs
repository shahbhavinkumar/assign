using System;
using System.IO;

namespace Assign1
{
    class Person
    {
        //Intitalize the variables
        private string personName= "", officeNumber="", telephoneNumber = "";

        //Parameterized constructor used to initialize the objects
        Person(string personName, string officeNumber, string telephoneNumer)
        {
            this.personName = personName;
            this.officeNumber = officeNumber;
            this.telephoneNumber = telephoneNumer;
        }

        //Defining the Getter's and Setters
        public string PersonName { get => personName; set => personName = value; }
        public string OfficeNumber { get => officeNumber; set => officeNumber = value; }
        public string TelephoneNumber { get => telephoneNumber; set => telephoneNumber = value; }

        //Overriding the compareTo()
     /*   public int CompareTo(Person OBJ)
        {
            if(this.personName > OBJ.personName)
            {
                Console.Write("Greateer than OBJ");
            }
            else if(this.personName.Equals(OBJ.personName))
            {
                Console.Write("equal");
            }
            else
            {
                Console.Write("this less than OBJ");
            }
        }*/

        
        static class Program
        {
            //Declaration of the variables
            private static Person[] person = new Person[20];
            private static int InUse = 0;
        }

        //Main() to invoke the program 
        static void Main(string[] args)
        {

            string path = @"C:/R.txt";
            try
            {
                if (File.Exists(path))
                {
                    //File.Delete(path);
                }

                byte[] byteArray = System.Text.Encoding.UTF8.GetBytes(path);
                //byte[] byteArray = Encoding.ASCII.GetBytes(contents);
                MemoryStream stream = new MemoryStream(byteArray);

                using (StreamReader sr = new StreamReader(stream))
                {
                    while (sr.Peek() >= 0)
                    {
                        Console.WriteLine(sr.ReadLine());
                    }
                }
            }
            catch (Exception e)
            {
                Console.WriteLine("The process failed: {0}", e.ToString());
            }
        }
    }
    
}