using System;
using System.Collections.Generic;
using System.Text;

namespace WindowsForms
{
    public static class Zoologico
    {
        private static List<Animal> lista_animales = new List<Animal>();
        private static List<Cuidador> lista_cuidadores = new List<Cuidador>();

        public static void nuevoCuidador(Cuidador cuidador) 
        {
            lista_cuidadores.Add(cuidador);
        }

        public static void nuevoAnimal(Animal animal) {

            lista_animales.Add(animal);
        }

        public static void actualizarCuidador(int legajo)
        {
            foreach (var item in lista_cuidadores)
            {
                if (legajo == item.getLegajo())
                {
                    Console.Write("nuevo nombre: ");
                    item.nombre = Console.ReadLine();
                    Console.WriteLine("actualizado.");
                    return;
                }
                Console.WriteLine("no existe ese legajo.");
            }
        }
        public static void eliminarCuidador(int legajo)
        {
            foreach (var item in lista_cuidadores)
            {
                if (legajo == item.getLegajo())
                {
                    if (lista_cuidadores.Remove(item))
                    {
                        Console.WriteLine("eliminado.");
                        return;
                    }else Console.WriteLine("no se pudo eliminar");
                    return;
                }
                Console.WriteLine("no existe ese legajo.");
            }
        }

        public static void actualizarAnimal(int legajo)
        {
            foreach (var item in lista_animales)
            {
                if (legajo == item.legajo)
                {
                    Console.Write("nuevo nombre: ");
                    item.nombre = Console.ReadLine();
                    Console.Write("nueva especie: ");
                    item.especie = Console.ReadLine();
                    Console.Write("nueva comida: ");
                    item.comida = Console.ReadLine();

                    Console.WriteLine("actualizado.");
                    return;
                }
                Console.WriteLine("no existe ese legajo.");
            }
        }

        public static void eliminarAnimal(int legajo)
        {
            foreach (var item in lista_animales)
            {
                if (legajo == item.legajo)
                {
                    if (lista_animales.Remove(item))
                    {
                        Console.WriteLine("eliminado.");
                        return;
                    }
                    else Console.WriteLine("no se pudo eliminar");
                    return;
                }
                Console.WriteLine("no existe ese legajo.");
            }
        }

        public static void listarAnimales() {

            foreach (var item in lista_animales)
            {
                item.presentarse();
            }
        }
        public static List<Animal> getListaAnimal()
        {
            return lista_animales;
        }
        public static List<Cuidador> getListaCuidador()
        {
            return lista_cuidadores;
        }
    }
}
