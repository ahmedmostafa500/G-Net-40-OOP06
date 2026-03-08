using System.ComponentModel;
using System.Diagnostics;
using System.IO;
using System.Numerics;
using System.Security.Claims;
using Microsoft.VisualBasic;

namespace oop06
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region part1
            #region question1
            //  1-Abstraction in OOP:
            //  Abstraction means showing only the important features of an object and hiding the complex implementation details.            
            //  The user interacts with what the object does, not how it does it internally.

            //  Main Difference:
            //   Abstraction:
            //  Hiding implementation details
            //  Simplify usage

            // Encapsulation:
            // Protecting data inside a class
            //Control access to data

            //Real - World Example: Car 
            // Abstraction
            // When you drive a car:
            // You use steering wheel, accelerator, and brake.
            // You don’t know how the engine, fuel injection, or transmission works internally.
            // So the car abstracts the complex engine system and only shows the controls you need.

            // Encapsulation
            //Inside the car:
            //The engine system, fuel system, and electronics are enclosed and protected.
            //You cannot directly change the fuel injection system or engine timing.
            //Only specific mechanisms(like pedals and dashboard controls) allow interaction.
            //The internal components are encapsulated and protected from direct access.
            #endregion
            #region question2
            //What is the difference between an abstract class and an interface?
            // Abstract Class: A base class that can contain both implemented methods and abstract methods.
            //Interface: A contract that only defines what methods a class must implement.

          //  When to Use Each One
          //Use an Abstract Class when:
          //Classes are closely related.
          //You want to share code or fields between classes.
          //You want partial implementation in the base class.


          //Use an Interface when:
          //Different classes need the same capability.
          //The classes are not closely related.
          //You want multiple inheritance of behavior.
            #endregion
        #endregion
        }
    }
}
