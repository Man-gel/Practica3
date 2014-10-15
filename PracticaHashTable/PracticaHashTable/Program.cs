/*
 * Created by SharpDevelop.
 * User: Usuario
 * Date: 14/10/2014
 * Time: 06:56 p. m.
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Collections;

namespace PracticaHashTable
{
	class Program
	{
		public Alumno alumno;
		public Hashtable tabla;
		
		public Program()
		{
			this.alumno = new Alumno();
			this.tabla = new Hashtable();
		}
		
		
		public void ingresarAlumno()
		{
			
			Console.WriteLine("Codigo Alumno:");
			alumno.codigo= Int32.Parse( Console.ReadLine() );
			
			Console.WriteLine("Nombre Alumno:");
			alumno.nombre = Console.ReadLine();
		}
		
		public void editarAlumno()
		{
			Console.WriteLine("Ingrese el codigo del alumno a editar:");
			String codigo = Console.ReadLine();
			if (this.tabla.ContainsKey(codigo))
			{
				tabla[codigo] = nombreAmodificar();
			}
			else
			{
				Console.Write("El codigo no esta registrado en la tabla !");
			    Console.ReadKey(true);
			}
		}
		
		private String nombreAmodificar()
		{
			String nuevoNombre;
			Console.WriteLine("Ingrese el Nuevo nombre:");
			nuevoNombre = Console.ReadLine();
			return nuevoNombre;
		}
		
		
		public static void Main(string[] args)
		{
			Program pruebaPractica = new Program();
			pruebaPractica.ingresarAlumno();
			
			Console.Write("Press any key to continue . . . ");
			Console.ReadKey(true);
		}
	}
}