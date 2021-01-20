using System;
using SwinGameSDK;
using System.Collections.Generic;

namespace MyGame
{

    public class GameMain
    {
        public static void Main()
		{
            //Open the game window
            SwinGame.OpenGraphicsWindow("GameMain", 800, 600);
            SwinGame.ShowSwinGameSplashScreen();

			Drawing draw = new Drawing ();

            //Run the game loop
            while(false == SwinGame.WindowCloseRequested())
            {
                //Fetch the next batch of UI interaction
                SwinGame.ProcessEvents();
                
                //Clear the screen and draw the framerate
                SwinGame.ClearScreen(Color.White);
                SwinGame.DrawFramerate(0,0);

				if (SwinGame.MouseClicked (MouseButton.LeftButton)) 
				{
					Shape s = new Shape ();
					s.X = SwinGame.MouseX ();
					s.Y = SwinGame.MouseY ();
					draw.AddShape (s);
				}

				if (SwinGame.KeyTyped (KeyCode.vk_SPACE)) {
					draw.Background = SwinGame.RandomRGBColor (255);
				}

				if (SwinGame.MouseClicked (MouseButton.RightButton)) 
				{
					draw.SelectShapesAt (SwinGame.MousePosition());
				}

				if (SwinGame.KeyTyped (KeyCode.vk_DELETE)) {
					List<Shape> xList = draw.SelectedShape;
					foreach (Shape s in xList) {
						draw.RemoveShape (s);
					}                     
				}
				   
				draw.Draw ();

                //Draw onto the screen
                SwinGame.RefreshScreen(60);
            }
        }
    }
}