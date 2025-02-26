using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SPG_Fachtheorie.Aufgabe1.Model
{
    public abstract class Employee
    {
        public int RegistrationNumber { get; protected set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public Address Address { get; set; }
        public string Type { get; protected set; }

        protected Employee(int registrationNumber, string firstName, string lastName,
                           Address address)
        {
            RegistrationNumber = registrationNumber;
            FirstName = firstName;
            LastName = lastName;
            Address = address;
            Type = "";
        }
    }
}