# C# Homework 11
## Name: Ricardo Aldana Salas
## Date: February 19, 2020
---

##### 1.What is a parameter array?
1.  A method that can take any number of arguments, posibly of different types, as parameters.
---
##### 2.How do you define a method that takes an arbitrary number of arguments?
2. By declaring two or more methods with the same name in the same scope which is also know as overloading.
--
##### 3 How do you call a method that takes an arbitrary number of argiments?
3. By using a params parameter.
---
##### 4.Why can’t you use an array to pass an arbitrary number of arguments to a method?
4. A method that takes optional parameters still has a fixed parameter list. The compiler generates code that inserts the default values onto the stack for any missing arguments before the method runs.
---
##### 5.How many parameters can a method have?
5. 10-20 parameters
---
##### 6.Do parameter arguments have to have the same type?
6. xa
---
##### 7.What is the difference between a method that takes a parameter argument and one that takes optional arguments?
7. A method that takes optional parameters still has a fixed parameter list. Generally you use parameter arrays for methods that can take any number of parameters, whereas you use optional parameters only where it is not convenient to force a caller to provide an argument for every parameter.
---
##### 8.How do you define a method that takes different (and arbitrary) types of arguments?
8. we define it as a Dynamic parameter.**
---
##### 9.Write a method that accepts any number of arguments of a given type.
9. Public static void UseParams(params int[] list)
---
##### 10Write a method that accepts any number of arguments of any type.
10. Public static void UseParams2(params object[] list)
---
