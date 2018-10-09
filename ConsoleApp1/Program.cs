using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{

    class FirstException : Exception
    {
        public FirstException(string message) : base(message)
        {
            return;
        }
    }
    class SecondException : Exception
    {
        public SecondException(string message)
        {
            return ;
        }
    }

    class Program
    {


        static void Main(string[] args)
        {
            string EnterMessage;
            try
            {
                Console.WriteLine("Enter your message");
                EnterMessage = Console.ReadLine();
                if (EnterMessage == "One")
                {
                    throw new FirstException("Used First Exception");
                }
                else if (EnterMessage =="Two")
                {
                    throw new SecondException("Used Second Exception");
                }
            }
            catch (Exception e)
            {
                HandleException(e);
            }
            Console.Read();
        }
        
        public static void HandleException(Exception e)
        {
                switch (e)
            {
                case FirstException First:
                    Console.WriteLine(First.Message);
                    break;
                case SecondException Second:
                    Console.WriteLine(Second.Message);
                    break;
            }
        }
    }
}

