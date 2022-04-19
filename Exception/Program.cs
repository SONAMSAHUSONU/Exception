/*using System;
using System.Collections;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        Console.WriteLine("begin");
        List<string> product = GetProductList();
        int number = 100;
        number = number / 0;
        foreach (var item in product)
        {
            Console.WriteLine(item);
        }

        Console.ReadLine();
    }

    public static List<string> GetProductList()
    {
        List<string> productList = new List<string>();
        productList.Add("Lux");
        productList.Add("laptop");
        productList.Add("Keybord");
        productList.Add("mouse");
        return productList;
    }
}*/

//Eception  
/*
using System;
using System.Collections;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        Console.WriteLine("start");
        Console.WriteLine("How are You");
        int number = 100;
        number = number / 0;
        Console.WriteLine("End");
        Console.ReadLine();

    }
} */


/*
using System;
using System.Collections;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        string name = "india";
        int lenth = name.Length;
        Console.WriteLine(lenth);
        Console.ReadLine();

    }
} */


/*
using System;
using System.Collections;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        string name = null;
        int lenth = name.Length;
        Console.WriteLine(lenth);
        Console.ReadLine();

    }
} */

/*
using System;
using System.Collections;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        string name = null;
        bool lenth = name.StartsWith("abc");
        Console.WriteLine(lenth);
        Console.ReadLine();

    }
} */


/*
using System;
using System.Collections;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        int[] arr = new int[5] { 10, 20, 30, 40, 50 };
        Console.WriteLine(arr[4]);
        Console.ReadLine();
    }
} */

/*
using System;
using System.Collections;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        int[] arr = new int[5] { 10, 20, 30, 40, 50 };
        Console.WriteLine(arr[10]);
        Console.ReadLine();
    }
} */
/*
using System;
using System.Collections;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        string[] name = new string[5];
        name[0] = "banglore";
        name[1] = "bhopal";
        name[2] = "jabalpur";
        name[3] = "manglore";
        name[4] = "HYD";
        Console.WriteLine(name[2]);
        Console.ReadLine();
    }
} */

/*
using System;
using System.Collections;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        string[] name = new string[5];
        name[0] = "banglore";
        name[1] = "bhopal";
        name[2] = "jabalpur";
        name[3] = "manglore";
        name[4] = "HYD";
        Console.WriteLine(name[5]);
        Console.ReadLine();
    }
} 
*/
/*
using System;
using System.Collections;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        Console.WriteLine("enter your age");
        string message = Console.ReadLine();
        int age = Int32.Parse(message);
        Console.WriteLine("Hey");

        Console.ReadLine();
    }
} 
*/
/*
using System;
using System.Collections;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        int number = 786;
        Object obj = number;

        int num = (short)obj;
    }
}
*/
/*
using System;//namspace
using System.Collections;
public class Employee
{
    public static void Main()
    {
        Console.WriteLine("main begin");
        try
        {
            Console.WriteLine("try begin");
            int i = 100;
            int j = i / 0;
            Console.WriteLine("try end");
        }
        catch (DivideByZeroException ex)
        {
            Console.WriteLine(" i am from catch block");
        }
        Console.WriteLine("main end");

        Console.ReadLine();
    }
}*/
/*
using System;//namspace
using System.Collections;
public class Employee
{
    public static void Main()
    {
        Console.WriteLine("main begin");
        try
        {
            string name = null;
            name.IndexOf('a');
            Console.WriteLine("try end");
        }
        catch (NullReferenceException ex)
        {
            Console.WriteLine(" i am from catch block");
        }
        Console.WriteLine("main end");

        Console.ReadLine();
    }
}
  */

/*
using System;//namspace
using System.Collections;
public class Employee
{
    public static void Main()
    {
        Console.WriteLine("main begin");
        try
        {
            int[] arr = new int[4] { 10, 20, 30, 40 };
            arr[4] = 101;
            Console.WriteLine("try end");
        }
        catch (IndexOutOfRangeException ex)
        {
            Console.WriteLine(" i am from catch block");
        }
        Console.WriteLine("main end");

        Console.ReadLine();
    }
}
  */
