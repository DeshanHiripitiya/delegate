using System;

delegate int OperationDelegate(int x, int y);

class DelegateExample
{
    static int Add(int a, int b)
    {
        return a + b;
    }

    static int Multiply(int a, int b)
    {
        return a * b;
    }

    static void Main()
    {
        OperationDelegate operation = Add;
        int result = operation(5, 3);
        Console.WriteLine("Addition Result: " + result);

        operation = Multiply;
        result = operation(5, 3);
        Console.WriteLine("Multiplication Result: " + result);
    }
}

