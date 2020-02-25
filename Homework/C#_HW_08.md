# C# Homework 08
## Name: Ricardo Aldana Salas
## Date: February 06, 2020

##### 1.What is the difference between deep copy and shallow copy?
1.shallow copy is creating a new object and then copying the value type field of the current object to the new object. Deep copy is the process of creating a new object and then copying the field of the current object to the newly created object to make a complete copy of the internal reference types.
---
##### 2.What is the value of a reference after you declare and initialize it?
2. It is passed as a reference parameter. Holding a address in  memory were the data is stored.
---
##### 3.How do you declare a value type?
3. Is a value type that holds data value within its own memory space. It directly contain its value.
---
##### 4.How do you declare a reference type?
4. Reference type doesn't store its value directly. It stores the address where the value is being stored. It contains a pointer to another memory location that holds the data.
---
##### 5.Does C# allow you to assign NULL to a value type?
5. Yes. It is know as the nullable type. It allows you to assign a null value to a variable.
---
##### 6.Can you assign a nullable value type to a non-nullable variable of the same type?
6. Yes but you need to specify the value to be assigned in place of null.
---
##### 7.What is the difference between the stack and the heap?
7. Stack is used for static memory allocation and Heap for dynamic memory allocation. Both are stored in the computer's ram. Heap is slow then heap.
---
##### 8.What does it mean when we say that all classes are specialized types?
8. Is something to do with working with inheritance.
---
##### 9.What does ref do?
9. Is used for passing or returning reference of values to or from methods. Meaning that any changes made to a value that is passed by reference will reflect this change.
---
##### 10.What does out do?
10. It is used for the passing the arguments to methods as a reference types. It is used when a method returns multiple values.
---
##### 11.boxing and unboxing in your own words
11. Boxing is converting a value type to any other types. Unboxing extracts the value type from the object.

##### 12.What does cast do?
12. Cast is a method by which a value is converted from one data type to another. It helps in copying a value of a particular type into a variable or a parameter of a methods.
