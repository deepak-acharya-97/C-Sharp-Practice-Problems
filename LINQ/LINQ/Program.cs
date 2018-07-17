using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LINQ
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Car> cars = new List<Car>()
            {
                new Car {VIN="A1",Make="BMW",Model="550i",StickerPrice=58000},
                new Car {VIN="B1",Make="Toyota",Model="559i",StickerPrice=33000},
                new Car {VIN="C1",Make="BMW",Model="540i",StickerPrice=75000},
                new Car {VIN="D1",Make="Ford",Model="Escape",StickerPrice=25000},
                new Car {VIN="E1",Make="BMW",Model="50i",StickerPrice=59000},
            };
            var bmws = from car in cars
                       where car.Make == "BMW"
                       select car;
            var bmwsm = cars.Where(p => p.Make == "BMW");
            foreach (var bmw in bmwsm)
            {
                Console.WriteLine(bmw.VIN);
            }
            Console.ReadLine();
        }
    }
    class Car
    {
        public string VIN { get; set; }
        public string Make { get; set; }
        public string Model { get; set; }
        public int StickerPrice { get; set; }
    }
}
