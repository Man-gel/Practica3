using System;
using System.Collections;
namespace PracticaHashTable
{
	class Program
	{
		private Hashtable tabla;

		public Program()
		{
			this.tabla = new Hashtable();
		}


		private Alumno definirAlumno()
		{
			Alumno alumno = new Alumno();
			Console.WriteLine();
			Console.WriteLine("Codigo Alumno:");
			alumno.ajustarCodigo( Int32.Parse( Console.ReadLine() ) );
			Console.WriteLine();
			Console.WriteLine("Nombre Alumno:");
			alumno.ajustarNombre( Console.ReadLine() );
			return alumno;
		}
		
		private String nombreAmodificar()
		{
			String nuevoNombre;
			Console.WriteLine("Ingrese el Nuevo nombre:");
			nuevoNombre = Console.ReadLine();
			return nuevoNombre;
		}
		
		private Alumno tomarValordeTabla (Alumno alumnoAmodificar, String nombreNuevo)
		{
			alumnoAmodificar.ajustarNombre( nombreNuevo );
			return alumnoAmodificar;
		}

		public void editarAlumno()
		{
			Console.WriteLine("Ingrese el codigo del alumno a editar:");
			int codigo = Int32.Parse( Console.ReadLine() );
			if (this.tabla.ContainsKey(codigo))
			{
				tomarValordeTabla( (Alumno)this.tabla[codigo] , nombreAmodificar() );
			}
			else
			{
				Console.Write("El codigo no esta registrado en la tabla !");
				Console.ReadKey(true);
			}
		}

		public void crearRegistroEnTabla()
		{
			Alumno alumnoAregistrar;
			alumnoAregistrar = definirAlumno();
			this.tabla.Add( alumnoAregistrar.obtenerCodigo(), alumnoAregistrar );
		}
		
		public void eliminarRegistroDeTabla()
		{
			Console.WriteLine("Ingrese el codigo del alumno a eliminar:");
			int codigo = Int32.Parse( Console.ReadLine() );
			if (this.tabla.ContainsKey(codigo))
			{
				this.tabla.Remove(codigo);
			}
			else
			{
				Console.Write("El codigo no esta registrado en la tabla !");
				Console.ReadKey(true);
			}
		}
		
		public void mostrarTabla()
		{
			if (this.tabla.Count == 0 )
			{
				Console.WriteLine("La Tabla esta VACIA!!");
			}else
				foreach (Alumno alumno in this.tabla.Values)
			{
				Console.WriteLine( alumno.ToString() );
			}
		}

		public static void Main(string[] args)
		{
			Program pruebaPractica = new Program();
			char eleccion ;
			Console.WriteLine("Quiere ingresar un nuevo alumno a la tabla (y/n) ?");
			eleccion = Char.Parse( Console.ReadLine() );
			while ( eleccion == 'y' || eleccion == 'Y')
			{
				pruebaPractica.crearRegistroEnTabla();
				Console.WriteLine();
				Console.WriteLine("Quiere ingresar un nuevo alumno a la tabla (y/n) ?");
				eleccion = Char.Parse( Console.ReadLine() );
			}
			while(eleccion != '5')
			{
				Console.WriteLine();
				Console.WriteLine("ACCIONES SOBRE LA TABLA:");
				Console.WriteLine("1.Editar un nombre");
				Console.WriteLine("2.Borrar un registro");
				Console.WriteLine("3.Ingresar otro registro");
				Console.WriteLine("4.Mostrar registros de la tabla");
				Console.WriteLine("5.SALIR.");
				Console.WriteLine(">> ELIJA OPCION <<:");
				eleccion = Char.Parse( Console.ReadLine() );
				Console.WriteLine();
				switch (eleccion)
				{
					case '1':
						pruebaPractica.editarAlumno();
						break;
					case '2':
						pruebaPractica.eliminarRegistroDeTabla();
						break;
					case '3':
						pruebaPractica.crearRegistroEnTabla();
						break;
					case '4':
						pruebaPractica.mostrarTabla();
						break;
					case '5':
						eleccion = '5';
						break;
					default:
						Console.WriteLine("Esa opcion no es corecta!!");
						Console.WriteLine();
						break;
				}
			}
		}
	}
}