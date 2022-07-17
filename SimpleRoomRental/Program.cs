namespace SimpleRoomRental
{
    class Program
    {
        static void Main()
        {
            Room[] rooms = new Room[10];

            Console.Write("How many rooms will be rented? ");
            int rented = int.Parse(Console.ReadLine());

            for (int i = 0; i < rented; i++)
            {
                Console.WriteLine($"\nRent #{i + 1}:");

                Console.Write("Nome: ");
                string name = Console.ReadLine();

                Console.Write("Email: ");
                string email = Console.ReadLine();

                Console.Write("Room: ");
                int roomNumber = int.Parse(Console.ReadLine());

                rooms[roomNumber] = new Room(name, email, roomNumber);
            }

            Console.WriteLine("\nBusy rooms:");

            for (int i = 0; i < 10; i++)
            {
                if (rooms[i] != null)
                    Console.WriteLine(rooms[i]);
            }
        }
    }
}
