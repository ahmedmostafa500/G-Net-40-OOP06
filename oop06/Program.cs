using System.ComponentModel;
using System.ComponentModel.Design;
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
        #region question3
        // a) Can you write: Appliance a = new Appliance("LG"); ? Why or why not?
        //     No, you cannot.
        //   Reason:
        // Appliance is declared as an abstract class.
        // In C#, abstract classes cannot be instantiated directly. They are meant to be base classes for other classes.
        //They may contain abstract methods that are not implemented yet, so the class itself is incomplete.

        //b) Difference between the three methods
        //1- PowerConsumption()
        //Type: abstract
        //Meaning:
        //It has no implementation in the base class.
        //Every subclass must implement it using override.
        //Why the designer made it abstract:
        //Because each appliance has different power consumption.

        //2-Status()
        // Type: virtual
        // Meaning:
        // It has a default implementation.
        // Subclasses may override it, but they are not required to.
        // Why the designer made it virtual:
        // most appliances might be in "Standby", but some appliances might need a different status.

        //3-Label()
        //  Type: Concrete method
        //  Meaning:
        //  It is fully implemented in the base class.
        //  Subclasses cannot override it unless it is marked virtual.
        //  Why the designer made it concrete:
        //  Because all appliances can share the same labeling logic.


        //c) If you call Status() on a Toaster object
        //Output:Standby
            //Reason:
            //Because the Toaster class does not override Status().
            //So C# uses the default implementation from the base class:


            #endregion

        #endregion
        }
    }
}
