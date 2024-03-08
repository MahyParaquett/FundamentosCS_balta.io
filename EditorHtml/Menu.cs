namespace EditorHtml
{
    public static class Menu{

        public static void Show(){
            Console.Clear();
            Console.BackgroundColor = ConsoleColor.Magenta;
            Console.ForegroundColor = ConsoleColor.Black;

            DrawScreen();
            WriteOptions();

            var option = short.Parse(Console.ReadLine() ?? "0");
            HandleMenuOption(option);
        }

        public static void DrawScreen(){
            Linha();
            Coluna();
            Linha();
        }

        public static void Linha(){
            Console.Write("+");
            for (int i = 0; i <= 30; i++)
            {
                Console.Write("-");
            }
            Console.Write("+");
            Console.Write("\n"); //pula uma linha
        }

        public static void Coluna(){
            for (int lines = 0; lines <= 10; lines++)
                        {
                            Console.Write("|");
                            for (int i = 0; i <= 30; i++)
                            {
                                Console.Write(" ");
                            }
                            Console.Write("|");
                            Console.Write("\n");
            }
        }

        public static void WriteOptions(){
            Console.SetCursorPosition(3,2); //move o cursor para linha 2 coluna 3 
            Console.WriteLine("Editor HTML");
            Console.SetCursorPosition(3,3);
            Console.WriteLine("================");
            Console.SetCursorPosition(3,4);
            Console.WriteLine("Selecione uma opção abaixo");
            Console.SetCursorPosition(3,6);
            Console.WriteLine("1- Novo arquivo");
            Console.SetCursorPosition(3,7);
            Console.WriteLine("2- Abrir");
            Console.SetCursorPosition(3,9);
            Console.WriteLine("0- Sair");
            Console.SetCursorPosition(3,10);
            Console.WriteLine("Opção: ");
            Console.SetCursorPosition(9,10);
        }

        public static void HandleMenuOption(short option){

            switch(option){
                case 1 : Editor.Show(); break;
                case 2 : Viewer.Show(""); break;
                case 0 : {
                    Console.Clear();
                    Environment.Exit(0);
                    break;
                }
                default: Show();break;
            }
        }

        


    } 


}