﻿using System;
using DesignPatterns.adapter;

namespace DesignPatterns
{
    class Program
    {
        static void Main(string[] args)
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
