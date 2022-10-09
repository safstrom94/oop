using System;

namespace oop
{
    class Program
    {
        static void Main(string[] args)
        {
            Curcle curcle1 = new Curcle(5);
            Curcle curcle2 = new Curcle(6);                
            float result1 = curcle1.getArea();
            float result2 = curcle2.getArea();
            Console.WriteLine(result1);
            Console.WriteLine(result2); 
        }
    }
    class Curcle
    {
     public float _pi = 3.141f;
     public float _Radius;     
        public Curcle(float _aRadius)
        {
            this._Radius = _aRadius;
        }      
        public float getArea()
        {
            float Area = (float)_Radius * _Radius * _pi;
            return Area;
        }
    }
}
