using System;
using System.Collections.Generic;

class Program
{
    static List<string> tareas = new List<string>();

    static void Main()
    {
        int opcion;

        do
        {
            Console.Clear();
            Console.WriteLine("=== GESTOR DE TAREAS ===");
            Console.WriteLine("1. Ver tareas");
            Console.WriteLine("2. Agregar tarea");
            Console.WriteLine("3. Eliminar tarea");
            Console.WriteLine("4. Salir");
            Console.Write("Elige una opción: ");

            opcion = int.Parse(Console.ReadLine());

            switch (opcion)
            {
                case 1:
                    VerTareas();
                    break;
                case 2:
                    AgregarTarea();
                    break;
                case 3:
                    EliminarTarea();
                    break;
            }

        } while (opcion != 4);
    }

    static void VerTareas()
    {
        Console.Clear();
        Console.WriteLine("=== TAREAS ===");

        if (tareas.Count == 0)
        {
            Console.WriteLine("No hay tareas.");
        }
        else
        {
            for (int i = 0; i < tareas.Count; i++)
            {
                Console.WriteLine($"{i + 1}. {tareas[i]}");
            }
        }

        Console.ReadKey();
    }

    static void AgregarTarea()
    {
        Console.Clear();
        Console.Write("Escribe la nueva tarea: ");
        string tarea = Console.ReadLine();
        tareas.Add(tarea);
        Console.WriteLine("Tarea agregada ✔");
        Console.ReadKey();
    }

    static void EliminarTarea()
    {
        VerTareas();
        Console.Write("Número de tarea a eliminar: ");
        int num = int.Parse(Console.ReadLine());

        if (num > 0 && num <= tareas.Count)
        {
            tareas.RemoveAt(num - 1);
            Console.WriteLine("Tarea eliminada ✔");
        }
        else
        {
            Console.WriteLine("Número inválido.");
        }

        Console.ReadKey();
    }
}