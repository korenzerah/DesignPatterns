namespace DesignPatterns.abstract_factory
{
    public abstract class DocumentMakerFactoryBase
    {
        public abstract DocumentCaptionBase createCaption(Data d);
        public abstract DocumentBodyBase createBody(Data d);
        public abstract DocumentFooterBase createFooter(Data d);
        public abstract DocumentGraphicsBase createGraphics(Data d);
    }
}