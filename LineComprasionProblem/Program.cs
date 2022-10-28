using System;
 namespace LineComprasionProblem
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the line comparision problrm statement");
            LineComp line = new LineComp(3, 4, -2, 3);
            line.Calculate();
        }
    }
}
