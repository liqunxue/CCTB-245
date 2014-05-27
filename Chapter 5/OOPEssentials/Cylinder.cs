using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPEssentials
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
            Radius = radius;
            Height = height;
        }
        #endregion

        #region Methods
        // TODO: Add Operator to combine Cylinders
        public static Cylinder operator +(Cylinder leftSide, Cylinder rightSide)
        {
            Cylinder result = new Cylinder(leftSide.Radius, leftSide.Height + rightSide.Height);
            return result;
        }
        #endregion

    }
}
