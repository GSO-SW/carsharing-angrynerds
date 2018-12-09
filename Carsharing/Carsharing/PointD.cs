using MySql.Data.Types;

namespace Carsharing
{
	internal class PointD
	{
		#region Attributes
		private double x;
		private double y;
		#endregion

		#region Porperties
		/// <summary>
		/// X-Komponente des Points.
		/// </summary>
		internal double X
		{
			get { return x; }
			set { x = value; }
		}

		/// <summary>
		/// Y-Komponente des Points.
		/// </summary>
		internal double Y
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
		internal PointD(double x, double y)
		{
			this.x = x;
			this.y = y;
		}

		/// <summary>
		/// 
		/// </summary>
		/// <param name="point"></param>
		internal PointD(PointD point)
		{
			this.x = point.X;
			this.y = point.Y;
		}

		internal PointD(MySqlGeometry mySqlGeometry)
		{
			this.x = (double)mySqlGeometry.XCoordinate;
			this.Y = (double)mySqlGeometry.YCoordinate;
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
