

namespace PB503_Upcasting_Downcasting_Enum__Exception
{
    public class Hotel
    {
        public string Name;
        private Room[] rooms;

        public void AddRoom(Room room)
        {

            Array.Resize(ref rooms, rooms.Length+1);
            rooms[rooms.Length-1]= room;
        }
        public Hotel(string Name)
        {
            rooms=Array.Empty<Room>();
            this.Name = Name;
        }
        public void MakeReservation(int? roomId)
        {
            if (roomId == null)
            {
                throw new NullReferenceException();
            }
            else
            {
                if (!rooms[roomId.Value - 1].IsAvailable)
                {
                    throw new NotAvailableException($"This room isn't available with this id");
                }
                else
                {
                    rooms[roomId.Value - 1].IsAvailable = true;
                }
    
            }
        }
    }
}
