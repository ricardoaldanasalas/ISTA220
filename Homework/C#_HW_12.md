# C# Homework 12
## Name: Ricardo Aldana Salas
## Date: February 20, 2020
---

##### 1.How does inheritance promote the principle of don’t repeat yourself (DRY)?
1.  Instead of duplicating methods of similar instances. One can create one method that other instances can borrow their traits.
---
##### 2.What is the syntax of a derived class that inherits from a base class?
2. The syntax for the inherits class is ":"
--
##### 3Do all user defined types (classes and structs) inherit from some base class?
3. The derived type inherits the members of both base types in its inheritance hierarchy. All inherits from the type System.Object class.
---
##### 4.What happens if you do not have a default constructor in a base class when creating a derived class?
4. C# doesn't care if you do or not. one must call that constructor explicitly from the derived class or add a default constructor explicitly in the base class.
---
##### 5.Can you assign a variable of a derived class to another variable of its base class? Why or why not?
5. Depends on  what kind of class it derives from.
---
##### 6.Can you assign a variable of a derived class to another variable of of a derived class of its base class? Why or why not?
6. no because would have to be compatable.
---
##### 7.Can you assign a variable of a base class to another variable of a derived class? Why or why not?
7. No, not all mammals are horses.
---
##### 8.Under what circumstances would you want to use the new keyword when defining a method in a derived class?
8. When one uses a declaration modifier which hides a member that is inherited from a base class. when one hides an inherited member, the derived version of the member replaces the vase class version.
---
##### 9.. What is a virtual method? Why would you want to define a virtual method?
9. is a method that can be redefined in derived classes. When more functionality is needed in the derived class.
---
##### 10. What does override do? Why does it do it?
10. Is a keyword used to replace a virtual member that is defined in a base class with the definition of that member in the derived class.  Whenever we need to modified or extend a derived class.
---
##### 11. How do you define an extension type?
11.  IT allows us to extend functionality of an existing type without creating a new derived type.
---
##### 12 .Why do you define an extension type?
12.  Because it allows you to add new methods in the existing class or in the structure without modifying the source code of the original type and you do not require any kind of special permission for the original type.
---
##### 13. Explain the Liskov substitution principle.
13. It enables you to write robust, maintainable and resuable  software components.
