using System.Diagnostics.CodeAnalysis;

namespace Generics_Labb1
{
    public class BoxSameDimensions : IEqualityComparer<Box>
    {
        public bool Equals(Box x, Box y)
        {
            if(x.Height == y.Height && x.Width == y.Width && x.Length == y.Length)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public int GetHashCode([DisallowNull] Box obj)
        {
            throw new NotImplementedException();
        }
    }
}