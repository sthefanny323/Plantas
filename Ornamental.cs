using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Planta_Sthefanny_1709542
{
	public class Ornamental : Planta
	{
		public string Paisagismo { get; set; }
		public string GerarHash()
		{
			return "";
		}
		public Ornamental()
		{

		}
		public Ornamental(string _paisagismo)
		{
			Paisagismo = _paisagismo;
		}
		public List<object> GerarLista()
		{
			List<object> listaPlantas = new List<object>();
			listaPlantas.Add(new Ornamental("Bonsai"));
			return listaPlantas;
		}

	}
}
