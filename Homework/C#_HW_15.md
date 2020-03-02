# C# Homework 15
## Name: Ricardo Aldana Salas
## Date: March 01, 2020
---

##### 1.What is the difference between a property and a field?
1.  A field is a variable that is declared directly ina class or struct. Properties enalbe a class to exppose a public way of getting nd seeting clues while hiding implemantaion or verification code. 
---
##### 2.What is the difference between a property and a method?
2.  A property is basicallly information that an object has. Methods are what an object can do.
--
##### 3 What is your understanding of encapsulation?
3. Is defined as the wrapping up of date under a single unit. It is the mechanishm that binds together code and the datat it manipulates.
---
##### 4.. Some languages are case insensitive, that is, an ‘a” and an “A” are considered to be the same letter. C# is case sensitive. What implications does this have regarding the naming of variables, methods, and other identifiers? Do you think that the difference in case in the initial character of two different identifiers is sufficient to distinguish them¿
4.  It a matter of convention lower case is for private upper case is public.
---
##### 5. Give an example that is not in the book of an instance where you might want to use a read-only property. Give an example not in the book of an instance where you might want to use s write-only property.
5. //*datetime*
---
##### 6.Can you think of a reason why you might ever want to make getters and setters private?
6. No because declaring getters and setters is to hide the fields. It is done to unwanted coupling.
---
##### 7.What are restrictions on the use of properties?
7. We have to follow a few rules or restrictions while writing properties which are as follows. A property cannot be passed via ref or out parameter to a method.
---
##### 8.What is an object initializer? What is the syntax for an object initializer?
8. Is the easiest and fastest way to assign values of an objects properties and fields.
__Student __student = new Student();
__student.StudentID = 1;
__student.StudentName = "Bill";
---
