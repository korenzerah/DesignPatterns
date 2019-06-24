using System;
namespace DesignPatterns.adapter
{
    public class D3NicePainter : D3Painter
    {
        public void Paint3DShape(D3Shape s) {
            Console.WriteLine(s.ToString());
        }
    }
}