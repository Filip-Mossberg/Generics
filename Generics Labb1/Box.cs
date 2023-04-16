using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generics_Labb1
{
     public class Box : IEquatable<Box>
    {
        public int Height { get; set; }
        public int Width { get; set; }
        public int Length { get; set; }

        public Box(int h, int w, int l)
        {
            Height = h;
            Width = w;
            Length = l;
        }

        public bool Equals(Box other)
        {
            if(new BoxSameDimensions().Equals(this, other))
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public override bool Equals(object obj)
        {
            return base.Equals(obj);
        }

        public override int GetHashCode()
        {
            return base.GetHashCode();
        }
    }
}
