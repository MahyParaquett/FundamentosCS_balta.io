class Program{
        static void Main(string[] args){
            //GUIDS
            //gera  um rash novo
            var id = Guid.NewGuid();

            //Posso passar um guid para uma string
            id.ToString();

            //Crio um guid de acordo  com a string que eu quero
            id = new Guid("f469c738-1639-4b3b-87dd-430b190ac926");

            Console.WriteLine(id);
        }

}