using System;
using System.Collections.Generic;
using System.Text;

using WSEntidades;
using WSDatos;

namespace WSNegocios
{
	public class CuboNegocio 
	{
		public override bool Equals(object obj)
		{
			return base.Equals(obj);
		}

		public override int GetHashCode()
		{
			return base.GetHashCode();
		}

		
		public  CuboNegocio(int dimensions)
		{
			try
			{
				if (dimensions == 0)
				{
					throw new ArgumentNullException();
				}

				Cubo cubo = new Cubo()
				{
					dimensions = dimensions,
					tree = RectangularArrays.ReturnRectangularLongArray(dimensions + 1, dimensions + 1, dimensions + 1),
					nums = RectangularArrays.ReturnRectangularLongArray(dimensions, dimensions, dimensions)
				};
				
			}
			catch (InvalidCastException e)
			{

				throw (e);
			}
				
			
		}

		public virtual void update(int x, int y, int z, int value)
		{
			try
			{
				Cubo cubo = new Cubo();

				long delta = value - cubo.nums[x][y][z];
				cubo.nums[x][y][z] = value;
				for (int i = x + 1; i <= cubo.dimensions; i += i & (-i))
				{
					for (int j = y + 1; j <= cubo.dimensions; j += j & (-j))
					{
						for (int k = z + 1; k <= cubo.dimensions; k += k & (-k))
						{
							cubo.tree[i][j][k] += delta;
						}
					}
				}
			}
			catch (InvalidCastException e)
			{

				throw (e);
			}

			
		}

		public virtual void query(int x1, int y1, int z1, int x2, int y2, int z2)
		{
			try
			{
				long result = sum(x2 + 1, y2 + 1, z2 + 1) - sum(x1, y1, z1) - sum(x1, y2 + 1, z2 + 1) - sum(x2 + 1, y1, z2 + 1) - sum(x2 + 1, y2 + 1, z1) + sum(x1, y1, z2 + 1) + sum(x1, y2 + 1, z1) + sum(x2 + 1, y1, z1);
				Console.WriteLine(result);
			}
			catch (InvalidCastException e)
			{

				throw (e);
			}
		}

		public virtual long sum(int x, int y, int z)
		{
			try
			{
				Cubo cubo = new Cubo();
			long sum = 0l;
			for (int i = x; i > 0; i -= i & (-i))
			{
				for (int j = y; j > 0; j -= j & (-j))
				{
					for (int k = z; k > 0; k -= k & (-k))
					{
						sum += cubo.tree[i][j][k];
					}
				}
			}
			return sum;
			}
			catch (InvalidCastException e)
			{

				throw (e);
			}
		}

		public override string ToString()
		{
			return base.ToString();
		}

		
	}
}
