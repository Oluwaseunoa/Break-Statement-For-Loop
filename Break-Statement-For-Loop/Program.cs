class Program
{

    static void Main()
    {
        int pass = 5;
        //for loop: 0-9
        for (int i = 0; i < 10; i++)
        {
            if(i == pass)
            {
                break;
            }
            System.Console.WriteLine(i);
        }
        System.Console.ReadKey();
    }
}