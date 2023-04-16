using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Transactions;

namespace Generics_Labb1
{
    internal class BoxEnumerator : IEnumerator<Box>
    {
        private BoxCollection _Box;
        private int _Index;
        private Box _currentBox;

        public BoxEnumerator(BoxCollection box)
        {
            this._Box = box;
            _Index = -1;
            _currentBox = default(Box);
        }

        public Box Current { get { return _currentBox; } }

        object IEnumerator.Current { get { return _currentBox; } }

        public void Dispose()
        {
            
        }

        public bool MoveNext()
        {
            if(++_Index >= _Box.Count)
            {
                return false; 
            }
            else
            {
                _currentBox = _Box[_Index];
            }
            return true;
        }

        public void Reset()
        {
            _Index= -1;
        }
    }
}
