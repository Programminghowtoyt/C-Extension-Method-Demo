# C#-Extension-Method-Demo

source code of C# Online Tutorial https://www.youtube.com/watch?v=Eu_EFxdv578
How to extend an existing type with new functionality using c# Extension Method

Extension Methods - C# Programming Guide

What is Extension Method?
Suppose you have some xyz class which has two methods, you need to add a new method in it but you don't have access to its source code, or do not have permissions from the class definition, or the class is a sealed class,  but you still want to add a method in it.

This is the situation where you can add functionality in xyz class using extension method


C# extension method is a static method which should be defined inside a static class and should contain at least one parameter, the first preceded by the this keyword. The type of the first parameter will be the type that we want to extend.



