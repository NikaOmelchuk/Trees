using System;
using System.Collections.Generic;
using System.Drawing;

namespace Trees
{
    public class Param
    {
        public int h;
        public int w;
        public Bitmap pic;
    }

    public class ParamOneTree : Param
    {
        public ParamOneTree()
        {
            h = 50;
            w = 50;
            pic = new Bitmap(@"C:\Users\Саша\Desktop\Визуалка\кпз\Trees\Trees\Resources\d1.png");
        }
    }

    public class ParamTwoTree : Param
    {
        public ParamTwoTree()
        {
            h = 50;
            w = 50;
            pic = new Bitmap(@"C:\Users\Саша\Desktop\Визуалка\кпз\Trees\Trees\Resources\d2.png");
        }
    }

    public class ParamThreeTree : Param
    {
        public ParamThreeTree()
        {
            h = 50;
            w = 50;
            pic = new Bitmap(@"C:\Users\Саша\Desktop\Визуалка\кпз\Trees\Trees\Resources\d3.png");
        }
    }

    public class Tree
    {
        public int x, y,h,w;
        public Param p;

        public Tree()
        {
            x = 0; y = 0;
            h = 50; w = 50;
        }
       
        public Tree(int x, int y, int h, int w, Param p)
        {
            this.p = p;
            this.x = x;
            this.y = y;
            this.h = h;
            this.w = w;
        }

        public void rost()
        {
            if(h>150)
            {
                h = 50;
                w = 50;
                x += 50;
                y += 50;
            }
            if (x > 5)
                x -= 5;
            if (y > 5)
                y -= 5;
            h += 10;
            w += 10;
        }
    }
}
