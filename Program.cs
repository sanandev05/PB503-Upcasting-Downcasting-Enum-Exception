namespace PB503_Upcasting_Downcasting_Enum__Exception
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //TASK 1
            Room room = new Room("Room 1", 1200, 7);
            Room room2 = new Room("Room 2", 1000, 5);

            Hotel hotel = new Hotel("JW Marriot");
            room.IsAvailable =false;
            hotel.AddRoom(room);
            hotel.AddRoom(room2);
            
            try
            {
                hotel.MakeReservation(1);
            }
            catch (NotAvailableException e)
            {
                Console.WriteLine(e.Message);
            }
            catch (NullReferenceException e)
            {
                Console.WriteLine(e.Message);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }

            // TASK 2
            Car car = new Car();
            car.Brand = "BMW";
            car.Model = "SS1";
            car.Type = CarTypeEnum.Sport;
            Console.WriteLine(car.ToString());

            Car car2 = new Car();
            car2.Brand = "Toyota";
            car2.Model = "Prado";
            car2.Type = CarTypeEnum.SUV;
            Console.WriteLine(car2.ToString());

            Car car3 = new Car();
            car3.Brand = "Lexus";
            car3.Model = "LX570";
            car3.Type = CarTypeEnum.SUV;
            Console.WriteLine(car2.ToString());

        }
    }
}
