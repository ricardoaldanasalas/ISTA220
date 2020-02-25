# C# Homework 10
## Name: Ricardo Aldana Salas
## Date: February 12, 2020
---

##### 1.What does an array look like in memory?
1.  Is a group of like-typed variables that are referred to by a common name. Each data item is call an alement of array. An array is a contiguis block numbers in the heap.
---
##### 2.Where is memory allocated to hold an array, on the stack or on the heap?
2. It is stored in the heap when variable is kept for a while. Stack if dealing with small variables and only need to persist as long as the function using them is alive.
--
##### 3.Where is memory allocated to hold an array reference, on the stack or on the heap?
3. It is store at the stack.
---
##### 4.Can an array hold values of different types?
4. Yes only if we create an object array. If we don't a compile time error will pop saying cannot convert tyep string to int.
---
##### 5.Describe the syntax of the condition for a foreach loop.
5. ForEach is a a way to execute a statement or a set of statement multiple numbers of times depending on the result of a condition to be evaluated.
---
##### 6.How do you make a deep copy of a array?
6. Create an array within an array and call it out using foreach loop.
---
##### 7.What is the difference in the syntax between a multi-dimensional array and an array of arrays?
7. Multi-dimensional array stores values in a row-major order meaning that elements of all rows are stored in a consecutive manner. Array of arrays(jagged) is an array whose elements are arrays. Jagged arrays are array reference, wheas multi-dimensional arrays can only store elemens and dimesions.
---
##### 8.What is the difference in the uses for a multi-dimensional array and an array of arrays? In other words, what determines whether you would use one as opposed to the other?
8.Jagged arrays are array reference, where as multi-dimensional arrays can only store elements and dimensions.
---
##### 9.How do you “flatten” a multidimensional array?
9. We access the 2d array total element count--the length property of a 2d returns this value We copy the 2d array into 1D array. We return 1D array.
---
##### 10.When we use a for loop, we can change the values of the array elements inside the loop. When we use a foreach loop, we cannot change the values of the array elements inside the loop. Why not? How is for different from foreach?
10.
---
