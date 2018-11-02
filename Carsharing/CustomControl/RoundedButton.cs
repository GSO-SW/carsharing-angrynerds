using System;
using System.Windows.Forms;
using System.Drawing;
using System.ComponentModel;
using System.Drawing.Drawing2D;

namespace CustomControl
{
	public class RoundedButton : Button
	{
		public int Rounded { get; set; }

		protected override void OnPaint(PaintEventArgs pevent)
		{
			GraphicsPath path = new GraphicsPath();
			path.FillMode = FillMode.Winding;
			path.AddEllipse(0, 0, Rounded, Rounded);
			path.AddEllipse(Width - Rounded, 0, Rounded, Rounded);
			path.AddEllipse(0, Height - Rounded, Rounded, Rounded);
			path.AddEllipse(Width - Rounded, Height - Rounded, Rounded, Rounded);
			path.AddRectangle(new Rectangle(Rounded / 2, 0, Width - Rounded, Height));
			path.AddRectangle(new Rectangle(0, Rounded / 2, Width, Height - Rounded));
			this.Region = new Region(path);
			base.OnPaint(pevent);
		}
	}
}
