using System.Text.RegularExpressions;

namespace EditorHtml
{
    public static class Viewer{

        public static void Show(string text){
            Console.Clear();
            Console.BackgroundColor = ConsoleColor.Black;
            Console.ForegroundColor= ConsoleColor.DarkMagenta;
            Console.Clear();
            Console.WriteLine("MODO VISUALIZAÇÃO");
            Console.WriteLine("--------------");
            Replace(text);
            Console.ForegroundColor= ConsoleColor.DarkMagenta;
            Console.WriteLine("--------------"); 
            Console.WriteLine("Pressione qualquer tecla para voltar ao menu");
            Console.ReadKey();
            Menu.Show();
        }

        public static void Replace(string text){

            //Pega tudo que tiver entre as tags do strong
            var strong = new Regex(@"<\s*strong[^>]*>(.*?)<\s*/\s*strong>");
            var words = text.Split(' '); //sepanando as palavras por espaço

            for (int i = 0; i < words.Length; i++) 
            {
                //Se a palavra atual esta entre uma tag de strong
                if(strong.IsMatch(words[i])){
                    Console.ForegroundColor = ConsoleColor.Blue;
                    Console.Write(
                        words[i].Substring(
                            words[i].IndexOf('>') + 1,
                            words[i].LastIndexOf('<')-1 - words[i].IndexOf('>')
                            
                        )
                    );

                    Console.Write(" ");
                }else{
                    Console.ForegroundColor = ConsoleColor.Black;
                    Console.Write(words[i]);
                    Console.Write(" ");
                }
            }
        }

        
    
    }
}