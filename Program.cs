// See https://aka.ms/new-console-template for more information
using System;
using System.Collections.Generic;

namespace Objetos
{
	class Program
	{
		static void Main(string[] args)
		{
			List<IVolador> aves = new List<IVolador>();
			var pato1 = new Pato();
			var pato2 = new Pato();
			var pato3 = new Pato();
			var gallina1 = new Gallina();
			aves.Add(pato1);
			aves.Add(pato2);
			aves.Add(pato3);
			aves.Add(gallina1);

			Avolar(aves);
		}

		static void Avolar(List<IVolador> aves)
		{

			foreach (var ave in aves)
			{
				ave.Vuela();
			}

		}


		interface IVolador
		{
			public void Vuela();
		}

		interface ICaminador
		{

			public void Camina();
		}

		public class Pato : IVolador, ICaminador
		{
			public void Vuela()
			{
				Console.WriteLine("El pato vuela");

			}
			public void Camina()
			{
				Console.WriteLine("El pato camina");

			}


		}

		public class Gallina : IVolador
		{
			public void Vuela()
			{

				Console.WriteLine("La gallina vuela");
			}

		}


	}

}
