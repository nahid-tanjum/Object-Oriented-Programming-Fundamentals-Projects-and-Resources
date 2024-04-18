using System;
using System.Security.AccessControl;
using SplashKitSDK;

namespace ShapeDrawer
{
    public class MyLine : Shape
    {
        private float _endX; private float _endY;
        public MyLine (Color clr, float startX, float startY, float endX, float endY)
        {
            X = startX;
            Y = startY;
            EndX = endX;
            EndY = endY;
        }
        public MyLine() : this(SplashKit.ColorYellow(), 0, 0, 100, 100) { }
        public float EndX
        { get { return _endX; } set { _endX = value; } }
        public float EndY
        { get { return _endY; } set { _endY = value; } }

        public override void Draw()
        {
            if (Selected)
                DrawOutline();
            SplashKit.DrawLine(Color, X, Y, EndX, EndY);
        }
        public override void DrawOutline() 
        {

            SplashKit.DrawCircle(Color.Red, X, Y, 10);
            SplashKit.DrawCircle(Color.Red, EndX, EndY, 10);
        }
        public override bool IsAt (Point2D point)
        {
            return SplashKit.PointOnLine(point, SplashKit.LineFrom(X, Y, EndX, EndY));
        }
    }
}

