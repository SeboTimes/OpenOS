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
            canvas = FullScreenCanvas.GetCurrentFullScreenCanvas();
            pen = new Pen(Color.White);

            //canv
        }

        public void Draw()
        {
            //canvas
        }
    }
}
