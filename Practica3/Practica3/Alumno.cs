
using System;

namespace PracticaHashTable
{
	public class Alumno
	{
		private String nombre;
		private int codigo;

		public Alumno()
		{
			this.nombre ="";
			this.codigo = 0;
		}
		public void ajustarNombre(String nombre)
		{
			this.nombre = nombre;
		}
		public void ajustarCodigo(int codigo)
		{
			this.codigo = codigo;
		}
		public String obtenerNombre()
		{
			return this.nombre;
		}
		public int obtenerCodigo()
		{
			return this.codigo;
		}
		
		override public String ToString()
		{
			String formato =obtenerCodigo() + " , " + obtenerNombre();
			return formato;		
		}
	}
}
