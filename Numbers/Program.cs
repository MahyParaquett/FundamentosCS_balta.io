using System.Globalization;

namespace Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Clear();

            decimal valor = 10548315.25m;

            //Arredondar o valor
            Math.Round(valor);

            //Arredonda pra cima
            Math.Ceiling(valor);

            //Arredondar para baixo
            Math.Floor(valor);
        }
    }
}
