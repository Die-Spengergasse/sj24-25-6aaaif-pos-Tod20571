namespace SPG_Fachtheorie.Aufgabe1.Model
{
    public class Manager : Employee
    {
        public string CarType { get; set; }

        public Manager(string carType, int registrationNumber, string firstName, string lastName, Address address)
            : base(registrationNumber, firstName, lastName, address)
        {
            CarType = carType; 
            Type = "Manager";  // Setzt den Typ für den Discriminator
        }
    }

}