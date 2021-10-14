# Introduction to .NET – lab no. 1

#### Way of working: work in pair with one colleague. 
#### Summary:
 Keywords: OOP, inheritance, encapsulation, class design, virtual, abstract, extensions in C#, defensive coding

1. Create a class called Manager and expose the following properties:
    a. Id
        FirstName
        LastName
        StartDate
        EndDate
        Salary
    b. Expose the following behaviour:
        GetFullName(FirstName+LastName)
        IsActive(EndDate-StartDate>0) 
        Salutation(virtual or abstract?) => should return “Hello” + manager or “Hello” + architect.

Create a class called Architect and expose properties/behaviour described above.
Using the inheritance principle extract a base class called Employee.
Explain the option for Salutation method

2. Create an extension method that allows us computing words from a sentence (hint: make use of split extension)

Preconditions: Find and read documentation related to Extensions in C#.

Time to work: 50 minutes
