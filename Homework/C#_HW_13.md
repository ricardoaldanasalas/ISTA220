# C# Homework 13
## Name: Ricardo Aldana Salas
## Date: February 24, 2020
---

##### 1.What is an interface as the term is used on object-oriented programming?
1.   Is a type definition similar to a class, except that it purely represents a contract between an object and its user.
---
##### 2.How do you define an interface?
2. "Interface  + Name"
--
##### 3 Can an interface have variables, fields, or properties?
3. Interface does not have fields in other words we can't declare variables in an interface.
---
##### 4.How do you define a method in an interface?
4. It is used to provide total abstraction. All member in the interface are declared with the empty body and are public and abstract by default.
---
##### 5. Can you instantiate an object through an interface? Why or why not?
5. It can't be instantiated directly. Its members are implemented by any class or structs that implemented the interface.
---
##### 6. Using the new keyword, can you declare a reference to an interface?
6. We can't create instance of interface but we can make reference of it that refers to the object of its implementing class.
---
##### 7.Can an object inherit from multiple interfaces? Can a class implement multiple interfaces? If so, how can it do so?
7.  YES!
---
##### 8. What does it mean to explicitly implement an interface?
8. Is a complex and rarely used technique that allows a single class to inherit from multiple interfaces that have the same method signature.
---
##### 9. What are the restrictions on interfaces?
9.  It cannot contain constant, fields, operators, instances constructors or types nor can an interface contain static members of any kind.
---
##### 10 What is the difference between an abstract class and an interface?
10. An abstract class needs to come from a derived class and interface is what the user sees.
---
##### 11 What is an abstract method?
11. Is a method without a body. It is done by retrieving it from the derived class.
---
##### 12. What is an sealed class?
12. are used to restrict the inheritance features of object oriented programming. Once class is defined as a sealed class. this class cannot be inherited.
---
##### 13. What is an sealed method?
13. It prevents a method of a class. Its a method that is declared with the keyword sealed and is always used with combination of override keyword.
