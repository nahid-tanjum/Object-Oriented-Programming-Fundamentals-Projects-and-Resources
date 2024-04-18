using System;
using SplashKitSDK;

namespace ShapeDrawer
{
    public class Program
    {
        public static void Main()
        {
            Window window = new Window("Shape Drawer", 800, 600);

            Drawing drawing = new Drawing();

            do
            {
                SplashKit.ProcessEvents();
                SplashKit.ClearScreen();

                if (SplashKit.KeyTyped(KeyCode.SpaceKey))
                {
                    drawing.Background = SplashKit.RandomColor();
                }
                if (SplashKit.MouseClicked(MouseButton.LeftButton))
                {
                    Shape shape = new Shape();
                    drawing.AddShape(shape);
                    shape.X = SplashKit.MouseX();
                    shape.Y = SplashKit.MouseY();
                }
                if (SplashKit.MouseClicked(MouseButton.RightButton))
                {
                    drawing.SelectShapeAt(SplashKit.MousePosition());
                }
                if (SplashKit.KeyTyped(KeyCode.DeleteKey))
                {
                    foreach(Shape shape in drawing.SelectedShapes)
                    {
                        drawing.RemoveShape(shape);
                    }
                }

                drawing.Draw();

                SplashKit.RefreshScreen();
            } while (!window.CloseRequested);

        }
    }
}
