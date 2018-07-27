using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

using WSEntidades;
using WSNegocios;

namespace WcfService1
{
    // NOTE: If you change the class name "ServiceCubo" here, you must also update the reference to "ServiceCubo" in Web.config.
    public class ServiceCubo : IServiceCubo
    {
		public Cubo CubeSummation(int dimensions)
		{
			CuboNegocio cubon = new CuboNegocio(dimensions);
			Cubo cubo = new Cubo();
			
			return cubo;
		}

		public Cubo CubeSummation()
		{
			throw new NotImplementedException();
		}
	}
}
