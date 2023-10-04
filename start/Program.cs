using System;
using pizzeria;
using pizzeria.Strategies;

Cooker cooker = new("Василий");

cooker.Setpizzaria(new carbonara());
cooker.Cook();
Console.ReadLine();
