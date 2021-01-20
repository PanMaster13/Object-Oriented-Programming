using System;
using SwinGameSDK;
using System.Collections.Generic;

namespace MyGame
{
	public class Drawing
	{
		private readonly List<Shape> _shapes;
		private Color _background;

		public Drawing (Color background)
		{
			_background = background;
			_shapes = new List<Shape> ();
		}

		public Drawing () : this (Color.White)
		{
			
		}

		public Color Background 
		{
			get { return _background; }
			set { _background = value; }
		}

		public List<Shape> Shapes 
		{
			get { return _shapes; }
		}

		public int ShapeCount 
		{
			get { return _shapes.Count; }
		}

		public void AddShape (Shape s)
		{
			_shapes.Add (s);
		}

		public void Draw ()
		{
			SwinGame.ClearScreen (_background);
			foreach (Shape s in _shapes) 
			{
				s.Draw ();
			}
		}

		public void SelectShapesAt (Point2D pt)
		{
			foreach (Shape s in _shapes) {
				s.Selected = s.IsAt (pt);
			}
		}

		public List<Shape> SelectedShape
		{
			get {
				List<Shape> temp = new List<Shape> ();
				foreach (Shape s in _shapes) {
					if (s.Selected) {

						temp.Add (s);
					}
				}
				return temp;
			}
		}

		public void RemoveShape (Shape s)
		{
			_shapes.Remove (s);
		}
	}
}
