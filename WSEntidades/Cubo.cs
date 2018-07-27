using System;
using System.Collections.Generic;
using System.Text;
using System.Runtime.InteropServices;
using System.Runtime.Serialization;

namespace WSEntidades
{
	[DataContract]
	[Serializable]
	public class Cubo
	{

		public string tipoConsulta;
		public string parteElemento;
		public long[][][] tree;
		public long[][][] nums;
		public int dimensions = 0;


		/// <summary>
		/// Gets or sets TipoConsulta
		/// </summary>
		[DataMember]
		public string TipoConsulta
		{
			get
			{
				return tipoConsulta;
			}
			set
			{
				tipoConsulta = value;
			}
		}

		/// <summary>
		/// Gets or sets ParteElemento
		/// </summary>
		[DataMember]
		public string ParteElemento
		{
			get
			{
				return parteElemento;
			}
			set
			{
				parteElemento = value;
			}
		}

		/// <summary>
		/// Gets or sets Tree
		/// </summary>
		[DataMember]
		public long[][][] Tree
		{
			get
			{
				return tree;
			}
			set
			{
				tree = value;
			}
		}

		/// <summary>
		/// Gets or sets Nums
		/// </summary>
		[DataMember]
		public long[][][] Nums
		{
			get
			{
				return nums;
			}
			set
			{
				nums = value;
			}
		}

		/// <summary>
		/// Gets or sets Dimensions
		/// </summary>
		[DataMember]
		public int Dimensions
		{
			get
			{
				return dimensions;
			}
			set
			{
				dimensions = value;
			}
		}
		
	}
}
