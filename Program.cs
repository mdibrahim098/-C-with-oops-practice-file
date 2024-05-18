using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Book_nPractice5
{





    /*
    class My
    {
        public int FindMin(int[] nums)
        {
            int low = 0;
            int high = nums.Length - 1;
            int min = int.MinValue;
            while (high >= low)
            {
                int mid = (high + low) / 2;
                if (nums[low] < nums[mid])
                {
                    min = Math.Min(min, nums[low]);
                    low = mid + 1;
                }
                else
                {
                    min = Math.Min(min, nums[mid]);
                    high = mid - 1;
                }
            }
            return min;
        }
    }
    /*
    
    class my
    {
        public bool SearchMatrix(int[,] matrix, int target)
        {
            int row = matrix.GetLength(0);
            Console.WriteLine(row);
            
            int col = matrix.GetLength(1);
            Console.WriteLine(col);
            int left = 0;
            int right = row *  col-1;
            while (right >= left)
            {
                int mid = (right + left) / 2;

                if (matrix[mid/col,mid%col] == target)
                {
                    return true;
                }
               if (matrix[mid/col, mid % col] > target)
                {
                    right = mid - 1;
                }
                if (matrix[mid / col, mid % col] < target)
                {
                    left = mid +1;
                }
            }

            return false;

        }
        public static void Main(String[] args)
        {
            my obj = new my();

            int[,] matrix = { { 1, 3, 5, 7 }, { 10, 11, 16, 20 }, { 23, 30, 34, 60 } };
            int target = 3;
            Console.WriteLine(obj.SearchMatrix(matrix, target));
        }
    }

        /*
        class Boxing
        {
            static void Main(string[] args)
            {
                Object[] ga = new object[10];
                for(int i=0; i<3; i++)
                {
                    ga[i] = i;
                }
                for(int i=3; i<6; i++)
                {
                    ga[i] = (double)i / 2;
                }
                ga[6] = "string";
                ga[7] = true;
                ga[8] = 'A';
                ga[9] = "end";
                for(int i=0; i<10; i++)
                {
                    Console.WriteLine(ga[i]);
                }
            }
        }

        /*
       class Myclass
        {
            static int count = 0;
                int id;
             public Myclass()
            {
                id = count;
                count++;
            }

            public override string ToString()
            {
                return base.ToString();
            }
        }
        class My
        {
            static void Main(string[] args)
            {
                Myclass obj = new Myclass();
               Console.WriteLine(obj.ToString());
            }         
        }


        /*
      abstract class TwoDShape
        {
            double pri_width;
            double pri_height;

            public TwoDShape()
            {
                Width = Height = 0;
                     this.name = "null";
            }
            public TwoDShape(double pri_width, double pri_height, string name)
            {
              this.Width = pri_width;
                this.Height= pri_height;
                this.name = name;

            }
            public TwoDShape (double x , string n)
            {
                this.Width = this.Height = x;
                this.name = n;

            }
            public TwoDShape(TwoDShape ob)
            {
                this.Width = ob.Width;
                this.Height = ob.Height;
                this.name = ob.name;
            }

            public double Width
            {
                get
                {
                    return pri_width;

                }
                set
                {
                    pri_width = value;
                }
            }
            public double Height
            {
                get
                {
                    return pri_height;
                }
                set
                {
                    pri_height = value;
                }
            }
            public string name
            {
                get;set;
            }
            public void showDim()
            {
                Console.WriteLine(" Width " + this.Width + " Height " + this.Height);
            }
            public abstract  double Area();


        }

      class Triangle : TwoDShape
        {
            string style;
            public Triangle()
            {
                this.style = "null";
            }

            public Triangle(string style, double height, double width): base(height, width, " triangle")
            {
                this.style = style;
            }
            public Triangle(double x) : base(x, " triangle")
            {
                this.style = " isosceles";
            }

            public Triangle(Triangle ob): base(ob) 
            {
                this.style = ob.style;
            }

            public override double Area()
            {
                return Height * Width / 2;
            }
            public void ShowStyle()
            {
                Console.WriteLine(" Triangle is " + style);
            }
            class Rectangle : TwoDShape
            {

                public Rectangle(double Height, double Width) : base(Width, Height, " Rectangle")
                {


                }
                public Rectangle(double x): base(x, "rectangle")
                {

                }
                public Rectangle(Rectangle ob): base(ob)
                {

                }
                public bool IsSqure()
                {
                    if (Width == Height) return true;
                    return false;
                }
                public override double Area()
                {

                        return Width * Height;

                }

            }

            class My
            {

                static void Main(string[] args)
                {
                    TwoDShape[] obj = new TwoDShape[4];

                    obj[0] = new Triangle("right", 8.0, 12.0);
                    obj[1] = new Rectangle(10);
                    obj[2] = new Rectangle(10, 4);
                    obj[3] = new Triangle(7.0);


                    for(int i=0; i<obj.Length; i++)
                    {
                        Console.WriteLine("object " + obj[i].name);
                        Console.WriteLine("Area " + obj[i].Area());

                        Console.WriteLine();
                    }
                }


            }



        }


        /*
         class A { 
     public virtual  void method()
            {
                Console.WriteLine(" A");
         }
        }
        class B :A
        {
          public override void method()
            {
                Console.WriteLine(" B");
            }


        }

         class My
        {
           static void Main(string[] arg) {
                A objA = new A();
                B objB = new B();   
                A objAB = new B();
                 objA.method();
                objB.method();
                objAB.method();



    }
        }

        /*
        class Base
        {
            int i;
            public virtual void who()
            {
                Console.WriteLine(" base");
            }
            public virtual int Prop
            {
                get { return i; }
                set { i = value; }
            }
            public void show()
            {
                Console.WriteLine(" base "+i);
            }
        }
        class A : Base
        {
            public override void who()
            {
                Console.WriteLine(" A");
                base.Prop = 49;
                Console.WriteLine(base.Prop);
            }
            public override int Prop
            {
                get { return base.Prop; }
                set { base.Prop = value; }
            }
        }
        class My
        {
            static void Main(string[] args)
            {

                    Base obj = new A();
                    Console.WriteLine(obj.Prop);
                obj.Prop = 2;
                Console.WriteLine(obj.Prop);
            }
        }



          /*
        class A
        {
            int i;
             public A(int i)
            {
                this.i = i; 
            }
            public void method()
            {
                Console.WriteLine(" ");
            }
        }
        class B :A
        {
            int i;
            public B(int i, int j) 
            : base(j)
            { 
            this.i = i;
            }

            public void method()
            {
                Console.WriteLine();
            }
        }
        class My
        {
            static void Main(string[] args)
            {
                A obj = new B(1,2);
        }

        /*
        class A
        {
            int height;
            int width;
            public A(int height, int width) {
                this.height = height;
                this.width = width;
                Console.WriteLine(" First");
            }

             public int Height
            {
                get
                {
                    return height;
                }
                set
                {
                    this.height = value;

                }
            }
            public int Width
            {
                get
                {
                    return width;

                }
                set
                {
                    this.width= value;
                }
            }

            public void show()
            {
                Console.WriteLine("height "+height+ " width "+width);
            }
        }
        class B : A
        {
            int a, b;

            public B(int a, int b, int height, int width) : base(height, width)
            {

                this.a = a;
                this.b = b;
                Console.WriteLine("second");

            }


            public int i
            {
                get
                {
                    return a;
                }
                set
                {
                    this.a = value;
                }
            }
            public int j
            {
                get
                {
                    return b;
                }
                set
                {
                    this.b = value;
                }
            }
            public void showB()
            {
                Console.WriteLine("A "+a + " B "+b);

            }

        }
        class C : B
        {
            string style;

             public C(string style, int a,int b, int c, int d): base(a, b, c,d)
            {
                Console.WriteLine("third");
                this.style = style;
                base.showB();
                base.show();
            }




        }


        class My
        {
            static void Main(string[] args)
            {
                Console.WriteLine(" A Part");
                A obj = new A(3,6);
                obj.show();

                obj.Height = 10;
                Console.WriteLine(obj.Height);

                obj.Width = 20;
                Console.WriteLine(obj.Width);
                obj.show();
                Console.WriteLine(" B part ");
                B objB = new B(1,2,3,4);
                objB.show();
                objB.showB();
                objB.i = 500;
                objB.j = 1000;
                objB.showB();
                Console.WriteLine(" part C");
                C obj2 = new C("Hello", 1,2,3,4);


            }
        }

        /*
        class A
        {
           public int i = 0;
           public void method()
            {
                Console.WriteLine("hello A" +i);
            }

        }
        class B: A
        {
            new public  int i;
            public B(int i)
            {
                this.i = i;
                base.i = i; 
            }
          public void method()
            {
                Console.WriteLine("Hello B");
                base.method();  
            }

        }

        class Program
        {
            static void Main(string[] args)
            {
                B obj = new B(2);
                Console.WriteLine(obj.i);
                obj.method();
                A obj1 = new A();
                obj1.method();
            }
        }
        */

    }
