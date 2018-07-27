using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

using WSEntidades;

namespace WcfService1
{
    // NOTE: If you change the interface name "IServiceCubo" here, you must also update the reference to "IServiceCubo" in Web.config.
    [ServiceContract]
    public interface IServiceCubo
    {
		[OperationContract]
		Cubo CubeSummation(int dimension);

	}
}
