using System;

namespace Laborator1
{
    class Architect : Employee
    {
        public Architect(string firstName, string lastName, DateTime startDate, DateTime endDate, long salary)
            : base(firstName, lastName, startDate, endDate, salary)
        {}

        public override string Salutation()
        {
            return $"Hello Architect: {this}";
        }
    }
}