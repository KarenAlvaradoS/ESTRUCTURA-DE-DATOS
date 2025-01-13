using System;
using System.Collections.Generic;

class Contacto
{
    public string Nombre { get; set; }
    public string Telefono { get; set; }

    public Contacto(string nombre, string telefono)
    {
        Nombre = nombre;
        Telefono = telefono;
    }
}

class Agenda
{
    private Dictionary<string, string> contactos;

    public Agenda()
    {
        contactos = new Dictionary<string, string>();
    }

    public void AgregarContacto(string nombre, string telefono)
    {
        if (contactos.ContainsKey(nombre))
        {
            Console.WriteLine($"El contacto {nombre} ya existe.");
        }
        else
        {
            contactos[nombre] = telefono;
            Console.WriteLine($"Contacto {nombre} agregado correctamente.");
        }
    }

    public void EliminarContacto(string nombre)
    {
        if (contactos.ContainsKey(nombre))
        {
            contactos.Remove(nombre);
            Console.WriteLine($"Contacto {nombre} eliminado correctamente.");
        }
        else
        {
            Console.WriteLine($"El contacto {nombre} no existe.");
        }
    }

    public void BuscarContacto(string nombre)
    {
        if (contactos.ContainsKey(nombre))
        {
            Console.WriteLine($"{nombre}: {contactos[nombre]}");
        }
        else
        {
            Console.WriteLine($"El contacto {nombre} no se encuentra en la agenda.");
        }
    }

    public void MostrarContactos()
    {
        if (contactos.Count == 0)
        {
            Console.WriteLine("La agenda está vacía.");
        }
        else
        {
            foreach (var contacto in contactos)
            {
                Console.WriteLine($"{contacto.Key}: {contacto.Value}");
            }
        }
    }
}

class Program
{
    static void Main(string[] args)
    {
        Agenda agenda = new Agenda();

        while (true)
        {
            Console.WriteLine("\nOpciones:");
            Console.WriteLine("1. Agregar contacto");
            Console.WriteLine("2. Mostrar contactos");
            Console.WriteLine("3. Buscar contacto");
            Console.WriteLine("4. Eliminar contacto");
            Console.WriteLine("5. Salir");
            Console.Write("Seleccione una opción: ");

            string opcion = Console.ReadLine();

            switch (opcion)
            {
                case "1":
                    Console.Write("Ingrese el nombre: ");
                    string nombre = Console.ReadLine();
                    Console.Write("Ingrese el teléfono: ");
                    string telefono = Console.ReadLine();
                    agenda.AgregarContacto(nombre, telefono);
                    break;

                case "2":
