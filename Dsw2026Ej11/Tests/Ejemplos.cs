using Dsw2026Ej11.Collections;
using Dsw2026Ej11.Domain;

namespace Dsw2026Ej11.Tests;


internal class Ejemplos
{
    //Agregar 3 alumnos a la lista
    //Listar por consola los alumnos
    //Buscar por nombre un alumno que exista y mostrar por consola
    //Buscar por nombre un alumno que no exista y mostrar por consola el texto "No existe"
    //Eliminar un alumno y listar por consola los alumnos
    //Eliminar el primer elemento de la lista y listar por consola los alumnos
    public static void EjemploList()
    {
        CasoList miCasoList = new CasoList();
        Alumno alumno1 = new Alumno(1, "Camila Carabajal", 7.0);
        Alumno alumno2 = new Alumno(2, "Juan Perez", 9.0);
        Alumno alumno3 = new Alumno(3, "Pedro Juarez", 6.0);

        miCasoList.AgregarAlumno(alumno1);
        miCasoList.AgregarAlumno(alumno2);
        miCasoList.AgregarAlumno(alumno3);

        Console.WriteLine("--- Lista de Alumnos ---");
        foreach (Alumno a in miCasoList.ObtenerLista())
        {
            Console.WriteLine(a.ToString());
        }

        Console.WriteLine("\n ---Buscando a 'Juan Perez' ---");
        Alumno encontrado = miCasoList.BuscarAlumno("Juan Perez");
        if (encontrado != null )
        {
            Console.WriteLine("Encontrado: " + encontrado.ToString());
        }

        Console.WriteLine("\n--- Buscando a 'Mario Rodriguez' ---");
        Alumno noEncontrado = miCasoList.BuscarAlumno("Mario Rodriguez");
        if (noEncontrado == null)
        {
            Console.WriteLine("No existe");
        }

        Console.WriteLine("\n--- Eliminando a 'Camila Carabajal' ---");
        miCasoList.EliminarAlumno(alumno1);
        foreach (Alumno a in miCasoList.ObtenerLista())
        {
            Console.WriteLine(a.ToString());
        }

        Console.WriteLine("\n--- Eliminando el 1er elemento ---");
        miCasoList.EliminarAlumnoEnPosicion(0);
        foreach (Alumno a in miCasoList.ObtenerLista())
        {
            Console.WriteLine(a.ToString());
        }

    }

    //Agregar 3 alumnos al diccionario
    //Listar por consola los alumnos
    //Buscar un alumno por clave y mostrar por consola
    //Buscar un alumno por clave, pero que no exista, y mostrar por consola el texto "No existe"
    //Eliminar un alumno por clave y listar por consola los alumnos
    public static void EjemploDictionary()
    {
        CasoDictionary miCasoDict = new CasoDictionary();
        Alumno alumno1 = new Alumno(101, "Ana Romano", 8.0);
        Alumno alumno2 = new Alumno(102, "Luis Soria", 6.5);
        Alumno alumno3 = new Alumno(103, "Sofia Castro", 9.5);

        miCasoDict.AgregarAlumno(alumno1.Id, alumno1);
        miCasoDict.AgregarAlumno(alumno2.Id, alumno2);
        miCasoDict.AgregarAlumno(alumno3.Id, alumno3);

        Console.WriteLine("\n\n--- Diccionario de alumnos ---");
        foreach (var item in miCasoDict.ObtenerDiccionario())
        {
            Console.WriteLine("Clave " + item.Key + " -> " + item.Value.ToString());
        }

        Console.WriteLine("\n--- Buscando clave '102' ---");
        Alumno encontrado = miCasoDict.BuscarAlumno(102);
        if (encontrado != null)
        {
            Console.WriteLine("Encontrado: " + encontrado.ToString());
        }

        Console.WriteLine("\n--- Buscando clave '109' ---");
        Alumno noEncontrado = miCasoDict.BuscarAlumno(109);
        if (noEncontrado == null)
        {
            Console.WriteLine("No existe");
        }

        Console.WriteLine("\n--- Eliminando clave '101' ---");
        miCasoDict.EliminarAlumno(101);
        foreach (var item in miCasoDict.ObtenerDiccionario())
        {
            Console.WriteLine("Clave " + item.Key + " -> " + item.Value.ToString());
        }

    }

    //Realizar una llamada a cada método definido en CasoLinq y mostar por consola según corresponda
    public static void EjemploLinq()
    {
        CasoLinq miCasoLinq = new CasoLinq();

        Console.WriteLine("\n\n--- Ejemplo de Linq con libros ---");

        Console.WriteLine("Primer libro: " + miCasoLinq.GetPrimero().Titulo);

        Console.WriteLine("Último libro: " + miCasoLinq.GetUltimo().Titulo);

        Console.WriteLine("Suma total de precios: " + miCasoLinq.GetTotalPrecios().ToString("C"));

        Console.WriteLine("Promedio de precios: " + miCasoLinq.GetPromedioPrecios().ToString("C"));

        Console.WriteLine("\n--- Libros con ID mayor a 15 ---");
        foreach (var libro in miCasoLinq.GetListById())
        {
            Console.WriteLine(libro.Id + " - " + libro.Titulo);
        }

        Console.WriteLine("\n--- Lista de strings (Titulo - Precio) ---");
        foreach (string str in miCasoLinq.GetLibros())
        {
            Console.WriteLine(str);
        }

        Console.WriteLine("\nLibro más caro: " + miCasoLinq.GetMayorPrecio().Titulo);

        Console.WriteLine("Libro más barato: " + miCasoLinq.GetMenorPrecio().Titulo);

        Console.WriteLine("\n--- Libros por encima del precio promedio ---");
        foreach (var libro in miCasoLinq.GetMayorPromedio())
        {
            Console.WriteLine(libro.Titulo + " (" + libro.Precio.ToString("C") + ")");
        }

        Console.WriteLine("\n--- Libros ordenados alfabéticamente (Z-A) ---");
        foreach (var libro in miCasoLinq.GetLibrosOrdenados())
        {
            Console.WriteLine(libro.Titulo);
        }
    }
}
