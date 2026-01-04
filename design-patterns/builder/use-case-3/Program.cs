using UseCase3;

Console.WriteLine("=== Builder Pattern - Use Case 3: Director-Based Builder ===");
Console.WriteLine("Demonstrates building different types of houses with a Director pattern.\n");

// Build a Luxury Villa
Console.WriteLine("Building a Luxury Villa:");
var villaBuilder = new VillaBuilder();
var engineer = new ConstructionEngineer(villaBuilder);
engineer.ConstructFullHouse();
var villa = engineer.GetHouse();
villa.DisplayDetails();

// Build a Family House
Console.WriteLine("Building a Family House:");
var familyBuilder = new FamilyHouseBuilder();
engineer = new ConstructionEngineer(familyBuilder);
engineer.ConstructFullHouse();
var familyHouse = engineer.GetHouse();
familyHouse.DisplayDetails();

// Build an Apartment (minimal construction)
Console.WriteLine("Building an Apartment (minimal construction):");
var apartmentBuilder = new ApartmentBuilder();
engineer = new ConstructionEngineer(apartmentBuilder);
engineer.ConstructMinimalHouse();
var apartment = engineer.GetHouse();
apartment.DisplayDetails();

// Build another Villa but with minimal features
Console.WriteLine("Building a Basic Villa (minimal construction):");
var basicVillaBuilder = new VillaBuilder();
engineer = new ConstructionEngineer(basicVillaBuilder);
engineer.ConstructMinimalHouse();
var basicVilla = engineer.GetHouse();
basicVilla.DisplayDetails();
