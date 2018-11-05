using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CustomControl
{
	public class WatermarkTextBox : TextBox
	{
		public string Watermark { get; set; }
		public bool Password { get; set; }

		protected override ControlCollection CreateControlsInstance()
		{
			if (string.IsNullOrWhiteSpace(Text))
			{
				ForeColor = Color.FromArgb(73, 73, 73);
				Text = Watermark;
			}
			return base.CreateControlsInstance();
		}

		protected override void OnEnter(EventArgs e)
		{
			if (Text == Watermark)
			{
				if (Password)
					UseSystemPasswordChar = true;
				ForeColor = Color.FromArgb(0, 0, 0);
				Text = null;
			}
			base.OnEnter(e);
		}

		protected override void OnLeave(EventArgs e)
		{
			if (string.IsNullOrEmpty(Text))
			{
				if (Password)
					UseSystemPasswordChar = false;
				ForeColor = Color.FromArgb(73, 73, 73);
				Text = Watermark;
			}
			base.OnLeave(e);
		}
	}
}
