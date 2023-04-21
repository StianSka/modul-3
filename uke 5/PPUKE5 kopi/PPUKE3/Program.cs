// See https://aka.ms/new-console-template for more information


using System.Diagnostics.SymbolStore;

namespace PPUKE3
{

    class Program
    {


        public static void Main(string[] args)
        {

            var shirt = new ClothingItem("svart", 100, "Big ass Black Shirt", 4, 49.99);
            var phone = new ElectronicItem("2 år", 750, "doro telefon", 2, 999.99);
            var food = new Food("Burger", "Big Burger", 5, 20.99);
            var list = new List<ISellable>() { shirt, phone, food };
            

            foreach (var item in list)
            {
                
                Console.WriteLine(item.ItemDetails());
                Console.WriteLine(item.CalculatePrice());
            }

            

        }


    }





}

