# C# Chapter 19
## Name: Ricardo Aldana Salas
## Date: March 23, 2020
---

##### 1. What is an enumerable collection?
1.  Is an interface defining a single method GetEnumerator() that returns an IEnumerator interface.
---
##### 2.What properties and methods does the IEnumerable interface contain?
2. It contains the System. COllection.Genriic namespace and works with linq query expression.
--
##### 3. What properties and methods does the IEnumerator interface contain?
3. It has the Properties Current and the Method MoveNext and reset.
---
##### 4.What values does the MoveNext() method return? What does it do?
4. Will return a boolen true or false. Move the pointer to the bottom.
---
##### 5.What values does the Reset() method return? What does it do?
5. Returns voids. It returns nothing.
---
##### 6.Are IEnumerable and IEnumerator type safe? Why or why not? If not, how do you implement type safety?
6. No, Because returns an object rather than a specific type.  You use it by using the genertic method.
---
##### 7 Why don’t recursive methods retain state when used with data structures like binary trees?
7. Only computes one value at a time and confirm it.
---
##### 8 How do you define an enumerator?
8. You implement current reset and move MoveNext()
---
##### 9 What is an iterator?
9. Points the next item of the collection.
---
##### 10 What does yield do?
10. Dump one things at a time instead of everything at the same time.
---