/*
using System;//namspace
using System.Collections;
public class Employee
{
    public static void Main()
    {
        Console.WriteLine("main begin");
        try
        {
            Console.WriteLine("please enter the excption name ?");
            string exception = Console.ReadLine();
            if (exception == "IndexOutOfRangeException")
            {
                int[] arr = new int[4] { 10, 20, 30, 40 };
                try
                {
                    arr[8] = 200;
                }
                catch (IndexOutOfRangeException ex)
                {
                    Console.WriteLine("IndexOutOfRangeException");
                }
            }


            else if (exception == "NullReferenceException")
            {
                string name = null;
                try
                {
                    int len = name.Length;
                }
                catch (NullReferenceException ex)
                {
                    Console.WriteLine("NullReferenceException");
                }

            }



            else if (exception == "DivideByZeroException")
            {
                string name = null;
                try
                {
                    int number = 100;
                    int i = number / 0;
                }
                catch (DivideByZeroException ex)
                {
                    Console.WriteLine("DivideByZeroException");
                }

            }
            else
            {
                Console.WriteLine("please enter the valid exception");
            }
        }
        catch (IndexOutOfRangeException ex)
        {
            Console.WriteLine(" i am from catch block");
        }
        Console.WriteLine("main end");

        Console.ReadLine();
    }
}*/
 /*
using System;//namspace
using System.Collections;
public class Employee
{
    public static void Main()
    {
        try
        {
            //int number = 100;
            //int som = number /0;

            //string name = null;
            //int len = name.Length;


            int[] arr = new int[4] { 10, 30, 30, 50 };
            int j = arr[10];
        }
        catch (DivideByZeroException ex)
        {
            Console.WriteLine("DivideByZeroException");
        }

        catch (NullReferenceException ex1)
        {
            Console.WriteLine("NullReferenceException");
        }
        catch (IndexOutOfRangeException ex)
        {
            Console.WriteLine("IndexOutOfRangeException");
        }

        Console.ReadLine();
    }
}
  */

 /*
using System;//namspace
using System.Collections;
public class Employee
{
    public static void Main()
    {
        try
        {
            //int number = 100;
            //int som = number /0;

            //string name = null;
            //int len = name.Length;


            int[] arr = new int[4] { 10, 30, 30, 50 };
            int j = arr[10];
        }
        catch (Exception ex)
        {
            Console.WriteLine(ex.ToString());
        }



        Console.ReadLine();
    }
}
 */ 

 


/*
using System;//namspace
using System.Collections;
public class Employee
{
    public static void Main()
    {
        try
        {
            int number = 100;
            int som = number / 0;

            string name = null;
            int len = name.Length;


            int[] arr = new int[4] { 10, 30, 30, 50 };
            int j = arr[10];
        }
        catch (DivideByZeroException ex)
        {
            Console.WriteLine("DivideByZeroException");
        }

        catch (NullReferenceException ex1)
        {
            Console.WriteLine("NullReferenceException");
        }
        catch (IndexOutOfRangeException ex)
        {
            Console.WriteLine("IndexOutOfRangeException");
        }
        catch (Exception EX)
        {
            Console.WriteLine(EX.ToString());
        }

        Console.ReadLine();
    }
}*/
/*
using System;//namspace
using System.Collections;
using System.Data.SqlClient;
using System.Collections.Generic;
public class Employee
{
    public static void Main()
    {
        try
        {
            int number = 100;
            int som = number / 0;

            string name = null;
            int len = name.Length;


            int[] arr = new int[4] { 10, 30, 30, 50 };
            int j = arr[10];
        }

        catch (NullReferenceException ex)
        {

        }
        catch (SqlException ex)
        {

        }
        catch (Exception ex)
        {

        }
        Console.ReadLine();
    }
}*/