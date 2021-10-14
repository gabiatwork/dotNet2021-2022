using System;
namespace Laborator1
{
    public abstract class Employee
    {
        public Employee(
            string firstName,
            string lastName,
            DateTime startDate,
            DateTime endDate,
            long salary
            )
        {
            Id = Guid.NewGuid().ToString();

            FirstName = firstName;
            LastName = lastName;
            StartDate = startDate;
            EndDate = endDate;
            Salary = salary;
        }
        public string Id { get; }

        public string FirstName { get; set; }
        public string LastName { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public long Salary { get; set; }

        public string GetFullName()
        {
            return FirstName + LastName;
        }

        public bool IsActive()
        {
            // Less than zero	t1 is earlier than t2.
            return DateTime.Compare(StartDate, EndDate) < 0;
        }

        /* Salutation method should be abstract because all children should implement it to add the correct role 
         * in the salutation (manager, architect, etc..).
         * 
         * In case of a virtual method, there should have been a default implementation in the base class, and children could
         * implement it or not. In this case, I think a default implementation isn't needed.
        */
        public abstract string Salutation();

        public override string ToString()
        {
            return $"{ FirstName} { LastName}, with id: { Id}, employed from from { StartDate}. " +
                $"Status: {(this.IsActive() ? "Active " : "Inactive")}. " +
                $"Salary: {Salary}";
        }
    }
}
