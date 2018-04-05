using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] value)
        {
            CIB cib = new CIB(new Azercell("05148800085"));
            cib.IncreaseBalance();
        }

    }

    interface IPay
    {
        void pay();
    }

    class CIB
    {
        IPay pay;

        public CIB() { }

        public CIB(IPay pay)
        {
            this.pay = pay;
        } 

        public void IncreaseBalance()
        {

            Console.WriteLine("Wait...");
            System.Threading.Thread.Sleep(700);
            pay.pay();
        } 
    }

    class Azercell : IPay
    {
        public string number;

        public Azercell() { }

        public Azercell(string number)
        {

            this.number = number;

        }

        public void pay()
        {
            if (number[1] == '5' && number[2] == '1' || number[2] == '0')
            {
                Console.WriteLine("Paid for Azercell");
            }
            else
            {
                Console.WriteLine("Number is incorrect2");
            }
        }
    }
    class Bakcell : IPay
    {
        public string number;

        public Bakcell() { }

        public Bakcell(string number)
        {
            this.number = number;
        }
        public void pay()
        {

            if (number[1] == '5' && number[2] == '5')
            {
                Console.WriteLine("Paid for Bakcell");
            }
            else
            {
                Console.WriteLine("Number is incorrect");
            } 
        }
    }

    class Naxtel : IPay
    {
        public string number;

        public Naxtel() { }

        public Naxtel(string number)
        {
            this.number = number;
        }
        public void pay()
        {

            if (number[1] == '6' && number[2] == '0')
            {
                Console.WriteLine("Paid for Naxtel");
            }
            else
            {
                Console.WriteLine("Number is incorrect");
            }
        }
    } 
}
