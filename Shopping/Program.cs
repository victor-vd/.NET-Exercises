using Models;
using Newtonsoft.Json;

namespace Shopping;

class Program
{
    static void Main(string[] args)
    {
        string lines = "";

        try
        {
            lines = File.ReadAllText("./Data/Clients.json");
        }
        catch (FileNotFoundException)
        {
            Console.WriteLine("File \"Clients.json\" not found");
        }
        catch (DirectoryNotFoundException)
        {
            Console.WriteLine("Path \"./Data/Clients.json\" not found");
        }
        finally
        {
            Console.WriteLine("The file \"Clients.json\" in the path \"./Data/Clients.json\" was found sucessfully");
        }

        List<Product> products = new List<Product>{
            new Product(13574134, 122.99, 40.80, "Peristaltic Pump"),
            new Product(28493021, 59.99, 20.50, "Stainless Steel Water Bottle"),
            new Product(59438219, 899.00, 650.00, "Wireless Noise-Cancelling Headphones"),
            new Product(98347213, 29.99, 10.00, "Ergonomic Mouse Pad"),
            new Product(47293184, 1499.99, 1050.75, "4K Ultra HD Smart TV"),
            new Product(38109234, 79.99, 35.00, "Bluetooth Speaker"),
            new Product(65782034, 49.99, 25.00, "Smart LED Light Bulb"),
            new Product(91457382, 249.99, 180.00, "Smartwatch with GPS and Heart Monitor")
        };

        string serializedProducts = JsonConvert.SerializeObject(products, formatting: Formatting.Indented);
        List<Client> clients = JsonConvert.DeserializeObject<List<Client>>(lines) ?? new List<Client>();

        File.WriteAllText("./Data/Products.json", serializedProducts);

        Console.WriteLine(serializedProducts);

        foreach (Client client in clients)
        {
            Console.WriteLine(client);
        }
    }
}
