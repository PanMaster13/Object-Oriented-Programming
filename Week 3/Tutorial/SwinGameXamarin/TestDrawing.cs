using System;
using NUnit.Framework;
using System.Collections.Generic;
using SwinGameSDK;

namespace MyGame
{
	[TestFixture()]
	public class TestDrawing
	{
		[Test()]
		public void TestConstructorWithParameter ()
		{
			Drawing d = new Drawing (Color.Red);

			Assert.AreEqual (Color.Red, d.Background);
			Assert.IsNotNull (d.Shapes);
		}

		[Test()]
		public void TestConstructorWithoutParameter ()
		{
			Drawing d = new Drawing ();

			Assert.AreEqual (Color.White, d.Background);
			Assert.IsNotNull (d.Shapes);
		}

		[Test ()]
		public void TestAddShape ()
		{
			Drawing d = new Drawing ();
			int numOfShape = d.ShapeCount;

			Assert.AreEqual (0, numOfShape, "Initialization should have no shape(s) in List");

			d.AddShape (new Shape ());
			d.AddShape (new Shape ());

			numOfShape = d.ShapeCount;

			Assert.AreEqual (2, numOfShape, "Two shapes have been added");
		}
	}
}
