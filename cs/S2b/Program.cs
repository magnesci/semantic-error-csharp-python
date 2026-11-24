Console.WriteLine("START");
Program.Calc();
Program.Calc(10);

partial class Program
{
    static void Calc() { Console.WriteLine("No param"); }
    static void Calc(int x) { Console.WriteLine(x); }
}