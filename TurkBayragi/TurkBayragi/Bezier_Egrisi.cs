using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;
using System.Drawing.Drawing2D;

namespace TurkBayragi
{
    class Bezier_Egrisi
    {
        private static float X(float t, float x_0, float x_1, float x_2, float x_3)
        {
            return (float)(
                x_0 * Math.Pow((1 - t), 3) +
                x_1 * 3 * t * Math.Pow((1 - t), 2) +
                x_2 * 3 * Math.Pow(t, 2) * (1 - t) +
                x_3 * Math.Pow(t, 3)
            );
        }
        private static float Y(float t, float y_0, float y_1, float y_2, float y_3)
        {
            return (float)(
                y_0 * Math.Pow((1 - t), 3) +
                y_1 * 3 * t * Math.Pow((1 - t), 2) +
                y_2 * 3 * Math.Pow(t, 2) * (1 - t) +
                y_3 * Math.Pow(t, 3)
            );
        }

        public static void Bezier_Ciz(Graphics g, Pen kalem, float dt, PointF n_0, PointF n_1, PointF n_2, PointF n_3)
        {
            float t, x_0, y_0, x_1, y_1;
            t = 0.0f;
            x_1 = X(t, n_0.X, n_1.X, n_2.X, n_3.X);
            y_1 = Y(t, n_0.Y, n_1.Y, n_2.Y, n_3.Y);
            t += dt;

            while (t < 1.0)
            {
                x_0 = x_1;
                y_0 = y_1;
                x_1 = X(t, n_0.X, n_1.X, n_2.X, n_3.X);
                y_1 = Y(t, n_0.Y, n_1.Y, n_2.Y, n_3.Y);
                g.DrawLine(kalem, x_0, y_0, x_1, y_1);
                t += dt;
            }

            t = 1.0f;
            x_0 = x_1;
            y_0 = y_1;
            x_1 = X(t, n_0.X, n_1.X, n_2.X, n_3.X);
            y_1 = Y(t, n_0.Y, n_1.Y, n_2.Y, n_3.Y);
            g.DrawLine(kalem, x_0, y_0, x_1, y_1);

        }
    }
}
