using System;
using NUnit.Framework;
using SwinGameSDK;

namespace MyGame
{
	[TestFixture ()]
	public class ShapeTest
	{
		[Test ()]
		public void TestShapeAt ()
		{
			//Setup
			Shape s = new Shape ();

			s.X = 25;
			s.Y = 25;
			s.Width = 50;
			s.Height = 50;

			//Perform and Check
			Assert.IsTrue (s.IsAt (SwinGame.PointAt (50, 50)));
			Assert.IsTrue (s.IsAt (SwinGame.PointAt (25, 25)));
			Assert.IsFalse (s.IsAt (SwinGame.PointAt (10, 50)));
			Assert.IsFalse (s.IsAt (SwinGame.PointAt (50, 10)));
		}

		[Test ()]
		public void TestShapeAtWhenMoved ()
		{
			Shape s = new Shape ();

			//Old Position
			s.X = 25;
			s.Y = 25;
			s.Width = 50;
			s.Height = 50;

			//New Position
			s.X = 50;
			s.Y = 50;

			//Checking Whether If At Old Position
			Assert.IsFalse (s.IsAt (SwinGame.PointAt (25, 25)));
		}

		[Test ()]
		public void TestShapeAtWhenResized ()
		{
			Shape s = new Shape ();

			//Old Size
			s.X = 25;
			s.Y = 25;
			s.Width = 50;
			s.Height = 50;

			//New Size
			s.Width = 25;
			s.Height = 25;

			//Checking Whether If Its Same Size
			Assert.IsFalse (s.IsAt (SwinGame.PointAt (60, 60)));
		}
	}
}
