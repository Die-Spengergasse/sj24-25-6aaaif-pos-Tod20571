namespace SPG_Fachtheorie.Aufgabe1.Model
{
    public class Cashier : Employee
    {
        public string JobSpezialisation { get; set; }

        public Cashier(string jobSpezialisation, int registrationNumber, string firstName, string lastName, Address address) : base(registrationNumber, firstName, lastName, address)
        {

            JobSpezialisation = jobSpezialisation;
            Type = "Cashier";
        }
    }
}