
namespace Teste{
    class Program{
        static void Main(string[] args){
            Product mouse = new Product(1, "Mouse", 25.0, EProductType.Product);
            Console.WriteLine(mouse.Id);
            Console.WriteLine(mouse.Name);
            Console.WriteLine(mouse.Price);  
            Console.WriteLine(mouse.Type);
            Console.WriteLine((int)mouse.Type);
        
        var manutencao = new Product(2, "Manutenção elétrica Residencial", 500, EProductType.Service);
         Console.WriteLine(manutencao.Id);
            Console.WriteLine(manutencao.Name);
            Console.WriteLine(manutencao.Price);  
            Console.WriteLine(manutencao.Type);
                 
        }
    }
}

struct Product

{
    public int Id;
    public string Name;
    public double Price;
    public EProductType Type;

    public Product(int id, string name, double price, EProductType type){
        Id = id;
        Name = name;
        Price = price;
        Type = type;
    }

    public double PriceInDolar (double dolar){
        return Price * dolar;
    }

}

enum EProductType{
    Product = 1,
    Service = 2
}





