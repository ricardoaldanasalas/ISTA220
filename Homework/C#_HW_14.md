# C# Homework 14
## Name: Ricardo Aldana Salas
## Date: February 24, 2020
---

##### 1. What is the difference between a managed resource and an unmanaged resource?
1. Manage resource means anything managed by the Compiler Language Runtime. Unmanaged resources typically mean native resources that are created and lifetime managed outside the CLR.
---
##### 2.When is memory for an object (reference type) allocated? When is the memory deallocated?
2.  It is allocatd when you create variables and objects. The CLR must return the memory previously belonging to the object back to the hep. It must be dealloated.  
--
##### 3 What is a destructor?
3. Is a special method of a class and it is used in a class to destroy the object or instances of classes. The destructor automatically  invoked by garbage collector whenever the class object that are no longer need in application.
---
##### 4.What is the difference in syntax between a constructor and a destructor?
4.  constructor is declared as Classname(argument if any){constructor's Body}. Desctructor is declared as Classname(no argument){}; Overall destructor can't have any argument.
---
##### 5.Give some examples of scarce resources. Why would you want to manage scarce resources?
5. Creating a dispoal Method which disposes of a resource.
---
##### 6.What is exception-safe disposal?
6. A way to call a disposal method within a finally block regardless of whether there is an exception or not.
---
##### 7.How do you think that the using statement works for resource management? Give an informal, English language, explanation of how it works.
7. By cleaning a resource method. One first have to create an object and soon after the using statement it will be destroy.
---
##### 8.What ill effects could result from attempting to dispose of a resource more than once?
8. It will cause violation of CA2202 warning. If its dispose more than once, the object must ignore all calls after the first one.  The object must not trow an eception.
---
##### 9.We will look at threads later in the term. For now, what is your understanding of how threads interact with resource management?
9. By keeping resource in a uncorrupted state and avoid race conditions.
---
##### 10 Why does the book recommend not attempting to force the garbage collector? Are their any exceptions to this recommendation?
10. Because it forces the collector to run using the System. The system is a big library. It will take more memory to run.
