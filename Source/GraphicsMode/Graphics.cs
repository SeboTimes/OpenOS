using System;
using Sys = Cosmos.System;
using Cosmos.System.Graphics;
using System.Drawing;

namespace OpenOS.Source.GraphicsMode
{
    internal class Graphics
    {
        private Canvas canvas;
        private Pen pen;

        public Graphics() 
        {
            canvas = FullScreenCanvas.GetFullScreenCanvas(new Mode(640, 480, ColorDepth.ColorDepth32));
            pen = new Pen(Color.White, 5);
        }

        public void Draw()
        {
            canvas.Clear();
        }
    }
}
