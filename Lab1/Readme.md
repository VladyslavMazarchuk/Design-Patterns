# Lab 1

## Code Test Result from [Main Method](./Program.cs#L3-L36)
![Test Result](https://github.com/VladyslavMazarchuk/Design-Patterns/raw/master/Lab1/Result.png)

## Description of the Code

### DRY (Don’t Repeat Yourself)
The code does not contain repeated blocks of code. Each piece of information has a single, immutable representation in the code. We can see it in every class in the directory:
- [Money.cs](./Money.cs)
- [Product.cs](./Product.cs)
- [Warehouse.cs](./Warehouse.cs)
- [Reporting.cs](./Reporting.cs)

### KISS (Keep It Simple, Stupid)
The code is simple and clear. It performs its tasks without unnecessary complexity.

### SOLID
- **Single Responsibility Principle (SRP):** Each class has only one responsibility.
  - [Money.cs](./Money.cs)
  - [Product.cs](./Product.cs)
  - [Warehouse.cs](./Warehouse.cs)
  - [Reporting.cs](./Reporting.cs)

- **Open/Closed Principle (OCP):** Classes can be extended but not modified.
  - For example, the `Product` class can be extended for new product types without changing its code.

- **Liskov Substitution Principle (LSP):** Objects of `Product`, `Money`, `Warehouse` can be replaced by their subtypes without altering the correctness of the program.
  - [Product.cs](./Product.cs)
  - [Warehouse.cs](./Warehouse.cs)

- **Interface Segregation Principle (ISP):** Classes have only the necessary methods.
  - [Product.cs](./Product.cs)
  - [Warehouse.cs](./Warehouse.cs)

- **Dependency Inversion Principle (DIP):** Dependencies depend on abstractions, not on concrete implementations.
  - [Reporting.cs](./Reporting.cs)

### YAGNI (You Aren’t Gonna Need It)
The code does not contain anything superfluous and implements only the necessary functionality.

### Composition Over Inheritance
Composition is used (e.g., `Product` has a `Money` object; `Warehouse` has a list of `Product` objects), not inheritance.
- [Product.cs](./Product.cs)
- [Warehouse.cs](./Warehouse.cs)

### Program to Interfaces, not Implementations
Classes `Product` and `Warehouse` work with abstractions (interfaces), not with concrete implementations.
- [Product.cs](./Product.cs)
- [Warehouse.cs](./Warehouse.cs)

### Fail Fast
If the input data for the `Money` or `Product` classes is not as expected, the program will immediately report an error.
- [Money.cs](./Money.cs)
- [Product.cs](./Product.cs)

## Links to Relevant Files and Code Lines
- [Money.cs](./Money.cs)
- [Product.cs](./Product.cs)
- [Warehouse.cs](./Warehouse.cs)
- [Reporting.cs](./Reporting.cs)
- [Program.cs](./Program.cs)
