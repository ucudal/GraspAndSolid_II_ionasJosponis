//-------------------------------------------------------------------------------
// <copyright file="Equipment.cs" company="Universidad Católica del Uruguay">
// Copyright (c) Programación II. Derechos reservados.
// </copyright>
//-------------------------------------------------------------------------------
using System;

namespace Full_GRASP_And_SOLID.Library
{
    public class ConsolePrinter
    {
        public static void PrintRecipe(Recipe recipe)
        {
            Console.WriteLine($"Receta de {recipe.FinalProduct.Description}:");
            foreach (Step step in recipe.steps)
            {
                Console.WriteLine($"{step.Quantity} de '{step.Input.Description}' " +
                    $"usando '{step.Equipment.Description}' durante {step.Time}");
            }
        }
    }
}
/*
La clase Recipe no cumplia con el principio SRP ya que tenia la responsabilidad de crear la receta e imprimirla.
Son dos distintas responsabilidades, por lo cual, claramente no cumple con SRP.
Para que cumpla con SRP se crea la clase ConsolePrinter con el metodo estatico PrintRecipe(). Ahora si 
cumple con SRP ya que la clase Recipe tiene una sola responsabilidad, y la clase ConsolePrinter() tambien.

*/