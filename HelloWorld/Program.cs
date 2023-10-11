using System;

namespace HelloWorld
{
    class Program
    {
        static void Main(string[] args)
        {
            int myNum = 5; //we declare (create) a variable that stores integer values like (1,5,19) and it's name is myNum
            double myDoubleNum = 5.99D;
            char myLetter = 'D';
            bool myBool = true;
            string myText = "Hello";


            Console.WriteLine("We create an integer variable and its value is : " + myNum);
            Console.WriteLine("We create an double variable and its value is : " + myDoubleNum);
            Console.WriteLine("We create an boolean variable and its value is : " + myBool);
            Console.WriteLine("We create an string variable and its value is : " + myText);
            myNum = 20;
            Console.WriteLine("We assign a new value to our integer variable and its new value is : " + myNum);

            Console.ReadLine();
        }
    }
}
