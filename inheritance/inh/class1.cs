public class class1
{
    public void method1()
    {

        Console.WriteLine("first");
    }
    public void method2()
    {
        Console.WriteLine("secound");
    }

}

public class class2 : class1
{
    public void test3()
    {
        Console.WriteLine("method 3");


    }

    class pro
    {

        static void Main(string[] args)
        {
            class2 c = new class2();
            c.method1();
            c.method2();
            c.test3();

            Console.ReadLine();




        }
    }
}






