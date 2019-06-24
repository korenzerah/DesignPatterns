namespace DesignPatterns.adapter
{
    public class Adapter3Dto2D : D3Painter
    {
        private D2Painter painter = new D2NicePainter();
        public void Paint3DShape(D3Shape s)
        {
            s.shapes.ForEach((x) => painter.PaintD2Shape(x));
        }
    }
}