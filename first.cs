using System;

delegate void MessageDelegate();

class DelegateExample
{
    static void SayHello()
    {
        Console.WriteLine("Hello, World!");
    }

    static void Main()
    {
        MessageDelegate message = SayHello;
        message();
    }
}

