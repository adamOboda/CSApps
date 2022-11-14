static void checkAge(int age)
{
    if (age < 18)
    {
        throw new ArithmeticException("Access denied - you need to be at least 18 years old");
    }
    else
    {
        Console.WriteLine("Access granted - you are old enough"); 
    }
}

static void Main(string[] args)
{
    checkAge(15);
}