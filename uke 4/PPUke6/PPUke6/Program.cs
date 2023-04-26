namespace PPUke6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var car = new Car("NF123456", 147, 200, "grønn");
            car.PrintInfo();
            var car2 = new Car("NF654321", 150, 195, "blå");
            car2.PrintInfo();
            var plane = new AirCraft("LN1234", 1000, 30, 2, 10);
            var boat = new Boat("ABC123", 100, 30, 500);
            Car car3 = car2;

            Console.WriteLine(car.Equals(car2) ? "Er samme bil" : "Er ikke samme bil");
            plane.PrintInfo();
            plane.Run();
            car.Run();
            boat.PrintInfo();
           


            
            //Console.WriteLine(object.ReferenceEquals(car2, car3) ? " 2 og 3 er samme bil" : "2 og 3 er ikke samme bil");


        }
    }
}