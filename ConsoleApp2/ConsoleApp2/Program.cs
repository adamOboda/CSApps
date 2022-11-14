using System;
//multi interfejsy
interface IFirstInterface
{
    void myMethod();
}

interface ISecondInterface
{
    void myOtherMethod();
}


// implementacja interfejsów

class DemoClass : IFirstInterface, ISecondInterface
{
    public void myMethod()
    {
        Console.WriteLine("Some text");
    }

    public void myOtherMethod()
    {
        Console.WriteLine("Some other text");
    }
}

class Program
{
    static void Main(string[] args)
    {
        DemoClass demo = new DemoClass();
        demo.myMethod();
        demo.myOtherMethod();
    }
}