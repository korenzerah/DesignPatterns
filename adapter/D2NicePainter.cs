using System;
namespace DesignPatterns.adapter
{
    public class D2NicePainter : D2Painter
    {
        public void PaintD2Shape(D2Shape s) {
            Console.WriteLine(s.ToString());
        }
    }
}