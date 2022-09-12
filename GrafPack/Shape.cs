using System;
using System.Drawing;

namespace GrafPack
{
    /// <summary>
    /// The Shape class generalises properties and methods common
    /// to Squares, Triangles, and Circles. This class handles
    /// the main 2D matrix transformations necessary to perform
    /// operations like translation, rotation, scaling, and reflection.
    /// </summary>
    abstract class Shape
    {
        // Object properties.
        protected Point[] vertices;
        protected Point centrePoint;
        protected bool isScaling;

        // Properties access methods (Getters & Setters)
        public Point[] GetVertices()
        {
            return vertices;
        }

        // This is needed for the circle class to
        // recalculate its radius on redrawing itself.
        public void SetScaling(bool scaleState)
        {
            isScaling = scaleState;
        }

        // This provides the scale difference between an
        // an original vertex from the centre and the new
        // mouse from the centre.
        public float GetScaleFactor(Point mousePosition)
        {
            float oldDiffX = Math.Abs(vertices[0].X - centrePoint.X);
            float oldDiffY = Math.Abs(vertices[0].Y - centrePoint.Y);

            float newDiffX = Math.Abs(mousePosition.X - centrePoint.X);
            float newDiffY = Math.Abs(mousePosition.Y - centrePoint.Y);

            // Use ternery operator to prevent dividing by zero error.
            float factorX = (oldDiffX != 0) ? newDiffX / oldDiffX : 1;
            float factorY = (oldDiffY != 0) ? newDiffY / oldDiffY : 1;

            return (factorX + factorY) / 2;
        }

        // Abstract & virtual methods where concrete override
        // implementations are provided by child classes.
        // - Draw connects the points of the shape using fundemental
        //   operations.
        // - Move is used for translations via mouse.
        // - UpdateSecondPoint is needed for drawing via rubber-banding.
        public abstract void Draw(Graphics g, Pen penColour);
        public abstract void Move(Point newLocation);

        public virtual void UpdateSecondPoint(Point newLocation)
        {
            vertices[2] = newLocation;
        }

        // Implementation of the rotation operation using
        // coded matrix arithmetic, this will translate
        // each vertex relative to the centre point on
        // a 360 degree arc.
        public void Rotate(double angle)
        {
            double angleInRadians = angle * (Math.PI / 180);
            double cosTheta = Math.Cos(angleInRadians);
            double sinTheta = Math.Sin(angleInRadians);

            // Perform transformation for each vertex in the shape.
            for (int i = 0; i < vertices.Length; i++)
            {
                int originalX = vertices[i].X;
                int originalY = vertices[i].Y;

                // Matrix Arithmetic:
                //  [ x', y'] = [ x, y ] X  [  cos a, sin a ]
                //                          [ -sin a, cos a ]
                vertices[i].X = (int)Math.Round(((originalX - centrePoint.X) * cosTheta) - ((originalY - centrePoint.Y) * sinTheta) + centrePoint.X);
                vertices[i].Y = (int)Math.Round(((originalX - centrePoint.X) * sinTheta) + ((originalY - centrePoint.Y) * cosTheta) + centrePoint.Y);
            }
        }

        // Implementation of the reflection operation using
        // coded matrix arthmetic, this will flip each vertex
        // on the X axis, resulting in a vertically mirrored shape.
        public void FlipVertical()
        {
            // Perform transformation for each vertex in the shape.
            for (int i = 0; i < vertices.Length; i++)
            {
                // Matrix Arithmetic:
                //  [ x', y'] = [ x, y ] X  [ 1,  0 ]
                //                          [ 0, -1 ]
                vertices[i].X = (vertices[i].X * 1) + (vertices[i].Y * 0);
                vertices[i].Y = ((vertices[i].X - centrePoint.X) * 0) + ((vertices[i].Y - centrePoint.Y) * -1) + centrePoint.Y;
            }
        }

        // Implementation of the reflection operation using
        // coded matrix arthmetic, this will flip each vertex
        // on the Y axis, resulting in a horizontally mirrored shape.
        public void FlipHorizontal()
        {
            // Perform transformation for each vertex in the shape.
            for (int i = 0; i < vertices.Length; i++)
            {
                // Matrix Arithmetic:
                //  [ x', y'] = [ x, y ] X  [ -1, 0 ]
                //                          [  0, 1 ]
                vertices[i].X = ((vertices[i].X - centrePoint.X) * -1) + ((vertices[i].Y - centrePoint.Y) * 0) + centrePoint.X;
                vertices[i].Y = (vertices[i].X * 0) + (vertices[i].Y * 1);
            }
        }

        // Implementation of the scaling operation using
        // coded matrix arthmetic, this will increase or
        // decrease the size of the shape by a given factor
        // whilst maintaining relative proportions.
        public void Scale(float factor)
        {
            // Perform transformation for each vertex in the shape.
            for (int i = 0; i < vertices.Length; i++)
            {
                // Matrix Arithmetic:
                //  [ x', y'] = [ x, y ] X  [ f, 0 ]
                //                          [ 0, f ]
                vertices[i].X = (int)Math.Round(((vertices[i].X - centrePoint.X) * factor) + ((vertices[i].Y - centrePoint.Y) * 0) + centrePoint.X);
                vertices[i].Y = (int)Math.Round(((vertices[i].X - centrePoint.X) * 0) + ((vertices[i].Y - centrePoint.Y) * factor) + centrePoint.Y);
            }
        }

        // Implementation of the translation operation using
        // coded matrix arthmetic, this will move (translate)
        // each vertex in a given direction using a new distance.
        public virtual void Translate(int distanceX, int distanceY)
        {
            // Perform transformation for each vertex in the shape.
            for (int i = 0; i < vertices.Length; i++)
            {
                // Matrix Arithmetic:
                //  [ x', y'] = [ x + a, y + b ]
                vertices[i].X = vertices[i].X + distanceX;
                vertices[i].Y = vertices[i].Y + distanceY;
            }
        }

        // Using library supplied methods, drawing a circle around
        // each vertex and the centre point for visual aid to the user.
        // This does not affect the creation or drawing process of a shape.
        public void DrawUI(Graphics g)
        {
            foreach (Point vertex in vertices)
            {
                g.DrawArc(new Pen(Color.Green), vertex.X - 3, vertex.Y - 3, 6, 6, 0, 360);
            }
            g.DrawArc(new Pen(Color.Red), centrePoint.X - 3, centrePoint.Y - 3, 6, 6, 0, 360);
        }
    }
}
