namespace DotnetList
{
    class Program
    {
        static void Main(string[] args)
        {
            var arr = new int[3];

            try
            {
                // for (int i = 0; i < 10; i++)
                // {
                //     //IndexOutOfRangeException
                //     Console.WriteLine(arr[i]);
                // }

                Salvar(" ");
            }
            catch (IndexOutOfRangeException e)
            {
                Console.WriteLine(e.InnerException);
                Console.WriteLine(e.Message);
                Console.WriteLine("Não encontrei o índice da lista :(");

            }
            catch (ArgumentNullException ex)
            {
                Console.WriteLine(ex.InnerException);
                Console.WriteLine(ex.Message);
                Console.WriteLine("Falha ao cadastrar texto!");
            }
            catch (MinhaException ex)
            {
                Console.WriteLine(ex.InnerException);
                Console.WriteLine(ex.Message);
                Console.WriteLine(ex.QuandoAconteceu);
                Console.WriteLine("Falha ao cadastrar texto!");
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.InnerException);
                Console.WriteLine(ex.Message);
                Console.WriteLine("Ops, algo deu errado!");
            }
            finally
            {
                Console.WriteLine("Chegou ao fim!");
            }
        }

        private static void Salvar(string texto)
        {
            if (string.IsNullOrEmpty(texto))
            {
                // throw new ArgumentNullException("O texto não pode ser nulo ou vazio");
                throw new MinhaException(DateTime.Now);
            }
        }

        // : estende a classe de exception
        public class MinhaException(DateTime date) : Exception
        {
            public DateTime QuandoAconteceu { get; set; } = date;

        }
    }
}