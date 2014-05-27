using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AboutExceptions
{
    public class Cylinder
    {
        #region Properties
        // Auto-implemented properties
        public double Radius { get; protected set; }
        public double Height { get; protected set; }
        // Regular property - getter only
        public double Volume
        {
            get
            {
                double result = Math.PI * Radius * Radius * Height;
                return result;
            }
        }
        #endregion

        #region Constructors
        public Cylinder(double radius, double height)
        {
            // basic validation
            if (radius <= 0)
                throw new ArgumentException("A cylinder must have a radius greater than zero");

            if (height <= 0)
                throw new ArgumentException("A cylinder must have a height greater than zero");
            
            Radius = radius;
            Height = height;
        }
        #endregion

        #region Methods
        // TODO: Add Operator to combine Cylinders
        public static Cylinder operator +(Cylinder leftSide, Cylinder rightSide)
        {
            // We cannot combine cylinders with different radius
            if(leftSide.Radius != rightSide.Radius)
                throw new NotSupportedException("Cannot add two cylinders with different radius values");
            Cylinder result = new Cylinder(leftSide.Radius, leftSide.Height + rightSide.Height);
            return result;
        }
        #endregion

    }
}
