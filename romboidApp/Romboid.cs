using System;
using System.Collections.Generic;
using System.Text;

namespace romboidApp
{
    public abstract class Romboid
    {
        protected string[] _array;
        protected int _half;
        protected int _leftIndex, _rightIndex;

        public  Romboid(string[] array, int half)
        {
            for (int i = 0; i <= array.Length - 1; i++)
            { array[i] = " "; }
            _array = array;
        
            _half = half;
            _leftIndex = half;
            _rightIndex = half;
        }
        public abstract void write();
        
    }

    public class PaperDragon : Romboid
    {
        public PaperDragon(string[] array, int half) : base(array, half)
        {
        }

        public override void write()
        {   
            while (_leftIndex >= 0 && _rightIndex <= _array.Length -1)
            {
                _array[_leftIndex] = "*";
                _array[_rightIndex] = "*";
                _array[_leftIndex + 1] = " ";
                _array[_rightIndex - 1] = " ";
                _array[_half] = "*";
                if (_leftIndex == 0 && _rightIndex <= _array.Length -1) {
                    for (int i = 0; i <= _array.Length - 1; i++)
                    { _array[i] = "*"; }
                }
             
                string conent = string.Join("", _array);
                Console.WriteLine(conent);
               
                _leftIndex--;
               
                _rightIndex++;

            }
            for (int i = 0; i <= _array.Length - 1; i++)
            { _array[i] = " "; }
            _leftIndex++;
            _rightIndex--;
            
            while (_leftIndex < _half && _rightIndex > _half)
            {
                _array[_leftIndex] = " ";
                _array[_rightIndex] = " ";
                _array[_leftIndex + 1] = "*";
                _array[_rightIndex - 1] = "*";
                _array[_half] = "*";
                string conent = string.Join("", _array);
                Console.WriteLine(conent);
                _leftIndex++;
                _rightIndex--;

            }
        }
    }
    public class CurryBorder : Romboid
    {
        public CurryBorder(string[] array, int half) : base(array, half)
        {
        }

        public override void write()
        {
            while (_leftIndex >= 0 && _rightIndex <= _array.Length)
            {
                _array[_leftIndex] = "*";
                _array[_rightIndex] = "*";
                _array[_leftIndex +1] = " ";
                _array[_rightIndex -1] = " ";
                string conent = string.Join("", _array);
                Console.WriteLine(conent);
                _leftIndex--;
                _rightIndex++;

            }
            _leftIndex++;
            _rightIndex--;
            while (_leftIndex < _half && _rightIndex > _half)
            {
                _array[_leftIndex] = " ";
                _array[_rightIndex] = " ";
                _array[_leftIndex + 1] = "*";
                _array[_rightIndex - 1] = "*";
                string conent = string.Join("", _array);
                Console.WriteLine(conent);
                _leftIndex++;
                _rightIndex--;

            }
        }
    }
    public class Rombo : Romboid
    {
        public Rombo(string[] array, int half) : base(array, half)
        {
        }

        public override void write()
        {

            while (_leftIndex >= 0 && _rightIndex <= _array.Length)
            {
                _array[_leftIndex] = "*";
                _array[_rightIndex] = "*";
                string conent = string.Join("", _array);
                Console.WriteLine(conent);
                _leftIndex--;
                _rightIndex++;
                
            }
            _leftIndex++;
            _rightIndex--;
            while (_leftIndex < _half && _rightIndex > _half)
            {
                _array[_leftIndex] = " ";
                _array[_rightIndex] = " ";
                string conent = string.Join("", _array);
                Console.WriteLine(conent);
                _leftIndex++;
                _rightIndex--;

            }
        }
    }
}
