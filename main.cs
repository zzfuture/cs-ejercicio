// See https://aka.ms/new-console-template for more information
/*Console.WriteLine("Hello, World!");
bool ciclo = true;
while (ciclo == true){
    Console.Clear();
    Console.WriteLine("CAMPUSMD");
    Console.WriteLine("ADMINISTRACION DE CITAS MEDICAS");
    Console.WriteLine("1. Agregar cita medica");
    Console.WriteLine("2. Buscar cita medica");
    Console.WriteLine("3. Modificar cita medica");
    Console.WriteLine("4. Cancelar cita medica");
    Console.WriteLine("5. Salir del programa");
    Console.Write("Ingresa la opcion: ");
    int opcion = Convert.ToInt16(Console.ReadLine());
    if (opcion == 1){
        Console.WriteLine("Agregar cita medica");
        Console.WriteLine("Se ha agregado la cita medica");
        Console.Write("\nEnter para volver al menu...");
        Console.ReadLine();
    }
    else if (opcion == 2){
        Console.WriteLine("TABLA DE CITAS MEDICAS");
        Console.ReadLine();
    }
}
*/

using System;
using System.IO;
using System.Text.Json;

public class Core
{
    public static void Main()
    {
        // Leer un archivo JSON
        Console.Write("Nombre del archivo: ");
        string archivo = Console.ReadLine();
        string jsonString = File.ReadAllText($"data/{archivo}.json");
        Console.Write(jsonString);
        Console.ReadLine();
        // Deserializar el JSON a un objeto
        MiObjeto objeto = JsonSerializer.Deserialize<MiObjeto>(jsonString);

        // Acceder a los datos del objeto
        Console.WriteLine(objeto.Propiedad1);
        Console.WriteLine(objeto.Propiedad2);

        // Modificar los datos del objeto
        objeto.Propiedad1 = "Nuevo valor";
        objeto.Propiedad2 = 42;

        // Serializar el objeto a JSON
        string newJsonString = JsonSerializer.Serialize(objeto, new JsonSerializerOptions { WriteIndented = true });
        Console.WriteLine(newJsonString);
        // Escribir el JSON en un archivo
        File.WriteAllText("ruta_nuevo_archivo.json", newJsonString);
    }
}

public class MiObjeto
{
    public string Propiedad1 { get; set; }
    public int Propiedad2 { get; set; }
}