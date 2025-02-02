﻿using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TagsCloudVisualization
{
    public interface ICloudVisualizer
    {
        void DrawRectangle(Pen pen, Rectangle rectangle);
        void DrawRectangles(Pen pen, List<Rectangle> rectangles);
        Bitmap GetImage();
    }
}
