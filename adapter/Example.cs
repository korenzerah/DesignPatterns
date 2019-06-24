using System;

namespace DesignPatterns.adapter
{
    class MainOfAdapter
    {
        static void Example(string[] args)
        {
            D3Shape s = new D3Shape();
            Adapter3Dto2D a = new Adapter3Dto2D();
            Draw(a, s);
        }

        static void Draw(D3Painter p, D3Shape s) {
            p.Paint3DShape(s);
        }
    }
}
