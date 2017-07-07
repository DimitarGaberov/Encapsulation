# Encapsulation

1. Sort Persons by Name and Age
Create a class Person, which should have private fields for:
 firstName: string
 lastName: string
 age: int
 ToString(): string - override

2. Salary Increase
Refactor project from last task.
Read person with their names, age and salary. Read percent bonus to every person salary. Persons younger than 30
get half bonus. Expand Person from previous task. New fields and methods:
 salary: double
 IncreaseSalary(double bonus)

3. Validation Data
Expand Person with proper validation for every field:
 Names must be at least 3 symbols
 Age must not be zero or negative
 Salary can't be less than 460.0
Print proper message to end user (look at example for messages).
Use ArgumentExeption with messages from example.

4. First and Reserve Team
Create a Team class. Add to this team all person you read. All person younger than 40 go in first team, others go in
reverse team. At the end print first and reserve team sizes.
The class should have private fields for:
 name: string
 firstTeam: List&lt;Person&gt;
 reserveTeam: List&lt;Person&gt;
The class should have constructors:
 Team(string name)
The class should also have public methods for:
 AddPlayer(Person person): void
 FirstTeam: IReadOnlyCollection
 ReserveTeam: IReadOnlyCollection

⦁	Class Box
You are given a geometric figure box with parameters length, width and height. Model a class Box that that can be instantiated by the same three parameters. Expose to the outside world only methods for its surface area, lateral surface area and its volume (formulas: http://www.mathwords.com/r/rectangular_parallelepiped.htm).
On the first three lines you will get the length, width and height. On the next three lines print the surface area, lateral surface area and the volume of the box:
⦁	Class Box Data Validation
A box’s side should not be zero or a negative number. Expand your class from the previous problem by adding data validation for each parameter given to the constructor. Make a private setter that performs data validation internally. 

⦁	Animal Farm
You should be familiar with encapsulation already. For this problem, you’ll be working with the Animal Farm project. It contains a class Chicken. Chicken contains several fields, a constructor, several properties and several methods. Your task is to encapsulate or hide anything that is not intended to be viewed or modified from outside the class.

⦁	Shopping Spree
Create two classes: class Person and class Product. Each person should have a name, money and a bag of products. Each product should have name and cost. Name cannot be an empty string. Money cannot be a negative number. 
Create a program in which each command corresponds to a person buying a product. If the person can afford a product add it to his bag. If a person doesn’t have enough money, print an appropriate message ("[Person name] can't afford [Product name]").
On the first two lines you are given all people and all products. After all purchases print every person in the order of appearance and all products that he has bought also in order of appearance. If nothing is bought, print the name of the person followed by "Nothing bought". 
In case of invalid input (negative money exception message: "Money cannot be negative") or empty name (empty name exception message: "Name cannot be empty") break the program with an appropriate message. See the examples below:
