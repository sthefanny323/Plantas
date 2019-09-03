using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Planta__Sthefanny_1709542;

namespace Planta_Sthefanny_1709542
{
	class Program
	{
		static void Main(string[] args)
		{
			Ornamental orn = new Ornamental();
			orn.Caracteristica = "verde";
			orn.Nome = "Bonsai";
			orn.ID = 1;


			Console.WriteLine("Planta: " + orn.ObterNome());


			foreach (var item in orn.GerarLista())
			{
				Console.WriteLine();
			}

			Console.ReadKey();
		}
	}
}
