Object-oriented programming is known as OOP.

While procedural programming involves writing procedures or methods that perform operations on the data, object-oriented programming involves creating objects that contain both data and methods.

Classes and Objects
The two main components of object-oriented programming are classes and objects.

 A class is a template for objects, and an object is an instance of a class.
Every variable and method from the class is inherited by the individual objects when they are created.methods from the class.

It's common to refer to a variable that is explicitly declared in a class as a field (or attribute).

Although it is not necessary, it is a good practice to begin class names with an uppercase letter. Additionally, it is typical for the class name and the C# file name to be the same as it keeps our code organized.

Create an Object
An object is created from a class.
To create an object of Class, specify the class name, followed by the object name, and use the keyword new: Class myClass = new Class();

Class Members
Classes' fields and methods are frequently referred to as "Class Members". You can accesss them using the dot operator (.).

Constructors
A constructor is a special method for initializing objects. A constructor has the advantage of being called when a class object is created. It can be used to set the initial values for the fields.

Default Constructor
A default constructor is a 0 argument constructor which contains a no-argument call to the super class constructor.
To assign default values to the newly created objects is the main responsibility of default constructor.
Compiler writes a default constructor in the code only if the program does not write any constructor in the class.
The access modifier of default constructor is always the same as a class modifier but this rule is applicable only for “public” and “default” modifiers.

Parameterized Constructors
The parameterized constructors are the constructors having a specific number of arguments to be passed.
The purpose of a parameterized constructor is to assign user-wanted specific values to the instance variables of different objects.
A parameterized constructor is written explicitly by a programmer.
The access modifier of default constructor is always the same as a class modifier but this rule is applicable only for “public” and “default” modifiers.

An access modifier is a keyword that specifies the level of access/visibility for classes, fields, methods, and properties. See image below:
![image](https://user-images.githubusercontent.com/65234619/180448998-75241e9f-349e-48b4-892e-509fb5a5e7bf.png)

There are also two combinations: internal protected and private protected.

Why are Access Modifiers used?
To limit class members' visibility (the security level of each individual class and class member).

Properties
A property is pretty much a combination of a variable and a method in that it has two methods: get and set:

To achieve "Encapsulation," which is the process of hiding "sensitive" data from users. This is accomplished by making fields private.

Why is Encapsulation used?
.Improved control over class members (reduces the possibility of you (or others) messing up the code)
.Fields can be made read-only (if only the get method is used) or write-only (if you only use the set method)
.The programmer can change one part of the code without affecting the others.
.Increased data security

INHERITANCE (Derived and Base Class)
In C#, fields and methods can be inherited from one class to another. The "inheritance concept" is divided into two categories:

.Derived Class (child) - a class that derives from another.
.Base Class (parent) - the class inherited from
.Use the: symbol to inherit from a class.

Why And When To Use "Inheritance"?
- It is useful for code reusability: reuse fields and methods of an existing class when you create a new class.

The sealed Keyword
If you don't want other classes to inherit from a class, use the sealed keyword:
sealed class Vehicle 
{
  ...
}
If you try to access a sealed class, C# will generate an error:



