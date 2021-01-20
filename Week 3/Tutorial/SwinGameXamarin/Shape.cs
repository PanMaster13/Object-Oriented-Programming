using System;
using SwinGameSDK;

namespace MyGame
{
	public class Shape
	{
		private Color _color;
		private float _x;
		private float _y;
		private int _width;
		private int _height;
		private bool _selected;

		public Shape ()
		{
			_color = Color.Green;
			_x = 0;
			_y = 0;
			_width = 100;
			_height = 100;
			_selected = false;
		}

		public Color Color {
			get { return _color; }
			set { _color = value; }
		}

		public float X {
			get { return _x; }
			set { _x = value; }
		}

		public float Y {
			get { return _y; }
			set { _y = value; }
		}

		public int Width {
			get { return _width; }
			set { _width = value; }
		}

		public int Height {
			get { return _height; }
			set { _height = value; }
		}

		public bool Selected {
			get {
				return _selected;
			}

			set {
				_selected = value;
			}
		}

		public void Draw ()
		{
			SwinGame.FillRectangle (_color, _x, _y, _width, _height);
			if (_selected == true) {
				DrawOutline ();
			}
		}

		public bool IsAt (Point2D pt)
		{
			bool TrueOrFalse = SwinGame.PointInRect (pt, _x, _y, _width, _height);

			return TrueOrFalse;
		}

		public void DrawOutline ()
		{
			float olX = _x - 2;
			float olY = _y - 2;
			int olW = _width + 4;
			int olH = _height + 4;

			SwinGame.DrawRectangle (Color.Black, olX, olY, olW, olH);
		}
	}
}
