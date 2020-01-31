# Calculator
C# Calculator for TechSwitch

**Completed Tasks**
1)  Add the following functionality to your Calculator project:
            Prompt the user to enter one number
            Prompt the user to enter a second number
            Multiply the two numbers together and print out the result

2) Let's enhance your Calculator a little further. We want to support more operations than just multiplication. We'll do this by prompting the user to
   enter an operator before they enter the numbers.
   To keep things simple, we’ll just use these 4 operators:
           addition (+)
           subtraction (-)
           multiplication (*)
           division (/)
           
3) So far our calculator only performs operations on two numbers. Let's enhance it so it can do calculations on any number of numbers! Let's keep things simple by using the same operator each time.

4) One of our goals as programmers should be to write "clean code" - that is, code that is simple and understandable. Refactor your code by splitting your existing code into two new methods, and then having the Main method just call them both in turn.

5) Create a method that is usable every time you want to print out a message, and interpret the response as an integer. Now see how many further improvements you can make to the readability of your code by splitting it off into smaller, well named methods.

6) Make your calculator keep running once it's calculated an answer, it should just loop round and start again. Presumably you don't want to keep printing the welcome
   message every time though.
   
7) Force the user to enter valid numbers - it's annoying if your program crashes if the user types in a string instead. Have it just ask again in this case.

8) Review how your calculator deals with strings at the moment. Can you use string.Format to improve your code? Perhaps try adding some
   more informative text now that you have a neat way to print it out.
   
9) We'd like to enhance the calculator to operate on dates as well as numbers. Specifically, we'll add support for taking a date, and adding a number
   of days to it.
   
10) Your Calculator application is getting quite large. Hopefully you've split it up into reasonably small and self-describing methods, but that's still a lot
    of code to lump together into a single file. Let's split it up a bit.
    A sensible structure for your Calculator program would be the following:
            A main class, which you might leave with the default name Program, which contains the Main method and works out whether you want
            numbers mode or dates mode.
            A separate class that deals with number calculations. Perhaps NumberCalculator.
            Another class that deals with date calculations. Perhaps DateCalculator.
 
 
 **Tasks Still To-Do**
 
 11) The videos demonstrate how to write some text to a file. The method used just replaces the entire file though. Do some searching in the Microsoft
     documentation to work out how you can append text to a file. Use this knowledge to add a log to your Calculator program - it should record every
     calculation performed.
     Ideally:
             Clear the log when the program starts up
             Print each calculation as a separate line in the log file
             Create your logging code in a separate class, avoiding static methods where possible, to make it reusable in future
             
 12) You should already have some code that takes an array of numbers and performs calculations on them (e.g. adds them all up). Modify this code
     to use LINQ queries. LINQ methods will work fine on arrays, so no need to change that - just replace e.g. the adding up code with suitable LINQ
     queries.
     To get you started, here are a few useful methods:
             Sum - adds up all the numbers in a collection
             Aggregate - applies an operation repeatedly to all the values in a collection. Each result is passed as an input to the next operation
             Skip - returns a collection which consists of everything in the original collection, except the first N elements
     You'll want to look up the details in the Microsoft documentation. There are other methods that may be useful so feel free to hunt them down too,
     although the above would be enough to complete the challenge.
     
  13) You can keep using arrays, as pointed out above, but just for practice try replacing all your arrays with Lists. Use this as an opportunity to avoid
      having to ask how many numbers to add up up-front.
      
  14) Your Calculator probably has a block of code that consists of a series of if tests to decide which operation to carry out (+, -, *, /). Replace this
      with a switch statement.
      This may highlight, if you haven't already handled it, the fact that the user might enter an operation that isn't supported. Let's handle that case
      using an exception:
              Have your code throw an exception in this case. You can cause an exception to happen using throw new Exception("Helpful
              message"). (In practice you'd probably want something more specific than just Exception, like the examples in the video. Feel free to
              do some research on how to define your own exception class for this scenario, and throw that instead).
              Run your code and check that the program now fails in a suitably fatal manner.
              In your main program loop, handle that exception via try...catch, print out a suitable error message, and keep the program going.
              Run your code again, and check that the exception is no longer fatal!

   15) If you followed the sample code in an earlier exercise, your main loop consists of a couple of constants (const) to decide between number and
       date calculations. Replace these constants with an enum to achieve the same effect.
    