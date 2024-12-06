using System;

class Program
{
    static void Main()
    {
            MyFrac frac1 = new MyFrac(3, 4);  
            MyFrac frac2 = new MyFrac(5, 6);  
            Console.WriteLine($"Fraction 1: {frac1}");
            Console.WriteLine($"Fraction 2: {frac2}");

            MyFrac sum = frac1 + frac2;
            Console.WriteLine($"Sum: {sum} With Int Part: {sum.ToStringWithIntPart()}");

            MyFrac difference = frac1 - frac2;
            Console.WriteLine($"Difference: {difference} With Int Part: {difference.ToStringWithIntPart()}");

            MyFrac product = frac1 * frac2;
            Console.WriteLine($"Product: {product} With Int Part: {product.ToStringWithIntPart()}");

            MyFrac divide = frac1 / frac2;
            Console.WriteLine($"Quotient: {divide} With Int Part:  {divide.ToStringWithIntPart()}");

            Console.WriteLine($"Fraction 1 as double: {frac1.ToDouble()}");
            Console.WriteLine($"Fraction 2 as double: {frac2.ToDouble()}");

            int n = 5;
            MyFrac seriesSum = MyFrac.CalcSum(n);
            Console.WriteLine($"Sum of series (1 to {n}): {seriesSum} With Int Part: {seriesSum.ToStringWithIntPart()}");

            MyFrac seriesProduct = MyFrac.CalcSum2(n);
            Console.WriteLine($"Product of series (1 to {n}): {seriesProduct} With Int Part: {seriesProduct.ToStringWithIntPart()}d");
        
     
    }
}
