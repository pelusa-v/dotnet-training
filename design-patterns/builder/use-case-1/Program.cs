using UseCase1;

Console.WriteLine("=== Builder Pattern - Use Case 1: Basic Builder with Director ===");
Console.WriteLine("Demonstrates building different types of computers using the Builder pattern.\n");

// Build a Gaming Computer
Console.WriteLine("Building a Gaming Computer:");
var gamingBuilder = new GamingComputerBuilder();
var director = new ComputerDirector(gamingBuilder);
director.ConstructComputer();
var gamingComputer = director.GetComputer();
gamingComputer.DisplaySpecifications();

// Build an Office Computer
Console.WriteLine("Building an Office Computer:");
var officeBuilder = new OfficeComputerBuilder();
director = new ComputerDirector(officeBuilder);
director.ConstructComputer();
var officeComputer = director.GetComputer();
officeComputer.DisplaySpecifications();
