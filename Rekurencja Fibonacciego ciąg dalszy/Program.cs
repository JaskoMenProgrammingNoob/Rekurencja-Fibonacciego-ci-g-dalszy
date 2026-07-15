class Program
{
    static long Fibo(int n)
    {

        if (n <= 1)
        {
            return 0;
        }
        else if (n <= 2)
        {
            return 1;
        }
        
        


            
        
        return Fibo(n - 1) + Fibo(n - 2);   
    }

    static void Main(string[] args)
    {
        
        
       
        
            for (int i = 4; i <= 22; i++)
            {
            if (i % 2 == 0)
            {

                Console.Write($"{Fibo(i)}" + " ");
            }
            }
            
        

    }
}