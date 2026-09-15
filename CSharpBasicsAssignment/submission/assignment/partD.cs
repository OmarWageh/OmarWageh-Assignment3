using System;
using System.Collections.Generic;
using System.Text;

namespace CSharpBasicsAssignment
{
    public  class partD
    {
        
        private  int number = 10;

        public  void Method1()
        {
            Console.WriteLine(number);                // The number private variable is accessible within the class, so it can be used in Method1 and Methods .
        }

        public void Method2()
        {
            Console.WriteLine(number);
        }
    
        /// ////////////////////////////////////////////////////////////////////////////
     
        public void Method3()
        {
            int age = 25;

            Console.WriteLine(age);
        }
        public void Method4()  // the variable age is not accessible in Method4 because it is declared within Method3 and has a local scope limited to that method
        {

            // Console.WriteLine(age);
        }
        //////////////////////////////////////////////////////////////////////////////////
        public void Method5()
        {
            for (int i = 0; i < 3; i++)
            {
                int x = 10;

                Console.WriteLine(i);
                Console.WriteLine(x);
            }
            //Console.WriteLine(x); you need fromme to excute this variable this give compile time error because the varabile (x) without scobe is local variable 
        }


        public void CompoundAssignmentOperators()
        {
            int total = 100;

            total += 5;
            Console.WriteLine(total);

            total -= 10;
            Console.WriteLine(total);

            total *= 2;
            Console.WriteLine(total);

            total /= 5;
            Console.WriteLine(total);

            total %= 7;
            Console.WriteLine(total);



            /////// total += 5;
            //is equivalent to:
            // total = total + 5;
        }
        public void BitwiseOperators()
        {
            int a = 12;
            int b = 10;
            Console.WriteLine(a & b);
            Console.WriteLine(a | b);
            Console.WriteLine(a ^ b);
            // a = 12 = 1100
            // b = 10 = 1010
            //
            // AND:
            //   1100
            // & 1010
            // ------
            //   1000 = 8
            //
            // OR:
            //   1100
            // | 1010
            // ------
            //   1110 = 14
            //
            // XOR:
            //   1100
            // ^ 1010
            // ------
            //   0110 = 6
            //////////////////////////////////////////////////////////////////////////////////
           //what is different between & ,&&
           //& ===>do with bit by bit 
           //&&=====>>>logic using true or false 
        }
    }
}
