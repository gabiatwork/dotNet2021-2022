using System;

namespace Laborator1
{
    class Manager : Employee
    {
        public Manager(string firstName, string lastName, DateTime startDate, DateTime endDate, long salary)
            : base(firstName, lastName, startDate, endDate, salary)
        {}

        public override string Salutation()
        {
            return $"Hello Manager: {this}";
        }
    }
}