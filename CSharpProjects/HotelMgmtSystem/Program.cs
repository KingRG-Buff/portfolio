namespace FinalProject
{
    class Program
    {
        static List<Room> rooms = new List<Room>();

        static void Main(string[] args)
        {
            InitializeRooms();
            Console.WriteLine("-----CIDM2315 Final Project: Raul Garcia-----");
            Console.WriteLine("-----Welcome to Buff Hotel-----");

            Console.WriteLine("==> Please enter username:");
            string username = Console.ReadLine();
            Console.WriteLine("==> Please enter password:");
            string password = Console.ReadLine();

            if (username != "alice" || password != "alice123")
            {
                Console.WriteLine("Wrong Username/Passcode");
                return;
            }

            Console.WriteLine("==> Login successful!\n");
            Console.WriteLine($"\n** Welcome User {username}! **");

            bool running = true;
            while (running)
            {
                DisplayMenu(username);

                string choice = Console.ReadLine(); 

                switch (choice)
                {
                    case "1":
                        ShowAvailableRooms();
                        break;
                    case "2":
                        CheckIn();
                        break;
                    case "3":
                        ShowReservedRooms();
                        break;
                    case "4":
                        CheckOut();
                        break;
                    case "5":
                        Console.WriteLine("User is logged out of the system.");
                        Console.WriteLine($"\n** Have a nice day {username}! **");
                        running = false;
                        break;

                    default:
                        Console.WriteLine("Invalid option. Please try again.");
                        break;
                }
            }
        }

        static void InitializeRooms()
        {
            for (int i = 101; i <= 110; i++)
            {
                int capacity = i <= 105 ? 2 : (i <= 109 ? 3 : 4);
                rooms.Add(new Room(i, capacity));
            }
        }

        static void ShowAvailableRooms()
        {
            int availableRoomCount = 0;

            foreach (var room in rooms)
            {
                if (room.IsAvailable)
                {
                    Console.WriteLine($"+ Room number: {room.Number}; Capacity: {room.Capacity}");
                    availableRoomCount++;
                }
            }

            Console.WriteLine($"-----Number of Available Rooms: {availableRoomCount} -----");
        }

        static void CheckIn()
        {
            Console.WriteLine("==> Input Number of People:");
            int peopleCount;
            while (!int.TryParse(Console.ReadLine(), out peopleCount) || peopleCount <= 0)
            {
                Console.WriteLine("Invalid input. Please enter new number:");
            }

            List<Room> suitableRooms = rooms.FindAll(room => room.IsAvailable && room.Capacity >= peopleCount);

            if (suitableRooms.Count == 0)
            {
                Console.WriteLine("No suitable room available.");
                return;
            }

            Console.WriteLine("Suitable rooms:");
            foreach (var room in suitableRooms)
            {
                Console.WriteLine($"Room {room.Number}, Capacity: {room.Capacity}");
            }

            Console.WriteLine("==> Input the room number for check-in:");
            int roomNumber;
            while (!int.TryParse(Console.ReadLine(), out roomNumber) || !suitableRooms.Any(r => r.Number == roomNumber))
            {
                Console.WriteLine("Invalid room number. Please enter a valid number from the list above:");
            }

            Room selectedRoom = rooms.Find(r => r.Number == roomNumber);

            Console.WriteLine("==> Input customer name:");
            string customerName = Console.ReadLine();  // Declare and initialize customerName here

            Console.WriteLine("==> Input customer email:");
            string customerEmail = Console.ReadLine(); // Assuming you will use this later

            selectedRoom.IsAvailable = false;
            selectedRoom.CustomerName = customerName;  // Use customerName after it's declared
            Console.WriteLine($"==> Check-in Successful! {customerName} assigned to Room {selectedRoom.Number}.");
        }

        static void ShowReservedRooms()
        {
            Console.WriteLine("\n-----Reserved Rooms-----");
            foreach (var room in rooms)
            {
                if (!room.IsAvailable)
                {
                    Console.WriteLine($"+ Room {room.Number} is reserved to {room.CustomerName}.");
                }
            }
        }

        static void CheckOut()
        {
            Console.WriteLine("Enter the room number for check-out:");
            int roomNumber;
            if (!int.TryParse(Console.ReadLine(), out roomNumber))
            {
                Console.WriteLine("Invalid room number.");
                return;
            }

            var room = rooms.Find(r => r.Number == roomNumber);
            if (room != null && !room.IsAvailable)
            {
                Console.WriteLine($"==> Room: {room.Number}; Customer name: {room.CustomerName}");
                Console.WriteLine("==> Please confirm the customer name, then select 'y' to continue with Check-Out OR input any key to cancel.");

                string confirmation = Console.ReadLine();
                if (confirmation.ToLower() == "y")
                {
                    room.IsAvailable = true;
                    room.CustomerName = ""; 
                    Console.WriteLine($"\n==>Room {room.Number} has been checked out.");
                }
                else
                {
                    Console.WriteLine($"\n==> Check-Out has been cancelled.");
                }
            }
            else
            {
                Console.WriteLine($"\n==> Could not find customer record for this room.");
            }
        }

        static void DisplayMenu(string username)
        {
            Console.WriteLine("\n********************");
            Console.WriteLine("==> Please select:");
            Console.WriteLine("1. Show Available Rooms\n2. Check-In\n3. Show Reserved Rooms\n4. Check-Out\n5. Log Out");
            Console.WriteLine("********************");
        }
    }

    class Room
    {
        public int Number { get; set; }
        public int Capacity { get; set; }
        public bool IsAvailable { get; set; }
        public string CustomerName { get; set; }

        public Room(int number, int capacity)
        {
            Number = number;
            Capacity = capacity;
            IsAvailable = true;
            CustomerName = ""; 
        }
    }
}

