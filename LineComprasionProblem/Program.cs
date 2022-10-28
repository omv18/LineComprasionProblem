using System;
 namespace LineComprasionProblem
{
    class Program
    {
        static void Main(string[] args)
        {
            double firstLine , secondLine;
            Console.WriteLine("Welcome to the line comparision problrm statement");
            LineComp line = new LineComp(3, 4, -2, 3);
            firstLine = line.Calculate();
            LineComp line1 = new LineComp(1, 2, 3, 4);
            secondLine = line1.Calculate();

            //UC-2
            if (firstLine.Equals(secondLine))
            {
                Console.WriteLine("Two lines are Equal");
            }
            else
            {
                Console.WriteLine("Two lines are Not equal");
            }
            //UC3
            int val = firstLine.CompareTo(secondLine);
            Console.WriteLine(val + "  " + firstLine +"  "+secondLine);
            if (val==0)
            {
                Console.WriteLine("line one is Equal");
            }
            if(val == 1)
            {
                Console.WriteLine("Line one is Greater");
            }
            else
            {
                Console.WriteLine("Line one is Smaller");
            }
        }
    }
}
