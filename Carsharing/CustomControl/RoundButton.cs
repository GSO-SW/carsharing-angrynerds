using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;

namespace CustomControl
{
	public class RoundButton : Button
	{
		protected override void OnPaint(PaintEventArgs pevent)
		{
			GraphicsPath path = new GraphicsPath();
			path.FillMode = FillMode.Winding;
			path.AddEllipse(0, 0, Height, Height);
			path.AddEllipse(Width - Height, 0, Height, Height);			
			path.AddRectangle(new Rectangle(Height / 2, 0, Width - Height, Height));
			this.Region = new Region(path);
			base.OnPaint(pevent);
		}
	}
}
