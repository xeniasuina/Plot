namespace Plot
{
    public class Painter
    {
        private Graphics? _graphics;
        private Pen _pen;

        public Func<double, double> Function { get; set; } = (double x) => Math.Pow(x, 2);

        public Painter(Graphics g)
        {
            _graphics = g;
            _pen = new Pen(Color.Black, 3);

           //  _graphics.Clear(Color.White);
        }

        public void DrawAxes()
        {
            if (_graphics == null)
            {
                return;
            }

            _pen.Color = Color.LightGray;

            // OX: 
            if (Converter.YMin <= 0 && Converter.YMax >= 0)
            {
                _graphics.DrawLine(
                    _pen,
                    new Point(0, Converter.YCrt2Scr(0.0)),
                    new Point(Converter.Width, Converter.YCrt2Scr(0.0))
                );
            }
            else
            {
                _graphics.DrawLine(
                    _pen,
                    new Point(0, 0),
                    new Point(Converter.Width, 0)
                );
                _graphics.DrawLine(
                    _pen,
                    new Point(0, Converter.Height),
                    new Point(Converter.Width, Converter.Height)
                );
            }

            // OY: 
            if (Converter.XMin <= 0 && Converter.XMax >= 0)
            {
                _graphics.DrawLine(
                    _pen,
                    new Point(Converter.XCrt2Scr(0.0), 0),
                    new Point(Converter.XCrt2Scr(0.0), Converter.Height)
                );
            }
            else
            {
                _graphics.DrawLine(
                    _pen,
                    new Point(0, 0),
                    new Point(0, Converter.Height)
                );
                _graphics.DrawLine(
                    _pen,
                    new Point(Converter.Width, 0),
                    new Point(Converter.Width, Converter.Height)
                );
            }
        }

        public void DrawLabels()
        {
            if (_graphics == null)
            {
                return;
            }

            var font = new Font("Cambria", 8, FontStyle.Bold);

            var x0 = Converter.XCrt2Scr(0.0);
            var y0 = Converter.YCrt2Scr(0.0);
            if (x0 <= 0) x0 = 0;

            if (x0 > Converter.Width) x0 = Converter.Width;
            if (y0 <= 0) y0 = 0;
            if (y0 > Converter.Height) y0 = Converter.Height;

            var brush = new SolidBrush(Color.Blue);

            var deltaX = (Converter.XMax - Converter.XMin) switch
            {
                < 10 => 10.0,
                < 24 => 5.0,
                < 36 => 2.5,
                _ => 1.25
            };

            for (var i = (int)(Converter.XMin * deltaX); i < (int)(Converter.XMax * deltaX); i += 1)
            {
                var x = Converter.XCrt2Scr(i / deltaX);

                var m = _graphics.MeasureString((i / deltaX).ToString(), font);
                var dx = (int)m.Width;
                var dy = (int)m.Height;

                _graphics.DrawString((i / deltaX).ToString(), font, brush, new Point(x - dx / 2, y0 + dy - 10));
            }

            var deltaY = (Converter.YMax - Converter.YMin) switch
            {
                < 10 => 10.0,
                < 24 => 5.0,
                < 36 => 2.5,
                _ => 1.25
            };

            for (var i = (int)(Converter.YMin * deltaY); i < (int)(Converter.YMax * deltaY); i += 1)
            {
                var y = Converter.YCrt2Scr(i / deltaY);

                var m = _graphics.MeasureString((i / deltaY).ToString(), font);
                var dx = (int)m.Width;
                var dy = (int)m.Height;

                var dt = 0;
                if (x0 > Converter.Width - dx) dt = dx + 5;
                _graphics.DrawString((i / deltaY).ToString(), font, brush, new Point(x0 + 4 - dt, y + dy / 3));
            }

        }

        public void DrawStrokes()
        {
            if (_graphics == null)
            {
                return;
            }

            var dt = 2;
            _pen.Color = Color.Black;
            var x0 = Converter.XCrt2Scr(0.0);
            var y0 = Converter.YCrt2Scr(0.0);

            if (x0 <= 0) x0 = 0;
            if (x0 > Converter.Width) x0 = Converter.Width;
            if (y0 <= 0) y0 = 0;
            if (y0 > Converter.Height) y0 = Converter.Height;

            var deltaX = (Converter.XMax - Converter.XMin) switch
            {
                < 10 => 10.0,
                < 24 => 5.0,
                < 36 => 2.5,
                _ => 1.25
            };

            for (var i = (int)(Converter.XMin * deltaX); i < (int)(Converter.XMax * deltaX); i += 1)
            {
                var gap = 0;
                if (i % 10 == 0) gap = 2;
                if (i % 5 == 0) gap = 1;
                var x = Converter.XCrt2Scr(i / deltaX);

                _graphics.DrawLine(
                    _pen,
                    new Point(x, y0 - dt - gap),
                    new Point(x, y0 + dt + gap)
                );
            }

            var deltaY = (Converter.YMax - Converter.YMin) switch
            {
                < 10 => 10.0,
                < 24 => 5.0,
                < 36 => 2.5,
                _ => 1.25
            };

            for (var i = (int)(Converter.YMin * deltaY); i < (int)(Converter.YMax * deltaY); i += 1)
            {
                var gap = 0;
                if (i % 10 == 0) gap = 2;
                if (i % 5 == 0) gap = 1;
                var y = Converter.YCrt2Scr(i / deltaY);

                _graphics.DrawLine(
                    _pen,
                    new Point(x0 - dt - gap, y),
                    new Point(x0 + dt + gap, y)
                );
            }
        }

        public void DrawFunction()
        {
            if (_graphics == null)
            {
                return;
            }

            for (var i = 0; i < Converter.Width; i+=1)
            {
                _graphics.DrawLine(
                    _pen,
                    new Point(i, Converter.YCrt2Scr(Function(Converter.XScr2Crt(i)))),
                    new Point(i + 1, Converter.YCrt2Scr(Function(Converter.XScr2Crt(i + 1))))
                );
            }
        }

        public void DrawArea(double a, double b, int n)
        {
            if (_graphics == null)
            {
                return;
            }

            var brush = new SolidBrush(Color.IndianRed);
            var startX = Converter.XCrt2Scr(a);
            var endX = Converter.XCrt2Scr(b);
            var y0 = Converter.YCrt2Scr(0.0);

            var points = new List<PointF> { new PointF(startX, y0) };

            for (var i = startX; i < endX; i += 1)
            {
                var y = Converter.YCrt2Scr(Function(Converter.XScr2Crt(i)));
                if (y < 0) continue;
                points.Add(new PointF(i, y));
            }

            points.Add(new PointF(endX, y0));

            _graphics.FillPolygon(brush, points.ToArray());

            _pen.Color = Color.Black;
            _pen.Width = 1;
            var h = (double)(b - a) / n;

            for (var i = 0; i <= n; i += 1)
            {
                _graphics.DrawLine(
                    _pen,
                    new PointF(Converter.XCrt2Scr((float)a + i * h), y0),
                    new PointF(Converter.XCrt2Scr((float)a + i * h), Converter.YCrt2Scr(Function(a + i * h)))
                );
            }
        }

        public void Repaint()
        {
            if (_graphics == null)
            {
                return;
            }

            _graphics.Clear(Color.White);
            DrawAxes();
            DrawLabels();
            DrawStrokes();
            DrawFunction();
        }
    }
}
