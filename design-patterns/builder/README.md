# Builder Design Pattern

The Builder pattern is a creational design pattern that allows you to construct complex objects step by step. It separates the construction of a complex object from its representation, allowing the same construction process to create different representations.

## When to Use the Builder Pattern

- When you need to create complex objects with many optional parts or configurations
- When the construction process must allow different representations of the object being constructed
- When you want to avoid "telescoping constructors" (constructors with many parameters)
- When the construction algorithm is independent of the parts that make up the object

## Use Cases in This Project

### Use Case 1: Basic Builder with Director
**Project:** `use-case-1`

Demonstrates the classic Builder pattern with a Director class for building Computer objects.

**Key Components:**
- `Computer` - The product class with multiple properties
- `IComputerBuilder` - The builder interface
- `GamingComputerBuilder` - Concrete builder for gaming computers
- `OfficeComputerBuilder` - Concrete builder for office computers
- `ComputerDirector` - Director class that orchestrates the building process

**Run:** `dotnet run --project use-case-1`

### Use Case 2: Fluent Builder
**Project:** `use-case-2`

Demonstrates the Fluent Builder pattern using method chaining to build Report objects.

**Key Components:**
- `Report` - The product class representing a report
- `ReportBuilder` - Fluent builder with method chaining

**Features:**
- Method chaining for readable and intuitive API
- Optional configuration methods
- Reset method to reuse the builder

**Run:** `dotnet run --project use-case-2`

### Use Case 3: Director-Based Builder with Multiple Products
**Project:** `use-case-3`

Demonstrates building different types of houses (Villa, Family House, Apartment) with varying construction approaches (full vs. minimal).

**Key Components:**
- `House` - The product class representing a house
- `IHouseBuilder` - The builder interface
- `VillaBuilder`, `FamilyHouseBuilder`, `ApartmentBuilder` - Concrete builders
- `ConstructionEngineer` - Director with multiple construction strategies

**Run:** `dotnet run --project use-case-3`

## Benefits of the Builder Pattern

1. **Flexibility** - Allows you to construct different representations using the same construction code
2. **Readability** - Especially with fluent interfaces, the code is self-documenting
3. **Encapsulation** - Construction logic is separated from the business logic
4. **Reusability** - The same builder can create different configurations of an object
5. **Immutability** - Can be used to construct immutable objects

## Building the Solution

To build all use cases:
```bash
dotnet build builder.sln
```

To run a specific use case:
```bash
dotnet run --project use-case-1
dotnet run --project use-case-2
dotnet run --project use-case-3
```

## References

- [Builder Pattern - Gang of Four](https://en.wikipedia.org/wiki/Builder_pattern)
- [Fluent Interface](https://en.wikipedia.org/wiki/Fluent_interface)
