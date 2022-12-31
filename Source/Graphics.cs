using System;
using System.Drawing;

using Sys = Cosmos.System;
using Cosmos.System.Graphics;

namespace OpenOS.Source
{
    internal class Graphics
    {
        Canvas canvas;
        Pen pen;

        int width;
        int height;

        public Graphics() 
        {
            Mode mode = new Mode(1280, 720, ColorDepth.ColorDepth32); // 1280x720

            width = mode.Columns;
            height = mode.Rows;

            Console.WriteLine("Width:  " + width.ToString());
            Console.WriteLine("Height: " + height.ToString());
            Console.WriteLine("Press any key to continue.");
            Console.ReadKey();

            canvas = FullScreenCanvas.GetFullScreenCanvas(mode);
            pen = new Pen(Color.White);
            canvas.Clear(Color.Blue);
        }

        public void Draw()
        {
            canvas.DrawFilledRectangle(pen, width, height - (height / 16), width, 2);
            pen.Color = Color.Gray;
            canvas.DrawFilledCircle(pen, width / 2, height / 2, 128);
            canvas.Display();

            Console.ReadKey();
            Sys.Power.Reboot();
        }
    }
}
