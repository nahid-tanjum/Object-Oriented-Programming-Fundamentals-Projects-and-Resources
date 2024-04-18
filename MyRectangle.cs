using System;
using SplashKitSDK;
using System.Drawing;

namespace ShapeDrawer
{
    public class MyRectangle : Shape
    {
        private int _width;
        private int _height;

        public MyRectangle(SplashKitSDK.Color color, float x, float y, int width, int height) : base(color)
        {
            X = x;
            Y = y;
            Width = width;
            Height = height;
        }
        public MyRectangle() : this(SplashKitSDK.Color.Green, 0, 0, 100, 100) { }
        public override void Draw()
        {
            if (Selected)
                DrawOutline();
            SplashKit.FillRectangle(Color, X, Y, Width, Height);
        }
        public override void DrawOutline()
        {
            SplashKit.DrawRectangle(SplashKit.ColorBlack(), X - 2, Y - 2, _width + 4, _height + 4);
        }
        public override bool IsAt(Point2D point)
        {
            if ((((point.X >= X) && (point.X <= (X + _width))) && (point.Y >= Y) && (point.Y <= (Y + _height))))
                return true; else return false;
        }
        public int Width
        {
            get { return _width; }
            set { _width = value; }
        }

        public int Height
        {
            get { return _height; }
            set { _height = value; }
        }
    }
}
