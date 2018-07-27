using System;
using System.Collections.Generic;
using System.Text;

using WSEntidades;

namespace WSDatos
{
    public class CuboDatos
	{
		public void Cubeelementos()
		{
			Cubo cubo = new Cubo();

			cubo.dimensions =  0;

			cubo.tipoConsulta = "UPDATE";
			cubo.ParteElemento = "2 2 2 4";

			cubo.tipoConsulta = "QUERY";
			cubo.ParteElemento = "1 1 1 3 3 3";

			cubo.tipoConsulta = "UPDATE";
			cubo.ParteElemento = "1 1 1 23";

			cubo.tipoConsulta = "QUERY";
			cubo.ParteElemento = "2 2 2 4 4 4";

			cubo.tipoConsulta = "QUERY";
			cubo.ParteElemento = "1 1 1 3 3 3";

			cubo.tipoConsulta = "UPDATE";
			cubo.ParteElemento = "2 2 2 1";

			cubo.tipoConsulta = "QUERY";
			cubo.ParteElemento = "1 1 1 1 1 1";

			cubo.tipoConsulta = "QUERY";
			cubo.ParteElemento = "1 1 1 2 2 2";

			cubo.tipoConsulta = "QUERY";
			cubo.ParteElemento = "2 2 2 2 2 2";

		}

	}
}
