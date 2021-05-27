using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Q1
{
    class Program
    {
        public static void Q1_Main()
        {
            int a = 10, b = 20;
            int sum = Calculator.AddNums(a, b);


            string output = "The sum of " + a + " and " + b + " is " + sum;
            Console.WriteLine(output);
        }
    }
    class Calculator
    {
        public static int AddNums(int a, int b)
        {
            return a + b;
        }
    }
}

namespace Q2
{
    class Program
    {
        public static void Q2_Main()
        {
            string s = "hello world";
            s.Replace('o', 'i');
            s.Replace("r", string.Empty);
            Console.WriteLine(s);
        }
    }
}
// Output - hello world
// Because replace will return a new string replacing all the occurence of the existing string.
namespace Q3
{
    class Program
    {
        public static void Q3_Main()
        {
            int[] a = new int[5];
            for (int i = 0; i <= 6; i++)
            {
                a[i] = i; // Index Out of bound error after 5 Iteration.
                Console.WriteLine(a[i]);
            }
        }
    }
}

namespace Q4
{
    class Program
    {
        public static void Q4_Main()
        {
            KnowVar k = new KnowVar();
            k.MyMethod(2);
        }
    }
    class KnowVar
    {
        int _m = 10;
        public void MyMethod(int i, int j = 10)
        {
            var k = i + j;
            var sum = "The sum";
            int n;
            string mul;
            n = i * j;
            mul = "The multiplication";
            var ob = new Program();
            KnowVar ob2 = null;
        }
    }
}

namespace Q5
{
    class Program
    {
        static void AnArray()
        {
            DateTime dt = new DateTime(2019, 01, 01);
            ArrayList arr = new ArrayList();
            bool b = false;
            string str = "sample string";
            arr.Add(10);
            arr.Add(b);
            arr.Add(dt);
            arr.Add(str);

            foreach (var item in arr)
            {
                Console.WriteLine(item);
            }
        }
        public static void Q5_Main()
        {
            AnArray();
        }
    }
}

namespace Q6
{
    class Program
    {
        public static void Q6_Main()
        {
            Point p = new Point(10, 20);
            Tuple<int, int> tuple = p.Deconstruct();
            Console.WriteLine(tuple.Item1 + " " + tuple.Item2);
        }
    }
    class Point
    {
         readonly int X, Y;
        public Point(int X, int Y)
        {
            this.X = X;
            this.Y = Y;
        }

        public Tuple<int, int> Deconstruct()
        {
            return Tuple.Create(X,Y);
        }
    }
}

namespace Q7
{
    class ShopCart
    {
        public int wsc { get; set; }
        protected int tax { get; set; }
        protected int profit { get; set; }
        public ShopCart(int w, int t, int p)
        {
            wsc = w;
            tax = t;
            profit = p;
        }
        public int WholeSaleCost()
        {
            return wsc;
        }
        public int Tax()
        {
            return tax;
        }
        public int Profit()
        {
            return profit;
        }
    }
    class Wheat5kgBag : ShopCart
    {
        public Wheat5kgBag() : base(150, 5, 50)
        {

        }

    }
    class RefinedOil5kg : ShopCart
    {
        public RefinedOil5kg() : base(280, 10, 70)
        {

        }

    }
    class Buyer
    {
        public static void Q7_Main(
            )
        {
            var shoppingCart = new ShopCart[3];
            shoppingCart[0] = new Wheat5kgBag();
            shoppingCart[1] = new Wheat5kgBag();
            shoppingCart[2] = new RefinedOil5kg();
            Biller biller = new Biller();
            float totalBill = biller.CalculateTotalBill(shoppingCart);
            Console.WriteLine($"Total Bill = " + totalBill);
        }
    }
    class Biller
    {
        public float CalculateTotalBill(ShopCart[] Cart)
        {
            float total = 0f;
            foreach (ShopCart c in Cart)
            {
                total += c.WholeSaleCost() + c.Tax() + c.Profit();
            }
            return total;
        }
    }
}
namespace InSem_I
{

    class Program
    {
        static void Main(string[] args)
        {
            /*Q1.Program.Q1_Main();
            Q2.Program.Q2_Main(); 
            //Q3.Program.Q3_Main(); //Runtime Error
            Q4.Program.Q4_Main(); 
            Q5.Program.Q5_Main(); 
            Q6.Program.Q6_Main(); 
            Q7.Buyer.Q7_Main(); */
            
            Console.Read();
        }
    }
}
