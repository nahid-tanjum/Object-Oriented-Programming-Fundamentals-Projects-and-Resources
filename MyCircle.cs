using System;
using System.Drawing;
using System.Security.Cryptography.X509Certificates;
using SplashKitSDK;


namespace ShapeDrawer
{
    public class MyCircle : Shape
    {
        private int _radius;

        public MyCircle(SplashKitSDK.Color color, int radius) : base(color)
        {
            _radius = radius;
        }
        public MyCircle() : this(SplashKitSDK.Color.Blue, 50) { }

        public int Radius
        {
            get { return _radius; }
            set { _radius = value; }
        }
        public override void Draw()
        {
            if (Selected) 
                DrawOutline();
            SplashKit.FillCircle(Color, X, Y, _radius);
        }
        public override void DrawOutline()
        {
            SplashKit.DrawCircle(SplashKit.ColorBlack(), X, Y, _radius + 2);
        }
        public override bool IsAt(Point2D point)
        {
            return SplashKit.PointInCircle(point, SplashKit.CircleAt(this.X, this.Y, _radius));
        }
    }
}
