using System;

namespace ex2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Informe seu salário em R$:");
            double payment = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Informe a porcentagem de reajuste:");
            double readjustment = Convert.ToDouble(Console.ReadLine());
            double finalreadjustment = readjustment / 100;

            double finalpayment = payment + (payment * finalreadjustment);
            finalpayment = Math.Round(finalpayment, 2);
            Console.WriteLine($"O seu reajust é de {finalpayment}");

        }
    }
}
