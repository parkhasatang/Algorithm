class Program
{
    static void Main(string[] args)
    {
        int num = int.Parse(Console.ReadLine());
        
        for(int i = 0; i < num; i++)
        {
            for(int j = 0; j < i; j++)
            {
                Console.Write(" ");
            }
            
            for(int k = num-i; k > 0; k--)
            {
                Console.Write("*");
            }
            
            Console.WriteLine();
        }
    }
}