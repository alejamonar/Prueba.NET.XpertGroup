using System;
using WSNegocios;


namespace ConsoleApp1
{
    class Program
    {
		public static void Main(string[] args)
        {
			Console.Write("\n Ingrese UPDATE O QUERY \n");
			Console.Write("------------------------------------------------------\n");

			string tipoConsulta = Console.ReadLine();
			string elementos = "";

			if (tipoConsulta.Equals("UPDATE"))
			{
				Console.Write("Ingrese los elementos  x y z W :\n");
				elementos = Console.ReadLine();
				char delimiter = ' ';
				string[] parteElemento = elementos.Split(delimiter);

				CuboNegocio cubo = new CuboNegocio(0);
				int a =  Convert.ToInt32(parteElemento[1]) - 1;
				cubo.update(Convert.ToInt32(parteElemento[1]) - 1, Convert.ToInt32(parteElemento[2]) - 1, Convert.ToInt32(parteElemento[3]) - 1, Convert.ToInt32(parteElemento[4]));
			}
			if (tipoConsulta.Equals("QUERY"))
			{
				Console.Write("Ingrese los elementos x1 y1 z1 x2 y2 z2 :\n");
				elementos = Console.ReadLine();
				char delimiter = ' ';
				string[] parteElemento = elementos.Split(delimiter);
				CuboNegocio cubo = new CuboNegocio(0);
				cubo.query(Convert.ToInt32(parteElemento[1]) - 1, Convert.ToInt32(parteElemento[2]) - 1, Convert.ToInt32(parteElemento[3]) - 1, Convert.ToInt32(parteElemento[4]) - 1, Convert.ToInt32(parteElemento[5]) - 1, Convert.ToInt32(parteElemento[6]) - 1);
			}


		}

	}
}
