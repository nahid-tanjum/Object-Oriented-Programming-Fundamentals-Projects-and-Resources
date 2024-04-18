using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SplashKitSDK;


namespace ShapeDrawer
{
    public class Shape
    {
        private SplashKitSDK.Color _color;
        private float _x, _y;
        private int _width, _height;
        private bool _selected;

        public Shape()
        {
            _color = SplashKitSDK.Color.Green;
            _x = _y = 0;
            _width = _height = 100;
            _selected = false;
        }

        public Color Color
        {
            get { return _color; }
            set { _color = value; }
        }

        public float X
        {
            get { return _x; }
            set { _x = value; }
        }

        public float Y
        {
            get { return _y; }
            set { _y = value; }
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
        public bool Selected 
        {
            get { return _selected; } 
            set { _selected = value; }
        }
        
            
        

        public void Draw()
        {
            SplashKit.FillRectangle(_color, _x, _y, _width, _height);
            if (_selected ) 
            {
                this.DrawOutline();
            }
        }

        public bool IsAt(Point2D pt)
        {
            if (pt.X >= _x && pt.X <= _x + _width &&
                pt.Y >= _y && pt.Y <= _y + _height)
                return true;
            else
                return false;
        }
        public void DrawOutline()
        {
                SplashKit.DrawRectangle(Color.Black, _x - 2, _y - 2, _width + 4, _height + 4);
            
        }
    }


}

