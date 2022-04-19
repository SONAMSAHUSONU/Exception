using System;
using System.Collections;
using System.Collections.Generic;
//when is the unwanted or unexpacted event occour during the program execution at the runtime it is know as Exception.
class ExceptionA
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
        List<string> ProductList = new List<string>();
        ProductList.Add("LUX");
        ProductList.Add("Laptop");
        ProductList.Add("Keyboard");
        ProductList.Add("Maush");


        return ProductList;
    }
}
