using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generics_Labb1
{
    internal class BoxSameVol : IEqualityComparer<Box>
    {
        public bool Equals(Box x, Box y)
        {
            if (x.Length * x.Width * x.Height == y.Length * y.Width * y.Height)
            {
                return true;
            }
            return false;
        }

        public int GetHashCode([DisallowNull] Box obj)
        {
            throw new NotImplementedException();
        }
    }
}
