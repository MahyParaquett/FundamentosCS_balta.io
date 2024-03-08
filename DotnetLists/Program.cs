namespace DotnetList
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Clear();

            //Declarando um array com 5 posições
            //var meuArray = new int[5]; 
            int[] meuArray = new int[5] { 1, 2, 3, 4, 5 };
            meuArray[0] = 12;

            //percorrendo o array como se eu não soubesse o tamanho dele
            for (int index = 0; index < meuArray.Length; index++)
            {
                Console.WriteLine(meuArray[index]);
            }

            //percorre o array sem precisar colocar o tamanho
            foreach (var item in meuArray)
            {
                Console.WriteLine(item);
            }

            //alterando o array, aqui o arrb é a copia do arr.
            //Se alterar arr ele reflete no arrb
            var arr = new int[4];
            var arrb = arr;

            arr[0] = 23;
            Console.WriteLine(arrb[0]);


        }
    }
}