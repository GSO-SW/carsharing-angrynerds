using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Carsharing
{
	public class Point
	{
		#region Attributes
		private double x;
		private double y;
		#endregion

		#region Porperties
		/// <summary>
		/// X-Komponente des Points.
		/// </summary>
		public double X
		{
			get { return x; }
			set { x = value; }
		}

		/// <summary>
		/// Y-Komponente des Points.
		/// </summary>
		public double Y
		{
			get { return y; }
			set { y = value; }
		}
		#endregion

		/// <summary>
		/// 
		/// </summary>
		/// <param name="x"></param>
		/// <param name="y"></param>
		public Point(double x, double y)
		{
			this.x = x;
			this.y = y;
		}

		/// <summary>
		/// 
		/// </summary>
		/// <param name="point"></param>
		public Point(Point point)
		{
			this.x = point.X;
			this.y = point.Y;
		}

		/// <summary>
		/// 
		/// </summary>
		/// <returns></returns>
		public override string ToString()
		{
			return x + " " + y;
		}
	}
}
