namespace EditorHtml
{
    public static class Menu{

        public static void Show(){
            Console.Clear();
            Console.BackgroundColor = ConsoleColor.Magenta;
            Console.ForegroundColor = ConsoleColor.Black;

            DrawScreen();
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

    } 


}