namespace pensumsjekkUke4.Test
{
    public class ShopTest
    {
      
        [Test]
        public void TestAddCar()
        {
            Shop shop = new Shop("Albjerk","Hytti heiti 4");
            Car car = new Car("BMW","BE82745", 2010, 1000);
   
            shop.AddCar(car);
       
            Assert.AreEqual(1, shop.Cars.Count);
            Assert.AreEqual(car, shop.Cars[0]);
        }

        [Test]
        public void TestRemoveCar()
        {
            Shop shop = new Shop("Albjerk", "Hytti heiti 4");
            Car car1 = new Car("BMW", "BE82745", 2010, 1000);
            Car car2 = new Car("Audi", "KJ82745", 2019, 2349);

            shop.AddCar(car1);
            shop.AddCar(car2);

            shop.RemoveCar("KJ82745");

            Assert.AreEqual(1, shop.Cars.Count);
            Assert.AreEqual(car1, shop.Cars[0]);
        }

        [Test]
        public void TestGetCarsByAge()
        {
            Shop shop = new Shop("Albjerk", "Hytti heiti 4");
            Car car1 = new Car("BMW", "BE82745", 2010, 1000);
            Car car2 = new Car("Fiat", "LE82745", 2015, 2349);
            Car car3 = new Car("Toyota", "BE82745", 95, 23456);
            Car car4 = new Car("Audi", "KJ82745", 2019, 4532);

            shop.AddCar(car1);
            shop.AddCar(car2);
            shop.AddCar(car3);
            shop.AddCar(car4);

            List<Car>cars = shop.GetCarsByAge(2012);

            Assert.AreEqual(2, cars.Count);
            Assert.AreEqual(car1, cars[0]);
            Assert.AreEqual(car3, cars[1]);
        }

        [Test]
        public void TestGetCarsByDistance()
        {
            Shop shop = new Shop("Albjerk", "Hytti heiti 4");
            Car car1 = new Car("BMW", "BE82745", 2010, 1000);
            Car car2 = new Car("Fiat", "LE82745", 2015, 2349);
            Car car3 = new Car("Toyota", "BE82745", 95, 23456);
            Car car4 = new Car("Audi", "KJ82745", 2019, 4532);

            shop.AddCar(car1);
            shop.AddCar(car2);
            shop.AddCar(car3);
            shop.AddCar(car4);


            List<Car> cars = shop.GetCarsByDistance(2000);

            Assert.AreEqual(3, cars.Count);
            Assert.AreEqual(car2, cars[0]);
            Assert.AreEqual(car3, cars[1]);
            Assert.AreEqual(car4, cars[2]);
        }
    }
}