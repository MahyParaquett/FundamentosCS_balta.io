class Program
{
    static void Main(string[] args)
    {
       Menu();
    }
    static void Menu(){
        Console.Clear();
        Console.WriteLine("Olá! O que deseja fazer? ");
        Console.WriteLine("1- Soma");
        Console.WriteLine("2- Subtração");
        Console.WriteLine("3- Divisão");
        Console.WriteLine("4- Multiplicação");
        Console.WriteLine("5- Sair");

        Console.WriteLine("-------------------------");
        Console.Write("Digite a opção: ");
        short resposta = short.Parse(Console.ReadLine() ?? "0");

        switch(resposta){
            case 1 : Soma(); break;
            case 2 : Subtracao(); break;
            case 3 : Divisao(); break;
            case 4 : Multiplicacao(); break;
            case 5 : Sair(); break;
            default : Menu(); break;
        }
    }
    static void Soma(){

        Console.Clear();
        Console.WriteLine("Digite o primeiro valor: ");
        float n1 = float.Parse( Console.ReadLine() ?? "0"); //se imput 1 não existit considere 0

       
        Console.WriteLine("Digite o segundo valor: ");
        float n2 = float.Parse(Console.ReadLine() ?? "0");
        
        float resultado = n1 + n2;
    //Opções de concatenação
        Console.WriteLine("O resultado da soma é: " + resultado);
        // Console.WriteLine("O resultado da soma é: " + (n1 + n2));
        // Console.WriteLine($"O resultado da soma é: {resultado}");
        // Console.WriteLine($"O resultado da soma é: {n1+n2}");

         Console.ReadKey(); //evita que ele encerre o programa

         Menu();
    }

    static void Subtracao(){
        Console.Clear();

        Console.WriteLine("Primeiro número:");
        float n1 = float.Parse(Console.ReadLine() ?? "0");

        Console.WriteLine("Segundo número:");
        float n2 = float.Parse(Console.ReadLine() ?? "0");

        Console.WriteLine("");

        float resultado = n1-n2;

        Console.WriteLine($"O resultado da subtração é {resultado}");
        Console.ReadKey(); //evita que ele encerre o programa

        Menu();
    }

    static void Divisao(){
        Console.Clear();

        Console.WriteLine("Primeiro número:");
        float n1 = float.Parse(Console.ReadLine() ?? "0");

        Console.WriteLine("Segundo número:");
        float n2 = float.Parse(Console.ReadLine() ?? "0");

        Console.WriteLine("");

        float resultado = n1/n2;

        Console.WriteLine($"O resultado da divisão é {resultado}");
        Console.ReadKey(); //evita que ele encerre o programa

         Menu();
    }

    static void Multiplicacao(){
        Console.Clear();

        Console.WriteLine("Primeiro número:");
        float n1 = float.Parse(Console.ReadLine() ?? "0");

        Console.WriteLine("Segundo número:");
        float n2 = float.Parse(Console.ReadLine() ?? "0");

        Console.WriteLine("");

        float resultado = n1*n2;

        Console.WriteLine($"O resultado da multiplicação é {resultado}");
        Console.ReadKey(); //evita que ele encerre o programa
        Menu();
    }

    static void Sair(){
        Console.WriteLine("Obrigada por usar nosso sitema!");
        System.Environment.Exit(0); //Para sair do programa sem erro
    }

}



   
