namespace task2
{
    class Program
    {
        static void Main(string[] args)
        {
            Start start = new Start(new UnitOfWork());
            start.Go();
        }
    }
}