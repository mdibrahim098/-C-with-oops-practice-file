using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlTypes;
using System.Net.Http.Headers;
using System.Runtime.InteropServices;
using System.Threading;

namespace BookPractice3
{




   
    class Demo
    {

        class CLDemo
        {
            static void Main(string[] args)
            {
              
                Console.WriteLine("There are " + args.Length + " command line");

                for(int i=0; i<args.Length; i++) {
                    Console.WriteLine(args[i]);
                }

            }


        }

    }



        /*
       static int Main(string[] srgs)
        {
            int a = 20;
            int b = 30;
            if(a%2==0 && b%2==0)
            {
                Console.WriteLine(" hello");
                return (a + b);
            }
            else
            {
                return 0;
            }
           
        }
    }
    /*
    class demo
    {
       static void Factor(int val, int divisible)
        {
            if(val%divisible == 0)
            {
                Console.WriteLine(val+" is divisible by "+divisible);
            }
            else
            {
                Console.WriteLine(val + " is not divisible by " + divisible);
            }
        }

        static void Main(string[] args)
        {
            Factor(24, 5);
            Factor(val: 68, divisible: 3);
            Factor(10, divisible: 2);
            Factor(divisible: 10, val: 50);

        }
    }


   /*
    class Demo
    {
        public void Test(string str,  int start =0, int stop = -1)
        {

            if (stop < 0)
            {
                stop = str.Length;
            }
            if(stop> str.Length || start> stop|| start < 0)
            {
                return;
            }
            for(int i=start; i<stop; i++)
            {
                Console.Write(str[i]);
            }
            Console.WriteLine("");
        }
    }

    class My
    {
        static void Main(string[] args)
        {
            Demo obj = new Demo();
            obj.Test("I love Java");
            obj.Test("I Love Java", 2);
            obj.Test("I Love Java", 2, 6);
        }
    }




    /*
    class Demo
    {
        public void Method(int i, int a =40, string str = "hello")
        {
            Console.WriteLine(a+" "+str);
        }
        public void Method(int k, double f=2.2, string str = "hello")
        {
            Console.WriteLine(a + " " + str);
        }
        public void Method(float a, string str = "hello")
        {
            Console.WriteLine(a + " " + str);
        }

    }
    class My
    {
        static void Main(string[] args)
        {
            Demo obj = new Demo();
        obj.Method(1);
        obj.Method(2, "hi");
            obj.Method(2.2, "bye");


        }
    }



    /*
     * 
    class Optional
    {
        public void method(int a=10, int b=5, int c = 10)
        {
            Console.WriteLine("a "+a +" b "+b+" c "+c);
        }
    }
    class My
    {
        static void Main(string[] args)
        {
            Optional obj = new Optional();
            obj.method(100);
            Console.WriteLine();
            obj.method(50, 200);
            obj.method();
        }
    }

    /*
   class MyClass
    {
       public  int count;
         public string str;

    }
    class My
    {
        static void Main(string[] args)
        {
            MyClass obj = new MyClass { count = 100, str = "Testing" };
            Console.WriteLine(obj.count + " "+ obj.str);
        }
    }



    /*
    class Demo
    {
       
            int LengthOfLongestSubstring(string s)
            {

                Dictionary<char, int> dc = new Dictionary<char, int>();
                int start = 0;
                int length = 0;
                for (int end = 0; end < s.Length; end++)
                {
                char c = s[end];
                    if (dc.ContainsKey(c))
                    {
                        if (start <= dc[c])
                        {
                            start = dc[c] + 1;
                        }
                    }
                    length = Math.Max(length, (end - start + 1));
                dc.Add(c, end);
                }
                return length;

            
        }
    }

    /*
    class XYCoord
    {
        public int x, y;
        public XYCoord(int i, int j) 
        {
            Console.WriteLine(" Inside XYCoord(int , int)");
            this.x = i;
            this.y = j;

        }
        public XYCoord(): this(0,0)
        {
            Console.WriteLine(" inside XYCoord()");

        }
        public XYCoord(XYCoord obj):this(obj.x, obj.y)
        {

            Console.WriteLine("Inside XYCoord(XYCoord obj)");

        }
        public XYCoord(int c) : this()
        {
            Console.WriteLine(" inside(c)" + c);
        }
    }

    class My
    {

        static void Main(string[] args)
        {

            XYCoord obj = new XYCoord();
            XYCoord obj1 = new XYCoord(8,9);
            XYCoord obj2 = new XYCoord(obj1);
            Console.WriteLine(obj.x +" "+obj.y);
            Console.WriteLine(obj1.x+" "+obj1.y);
            Console.WriteLine(obj2.x+" "+obj2.y);
            XYCoord obj3 = new XYCoord(5);
            Console.WriteLine(obj3.x+ " "+obj3.y );



        }
    }



    /*
    class stack
    {
        char[] c;
        int top;

        public stack(int size)
        {
            c = new char[size];
           top = 0;
        }

        public stack(stack obj)
        {
            c = new char [ obj.c.Length];

            for(int i=0; i < obj.top; i++)
            {
                c[i] = obj.c[i];
            }
            top = obj.top;
        }

        public  void push( char a)
        {
            if (IsFull())
            {
                return;
            }

            c[top] = a;
            top++;

        }
        public char pop()
        {
            if (IsEmpty())
            {
                return (char)0;
            }
            top--;
            return c[top];
        }

        public bool IsFull()
        {
            return top == c.Length;
        }
        public bool IsEmpty()
        {
            return top == 0;
        }
        public int capacity()
        {
            return c.Length;
        }

        public int getnum()
        {
            return top;
        }
    }
    class My
    {
        static void Main(string[] args)
        {
            stack obj = new stack(10);
            
            for(int i=0;  !obj.IsFull(); i++)
            {
                obj.push((char)('A' + i));
               
            }

            stack obj1 = new stack(obj);


            while (!obj.IsEmpty())
            {
                Console.WriteLine(obj.pop());
            }
            Console.WriteLine(" gapo");
            while (!obj1.IsEmpty())
            {
                Console.WriteLine(obj1.pop());
            }
           

           

        }
   
    }


    /*
    class Conversion
    {
        public void Mymeth(int a)
        {
            Console.WriteLine("int type " + a);
        }
        public void Mymeth(double a)
        {
            Console.WriteLine("double type " + a);
        }
        public void Mymeth(byte a)
        {
            Console.WriteLine(" byte type " + a);

        }

        static void Main(string[] args)
        {
            Conversion obj = new Conversion();
            int i = 3;
            double j = 4.9;
            byte a = 23;
            short b = 45;
            float f = 4.5f;

            obj.Mymeth(i);
            obj.Mymeth(j);
            obj.Mymeth(a);
            obj.Mymeth(b);
            obj.Mymeth(f);






        }

    }


    /*
    class Overload
    {
        public void method()
        {
            Console.WriteLine("Hello");
        }
        public int method(int a, int b)
        {
            return a + b;
        }
        public double method(double a , double b)
        {
           
            return a + b;
        }

        static void Main(string[] args)
        {
            Overload obj = new Overload();
        obj.method();
            Console.WriteLine(obj.method(2,3));
            Console.WriteLine(obj.method(4.5, 6.8));
        }


    }




    /*
    class Factor
    {
        public int[] findfactor(int num, out int numfactor)
        {
            int[] facts = new int[80];
            int i, j;

            for(i=2, j=0; i< num/2; i++)
            {
                if (num % i == 0)
                {
                    facts[j] = i;
                    j++;
                }
               
               
            }
            numfactor = j;
            return facts;

        }
    }
    class my
    {
        static void Main(string[] args)
        {

            Factor obj = new Factor();

            int numfactor;
            int[] array;
            array = obj.findfactor(1000, out numfactor);
            for(int i=0; i< numfactor; i++)
            {
                Console.Write(array[i]+ " ");

            }
            Console.WriteLine();

        }
    }

    /*
    class Myclass
    {
        int a;
        int b;
         
        public Myclass factor(int a, int b)
        {
            Myclass obj = new Myclass();
            obj.a = a;
           obj.b = b;

            return obj;
        }
        public void show()
        {
            Console.WriteLine(this.a+ " "+ this.b);
        }

    }
    class My
    {
        static void Main(string[] args)
        {
            Myclass obj = new Myclass();

            obj.show();

           Myclass obj1 = obj.factor(1, 2);
            obj1.show();
            
            obj.show();
        }
    }


    /*
    class ract
    {
        int height;
        int width;
        public ract(int height, int width)
        {
            this.height = height;
            this.width = width;

        }
          public int Area()
        {
            return this.height * this.width;
        }
        public void show()
        {
            Console.WriteLine(height+ " "+width);
        }
        public ract Enlarge(int factor)
        {
            ract abj = new ract(height * factor, width * factor);
            return abj;
        }


    }

    class My
    {
        static void Main(string[] args)
        {

            ract obj = new ract(4, 5);

            obj.show();
            Console.WriteLine(obj.Area());
           ract obj2= obj.Enlarge(2);
            obj2.show();
            Console.WriteLine(obj2.Area());

        }
      
    }

    /*

    class DemoParams
    {
        public void showars(string msg, params int[] array)
        {
            Console.WriteLine(msg);

            foreach(int i in array)
            {
                Console.WriteLine(i);
            }
        }

    }
    
    class My
    {

        static void Main(string[] args)
        {
            DemoParams obj = new DemoParams();
            obj.showars("here is some number", 12, 3, 4, 5, 6, 7, 8, 90);
        }
    }

    /*
    class ParamsDemo
    {
        public int MinVal(params int[] vals)
        {
            int m = int.MaxValue;
            if (vals.Length == 0)
            {
                Console.WriteLine(" there is no min value");
                return 0 ;
            }


            for (int i = 0; i < vals.Length; i++)
            {
                if (vals[i] < m)
                {
                    m = vals[i];
                }


            }
            return m;
        }
    }
    class My
    {
        static void Main(string[] args)
        {
            ParamsDemo obj = new ParamsDemo();

         int a =   obj.MinVal(3, (int) 4.4);
            Console.WriteLine(a);
        }
    }

    /*
    class Reswap
    {
        int a, b;
        public Reswap(int a, int b)
        {
            this.a = a;
            this.b = b;
        }
        public void show()
        {
            Console.WriteLine("a "+a + " b "+b);
        }
        public void swap(ref Reswap obj1, ref Reswap obj2)
        {
            Reswap t;
            t = obj1;
            obj1 = obj2;
            obj2 = t;
        }

    }

    class my
    {
        static void Main(string[] args)
        {
            Reswap obj1 = new Reswap(1, 2);
            Reswap obj2 = new Reswap(3, 4);
            Reswap obj3 = new Reswap(5, 6);


            obj1.show();
            obj2.show();
          

            obj1.swap(ref obj1, ref obj2);
           
           

            obj1.show();
            obj2.show();
            

        }
       
    }

    /*
    class Factor
    {
        public bool FactorDemo(int i, int j,out int x, out int y)
        {
           int max = i< j ? i : j;

            x = 1;
            y = 1;
            bool first = true;

            for(int a=2; a<=max/2 +1; a++)
            {
                if((i%a==0) && (j%a==0)) {
                    if (first)
                    {
                        x = a;
                        first = false;
                    }
                    y = a;

                }
            }
            if(x!= 1)
            {
                return true;
            }else
            {
                return false;
            }


        }
    }


    class My
    {
        static void Main(string[] args)
        {
            Factor obj = new Factor();
            Console.WriteLine("j");
            int x;
            int y;
            int small;
            int large;
            if (obj.FactorDemo(231, 105, out small, out large))
            {
                Console.WriteLine(" there is common small and great common factor "+ small+" "+large);
            }
            else
            {
                Console.WriteLine(" There is no common factor");
            }
            if (obj.FactorDemo(35, 51, out small, out large))
            {
                Console.WriteLine(" there is common small and great common factor " + small + " " + large);
            }
            else
            {
                Console.WriteLine(" There is no common factor");
            }

        }
    }





    /*
    class MyClass
    {
        static void Main(string[] args)
        {
            int x = 105;
            int y = 231;

            int c = x < y ? x : y;

            for(int i=2; i<=c; i++)
            {
                if(x%i==0 && y % i == 0)
                {
                    Console.WriteLine("small common factor x and y "+i);
                    break;
                }
                else
                {
                    continue;

                }
            }
            for(int i=c; i>=2; i--)
            {
                if(x%i==0 && y % i == 0)
                {
                    Console.WriteLine("greatest common factor x and y: " + i);
                    break;
                }
                else
                {
                    continue;
                }
            }
        }
    }

    /*
    class OutDemo
    {
        public int add(double a, out double b)
        {
            int whole;
            whole = (int)a;
            b = a - whole;


            return whole;
        }
    }


    class my
    {
       
        static void Main(string[] args)
        {
            OutDemo obj = new OutDemo();
            double i = 10.125;
            double d;
           int a = obj.add( i, out d);
            Console.WriteLine(a);
            Console.WriteLine(i +"  " +d);




        }
    }
     


    /*
    class RefDemo
    {
       public void swap(ref int a, ref int b)
        {
            int t = a;
            a = b;
            b = t;
           
          
        }

    }

    class My
    {
        static void Main(string[] args)
        {
           
            RefDemo obj  =new RefDemo();
            int a = 10;
            int b = 20;
            Console.WriteLine(a +"     "+b);
            obj.swap(ref a,ref  b);

            Console.WriteLine(a + "    " + b);

        }
    }

    /*
    class RefDemo
    {
        public void add(ref int i)
        {
            i = i * i;
        }

    }
    class MyClass
    {
        static void Main(string[] args)
        {
            RefDemo obj = new RefDemo();
            int a = 6;

            Console.WriteLine(a);
            obj.add( ref a);
            Console.WriteLine(a);



        }
    }





    /*
    class Object
    {
       public  int a;
        public int b;
     public Object()
        {

        }
        public Object(int a, int b)
        {
            this.a = a;
            this.b = b;


        }

        public void  Change(Object ob)
        {
            this.a = ob.a + ob.b;
            this.b = -ob.b;
        }
        public void NoChange(int i, int j)
        {
            i = i + j;
            j = -j;

        }


    }
     class Program
    {
        static void Main(string[] args)
        {
            Object obj = new Object(5,10);

            Console.WriteLine("Before Change "+obj.a+ " "+obj.b);
            obj.Change(obj);
            Console.WriteLine("after change "+obj.a+ " "+obj.b);
            int i = 5;
            int j = 10;
            Console.WriteLine("before change "+i+ " "+j);
            obj.NoChange(i, j);
            Console.WriteLine("After change "+i+" "+j);
        }
    }
    */
}
