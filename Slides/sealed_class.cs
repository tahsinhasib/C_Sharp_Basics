using System;

public sealed class A
{
    public void Method()
    {
        Console.WriteLine("Sealed Class!");
    }
}


public class B : A                  //compilation error!
{
    public void Method()
    {
        Console.WriteLine("Cannot Derived!");
    }
}