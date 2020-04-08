# C# Homework 20
## Name: Ricardo Aldana Salas
## Date: April 06, 2020
---

##### 1. What is a delegate? Explain delegates in terms of pointers and reference types.
1.   Are similar to pointers to funcstions. Is a reference type variable that holds the reference to a method. It can chage at runtime.
---
##### 2.How do you declare a delegate? Include a discussion of types, return values, names, and parameters.
2. Using delegate keyword followed by a function signature as shown below.
--
##### 3.How do you create instances of delegates and assign values to the instance? What are the values?
3. by using Public delegate void Del(string message); >>>> handler("");
---
##### 4. How do you invoke a method that has been added to a delegate?
4. It can be invoked like a method because it is  a reference to a method.
---
##### 5. What is an event? Why do we have events?
5.  Events are tasks that execute according to a specified schedule. Thats why there are referred to a scheduled events.
---
##### 6. How do you declare events?
6. CREATE EVENT SESSION.
---
##### 7. How do delegates recognize event subscriptions? How do you unsubscribe an event from a delegate?
7. By using event handlers. You define an event handler method in the event receiver.
---
##### 8. How do you raise an event? How do you declare code that raises an event?
8 CREAT EVENT NOTIFICATION(). BY using RAISERROR().
---
##### 9. Explain with specificity what happens when an event fires and that event has been attached to a delegate.
9. If you click a buttom on a form, the program would call a specific method. 
---
