namespace TheOOPHotel
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Skapa en Manager
            Manager manager = new Manager("Lisa Ledarsson", 40, "M001", new DateTime(2022, 3, 15), 50000m, "Adminstration");

            // Skapa en Employee
            Employee employee = new Employee("Erik Eriksson", 30, "E001", new DateTime(2022, 3, 15), 30000m, "Receptionist", "Front Desk");

            // Anropa metoder för att testa
            Console.WriteLine("Manager:");
            manager.PrintInfo();
            manager.Introduce();
            manager.HoldMeeting();

            Console.WriteLine("\nEmployee:");
            employee.PrintInfo();
            employee.Introduce();
            employee.Work();


            Consultant consultant = new Consultant("Eva Expert", 35, "C001", new DateTime(2023, 1, 1), 0, 1000, "Hotel Experterna AB", "sodijeijfe");
            Console.WriteLine("\nConsultant:");
            consultant.PrintInfo(); 
            consultant.Introduce();
            consultant.GiveAdvice();

            HouseKeeper anna = new HouseKeeper("Anna Clean", 32);
            anna.PrintInfo();
            anna.Work();
            consultant.expertise = Console.ReadLine();
            Console.WriteLine(consultant.expertise);
        }
    }
}
