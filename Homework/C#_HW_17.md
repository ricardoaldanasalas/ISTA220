# C# Homework Chapter 17
## Name: Ricardo Aldana Salas
## Date: February 19, 2020
---

##### 1.What is a type parameter?
1.  It refers to any declaration within the parenteses following the function name in a function declaration or definition.
---
##### 2.What does a type parameter do?
2. It specifies a generic type name. It can be used to declare the return type and act as placeholders for the type of the arguments passed to the generic method.
--
##### 3 How many type parameters can a generic class have?
3. It has one or more type parameters separated by commas. These classes are known as parameterized classes.
---
##### 4.What is the difference between a generic class and a generalized class?
4. Generic classes encapsulate operations that are not specific to a particular data type like linked lists, hash tables, stacks, tress. Generalized class are generic types and methods you create.
---
##### 5.What is a constraint? How do you specify a constraint?
5. Cpmstraint inform the compiler about the capabilities a type arguemnt must have. constraint are specified by using the where contextual keyword.
---
##### 6.What is a generic method? How do you define a generic method?
6. It can only pass parameter in int types.
---
##### 7.What do we mean when we say that a generic type interface is invariant?
7. It means that you can only use the type originally specified so an invariant generic type parameter is neither covariant no contravariant.
---
##### 8.What do we mean when we cay that a generic type interface is covariant?
8. It means that it must follow the foloowing conditions: they type parameter is used only as a return type of interface mthods and not used as a type of method arguments.
---
##### 9. Does covariance work with value types? Does it work with reference types?
9. It does not support value type. It does not work with refence types.
---
##### 10 What do we mean when we cay that a generic type interface is contravariant?
10. IT means that a type can be declared contravariant in a generic interface or delage only if it defines the types of a method'sparameters and not of a methods retrun type 
---
