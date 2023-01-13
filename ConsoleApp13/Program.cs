namespace ConsoleApp13
{
    internal class Program
    {
        //TODO: Daha çook iş var. 
        static void Main(string[] args)
        {                            
            Program p=new Program();
            p.func1();
        }
        public void func1()
        {
            for (int i = 0; i < 100; i++)
            {
                Console.WriteLine(i);
                System.Threading.Thread.Sleep(2000);
                if(i == 8)
                {
                    System.Diagnostics.Debugger.Launch();
                }

            }
        }
    }
}