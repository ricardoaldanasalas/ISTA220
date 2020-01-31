# C# Homework 06
## Name: Ricardo Aldana Salas

##### 1. What is an exception?
1. Is a response to an exception circumstance that arises while a program is running, such as an attempt to divide by zero.
---
##### 2. What happens in a try block if the program executes without errors?
2. The statements runs until completion. It an error condition occurs, execution jumps out of the try block and into another piece of code designed to catch and handle the exceptions.
---
##### 3. How does the catch mechanism work for unhandled exceptions?
3. The terminal will trow an OverFlowException, which will not be caught by the FormatException catch handler.
---
##### 4. What happens in a program if an exception block fails to handle an particular error
4. The program will continue to get re thrown then 'windows handles' it. The CLR traverses up the call stack looking for a matching catch expression.
---
##### 5. What is the parent class for all exceptions? How does this work?
5. The parent class is the base class exception which gets divided into ApplicationException and SystemException.
---
##### 6. How do you determine the type of an error?
6. One uses the FormatException type with its properties.
---
##### 7. What is the purpose of integer checking?
7. To minimize the use of space in the RAM.
---
##### 8. What is the range of values than a signed Int32 type can contain? State the lowest value and the highest value.
-2147483648 to 2147483647
---
##### 9. What is the range of values than an unsigned Int32 type can contain? State the lowest value and the highest value. What is the difference between a signed integer and an unsigned integer? Can signed integers and unsigned integers represent the same amount of numbers?
9. 0 to 65535. An unsigned variable type can hold zero and positive number. A singed int holds negative, zero, and positive number.  Not the same amount of number. It has to be in between What it states.
---
##### 10. What does the finally block do?
10. It will execute when the try/catch block leaves the execution, no matter what condition cause it.
---
##### 11. (Thought question) When would you not use a finally block in a try/catch construction?
11. When one would not use the system resources. 
