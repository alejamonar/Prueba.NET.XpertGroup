using System;
using System.Collections.Generic;
using System.Text;

namespace WSNegocios
{
	class RectangularArrays
	{
		public RectangularArrays()
		{
		}

		internal static long[][][] ReturnRectangularLongArray(int size1, int size2, int size3)
		{
			try
			{
				long[][][] newArray = new long[size1][][];
				for (int array1 = 0; array1 < size1; array1++)
				{
					newArray[array1] = new long[size2][];
					if (size3 > -1)
					{
						for (int array2 = 0; array2 < size2; array2++)
						{
							newArray[array1][array2] = new long[size3];
						}
					}
				}

				return newArray;
			}
			catch (InvalidCastException e)
			{

				throw (e);
			}
		}

	}
}
