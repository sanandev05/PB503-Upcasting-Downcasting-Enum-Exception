
namespace PB503_Upcasting_Downcasting_Enum__Exception
{
    public class Room
    {
        static int _id;
        double _price;
        int _personCapacity;

        public static int Id => _id;
      
        public string Name;
        public double Price { get => _price; set { if (value>0) { _price = value; } } }
        public int PersonCapacity { get => _personCapacity; set { if (value > 0) { _personCapacity = value; } } }
        public bool IsAvailable=true;
        public Room(string name,double price,int personCapacity)
        {
            Name = name;
            Price = price;
            PersonCapacity = personCapacity;
            _id++;
        }
        string ShowInfo()
        {
            string message = $"Name={Name}\nId:{Id}\nPrice:{Price}\nPerson Capacity:{PersonCapacity}\n Is Available:{IsAvailable}";
            return message;
        }
        public override string ToString()
        {
            return ShowInfo();
        }
        
    }
}
